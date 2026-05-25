using DataAccess.Entities;
using Presentation.DataBase.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.UserControls
{
    public partial class ucHistory : UserControl
    {
        public ucHistory()
        {
            InitializeComponent();
            dgvHistory.CellContentClick += dgvHistory_CellContentClick;
        }
        int _ProcessNo_FromSelectEvent = 0;

        private List<OperationsProcess> _History = new List<OperationsProcess>();

        private void _InitializeHistoryGrid()
        {
            dgvHistory.Columns.Clear();

            dgvHistory.AutoGenerateColumns = false;

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colProcessNo",
                HeaderText = "Process No.",
                DataPropertyName = "ProcessNo"
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colWoodType",
                HeaderText = "Wood Type (Category)",
                DataPropertyName = "WoodType"
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colProductDimension",
                HeaderText = "Product Dimension",
                DataPropertyName = "ProductDimension"
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colProductionVolume",
                HeaderText = "Production Volume",
                DataPropertyName = "ProductionVolume"
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTotalFees",
                HeaderText = "Total Fees",
                DataPropertyName = "TotalFees"
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colConsumedElectricity",
                HeaderText = "Consumed Electricity",
                DataPropertyName = "ConsumedElectricity"
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colStartAt",
                HeaderText = "Start At",
                DataPropertyName = "StartAt"
            });

            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colEndAt",
                HeaderText = "End At",
                DataPropertyName = "EndAt"
            });

            // DETAILS BUTTON COLUMN
            DataGridViewButtonColumn btnDetails = new DataGridViewButtonColumn()
            {
                Name = "colDetails",
                HeaderText = "Details",
                Text = "View",
                UseColumnTextForButtonValue = true
            };

            dgvHistory.Columns.Add(btnDetails);
        }
        private void ucHistory_Load(object sender, EventArgs e)
        {
            _InitializeHistoryGrid();
            _History = Utility.GetOperationsProcessHistory();

            if (_History.Count == 0)
                lblEmptyText.Visible = true;
            else
            {
                foreach (var process in _History)
                {
                    string WoodTypeAndCatetogry = $"{process.WoodType.Type} ({process.WoodType.Category})";
                    string ProductDimantions = $"{process.ProductionCondition.ProductWidth} x {process.ProductionCondition.ProductHeight}";
                    AddHistoryRow(process.Id,
                                   WoodTypeAndCatetogry,
                                   ProductDimantions,
                                   process.ProductionCondition.ProductionVolume,
                                   Convert.ToDecimal(process.ProductionCondition.TotalFees),
                                   process.OperationCondition.ConsumedElectricity,
                                   process.auditTimestamp.StartAt,
                                   process.auditTimestamp.EndAt
                                   );
                }
            }
            _LoadHistoryChart();
            _FullCardsInfomations();
  
        }

        private void _FullCardsInfomations()
        {
            lblTotalFees.Text = _History.Where(x => x.auditTimestamp.EndAt.CompareTo(DateTime.Now.AddDays(-10)) <= 0).Sum(x => x.ProductionCondition.TotalFees).ToString("c");
            lblConsumedEnergy.Text = _History.Where(x => x.auditTimestamp.EndAt.CompareTo(DateTime.Now.AddDays(-30)) <= 0).Sum(x => x.OperationCondition.ConsumedElectricity).ToString("F2")+" KWh";
            lblProductionVolume.Text = _History.Where(x=>x.auditTimestamp.EndAt.CompareTo(DateTime.Now.AddDays(-30)) <= 0).Sum(x => x.ProductionCondition.ProductionVolume).ToString("F2") + " M³";
            _LoadWoodTypeChart();
        }

        private void _LoadWoodTypeChart()
        {
            var data = _History
                .GroupBy(x => x.WoodType.Type)
                .Select(x => new
                {
                    WoodType = x.Key,
                    Count = x.Count()
                })
                .OrderByDescending(x => x.Count)
                .Take(4)
                .Reverse()
                .ToList();

            string[] labels = data
                .Select(x => x.WoodType)
                .ToArray();

            double[] values = data
                .Select(x => (double)x.Count)
                .ToArray();

            formsPlot2.Plot.Clear();

           


            // transparent background
            formsPlot2.Plot.FigureBackground.Color = ScottPlot.Colors.Transparent;
            formsPlot2.Plot.DataBackground.Color = ScottPlot.Colors.Transparent;

            // create horizontal bars
            var barPlot = formsPlot2.Plot.Add.Bars(values);

            // make horizontal
            barPlot.Horizontal = true;

            // different colors
            ScottPlot.Color[] colors =
              {
                ScottPlot.Color.FromHex("#D96C1A"), // burnt orange
                ScottPlot.Color.FromHex("#1F5F5B"), // deep teal
                ScottPlot.Color.FromHex("#C89B3C"), // soft gold
                ScottPlot.Color.FromHex("#4E6E81")  // slate blue
              };

            for (int i = 0; i < barPlot.Bars.Count; i++)
            {
                barPlot.Bars[i].FillColor = colors[i % colors.Length];
            }

            // Y-axis labels
            formsPlot2.Plot.Axes.Left.TickGenerator =
                new ScottPlot.TickGenerators.NumericManual(
                    positions: Enumerable.Range(0, labels.Length)
                        .Select(x => (double)x)
                        .ToArray(),
                    labels: labels);

            // remove grid if desired
            formsPlot2.Plot.HideGrid();

            formsPlot2.Height = 80;

            // Hide X axis completely
            formsPlot2.Plot.Axes.Bottom.IsVisible = false;

            // Optional: hide top axis too
            formsPlot2.Plot.Axes.Top.IsVisible = false;
            formsPlot2.Plot.Axes.Right.IsVisible = false;

            barPlot.Bars[0].LineWidth = 0;
            barPlot.Bars[1].LineWidth = 0;
            barPlot.Bars[2].LineWidth = 0;
            barPlot.Bars[3].LineWidth = 0;

            formsPlot2.Font = new Font("Segoe UI", 9, FontStyle.Italic);

            // Optional: hide grid
            formsPlot2.Plot.HideGrid();


            formsPlot2.Refresh();
        }
        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvHistory.Columns[e.ColumnIndex].Name == "colDetails")
            {
                string processNo =
                    dgvHistory.Rows[e.RowIndex]
                    .Cells["colProcessNo"]
                    .Value!
                    .ToString()!;

                /*
        * 
        * 
        * 
        */

                var _TargetRow = _History.SingleOrDefault(x => x.Id == Convert.ToInt32(processNo));
                string _Message = $"StadiedTheta [Degree]: {_TargetRow.CriticalValues.StadiedTheta}\n\n" +
                    $"CuttingForce [N]: {_TargetRow.CriticalValues.CuttingForce}\n" +
                    $"ActiveForce [N]: {_TargetRow.CriticalValues.ActiveForce}\n" +
                    $"Friction Force On Rake [N]: {_TargetRow.CriticalValues.FrictionForceOnRake}\n" +
                    $"Thrust Force [N]: {_TargetRow.CriticalValues.ThrustForce}\n" +
                    $"Shear Force [N]: {_TargetRow.CriticalValues.ShearForce}\n" +
                    $"Normal Force To Shear [N]: {_TargetRow.CriticalValues.NormalForceToShear}\n" +
                    $"Normal Force To Rake [N]: {_TargetRow.CriticalValues.NormalForceToRake}\n" +
                     $"Cutting Moment [N.m]: {_TargetRow.CriticalValues.CuttingMoment}\n"+
                    $"Friction Angle [Degree]: {_TargetRow.CriticalValues.FrictionAngle}\n" +
                    $"Shear Angle [Degree]: {_TargetRow.CriticalValues.ShearAngle}\n" +
                    $"Enter Angle [Degree]: {_TargetRow.CriticalValues.EnterAngle}\n" +
                    $"Leaving Angle [Degree]: {_TargetRow.CriticalValues.LeavingAngle}\n" +
                    $"Center Angle [Degree]: {_TargetRow.CriticalValues.CenterAngle}\n" +
                    $"Friction Correction Cofficient [None]: {_TargetRow.CriticalValues.FrictionCorrectionCofficient}\n" +
                    $"Cutting Speed [M/min]: {_TargetRow.OperationCondition.CuttingSpeed}\n" +
                    $"Feed Rate [M/min]: {_TargetRow.OperationCondition.FeedRate}\n" +
                    $"Sheft Speed [RPM]: {_TargetRow.OperationCondition.SheftSpeed}\n";

                MessageBox.Show(
                    $"Details for Process No [{processNo}]:\n\n{_Message}","Details");
            }
        }

        private void AddHistoryRow(int processNo, string woodType, string productDimension, double productionVolume, decimal totalFees, double consumedElectricity, DateTime startAt, DateTime endAt)
        {
            dgvHistory.Rows.Add(processNo, woodType, productDimension, productionVolume, totalFees, consumedElectricity, startAt.ToString("yyyy-MM-dd HH:mm"), endAt.ToString("yyyy-MM-dd HH:mm"), "View");
        }

        private void dgvHistory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dgvHistory.ClearSelection();

                dgvHistory.Rows[e.RowIndex].Selected = true;

                dgvHistory.CurrentCell =
                    dgvHistory.Rows[e.RowIndex].Cells[0];
                _ProcessNo_FromSelectEvent = Convert.ToInt32(dgvHistory.Rows[e.RowIndex].Cells[0].Value!);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_ProcessNo_FromSelectEvent.ToString());
        }


        private void _LoadHistoryChart()
        {
            // =========================================
            // Group by hour
            // =========================================

            var grouped = _History
                .GroupBy(x => new DateTime(
                    x.auditTimestamp.StartAt.Year,
                    x.auditTimestamp.StartAt.Month,
                    x.auditTimestamp.StartAt.Day,
                    x.auditTimestamp.StartAt.Hour,
                    0,
                    0))
                .OrderBy(x => x.Key)
                .Select(x => new
                {
                    Date = x.Key,

                    // MUCH BETTER THAN Count()
                    Production =
                        x.Sum(y => y.ProductionCondition.ProductionVolume)
                })
                .ToList();

            // =========================================
            // X axis
            // =========================================

            double[] xs = grouped
                .Select(x => x.Date.ToOADate())
                .ToArray();

            // =========================================
            // Actual values
            // =========================================

            double[] values = grouped
                .Select(x => x.Production)
                .ToArray();

            // =========================================
            // Trend line
            // =========================================

            double[] trend = new double[values.Length];

            int window = 3;

            for (int i = 0; i < values.Length; i++)
            {
                int start = Math.Max(0, i - window + 1);

                double avg = 0;
                int c = 0;

                for (int j = start; j <= i; j++)
                {
                    avg += values[j];
                    c++;
                }

                trend[i] = avg / c;
            }

            // =========================================
            // Clear
            // =========================================

            formsPlot1.Plot.Clear();

            // =========================================
            // Actual line
            // =========================================

            var actualLine = formsPlot1.Plot.Add.Scatter(xs, values);

            actualLine.LineWidth = 1;
            actualLine.MarkerSize = 4;
            actualLine.Color = ScottPlot.Colors.DodgerBlue;
            actualLine.LegendText = "Production Volume";

            // =========================================
            // Trend line
            // =========================================

            var trendLine = formsPlot1.Plot.Add.Scatter(xs, trend);

            trendLine.LineWidth = 3;
            trendLine.Color = ScottPlot.Colors.OrangeRed;
            trendLine.LegendText = "Trend";

            // =========================================
            // Titles
            // =========================================

            formsPlot1.Plot.Title("Production History");

            formsPlot1.Plot.XLabel("Date & Time");

            formsPlot1.Plot.YLabel("Production Volume");

            // =========================================
            // Date axis
            // =========================================

            formsPlot1.Plot.Axes.DateTimeTicksBottom();

            // =========================================
            // Legend
            // =========================================

            formsPlot1.Plot.ShowLegend();

            // =========================================
            // AutoScale
            // =========================================

            formsPlot1.Plot.Axes.AutoScale();

            // =========================================
            // Refresh
            // =========================================

            formsPlot1.Refresh();
        }
    }
}
