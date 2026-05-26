using DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Presentation.DataBase.Wood;
using Presentation.Forms;
using Presentation.UserControls;
using ScottPlot.Plottables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        // Database operations
        private void _FullComboBoxWithWoodTypes()
        {
            List<WoodType> Types = WoodCRUD.GetWoodList();

            foreach (WoodType type in Types)
            {
                cbWoodType.Items.Add(type.Type);
            }
            cbWoodType.SelectedIndex = 0;
        }

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            _IntializeMachinePerformancePage();
            _IntializeHistoryPage();
            _IntializeMaintenancePage();
        }
        private Panel pnlMachinePerformence;
        private Panel pnlHistoryPage;
        private Panel pnlMaintenancePage;
        private ucMachinePerformance MachinePerformanceControl;


        private DataGridView dgvForces;
        private DataGridView dgvAngleAndthickness;

        private void InitializeDataGridView()
        {
            dgvAngleAndthickness = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            };

            dgvAngleAndthickness.Columns.Add("AnglesOfTeethInvolvedInCuttingInDegrees", "Angles Of Teeth Involved In Cutting [Degrees]");
            dgvAngleAndthickness.Columns.Add("ChipThicknessAtStudiedAnglesInMeter", "Chip thickness at studied Angles [Meter]");


            dgvForces = new DataGridView
            {
                Dock = DockStyle.Top,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,

            };

            dgvForces.Columns.Add("Theta", "Theta");
            dgvForces.Columns.Add("CuttingForce", "Cutting Force");
            dgvForces.Columns.Add("ActiveForce", "Active Force");
            dgvForces.Columns.Add("FrictionForce", "Friction Force on Rake");
            dgvForces.Columns.Add("ThrustForce", "Thrust Force");
            dgvForces.Columns.Add("ShearForce", "Shear Force");
            dgvForces.Columns.Add("NormalShear", "Normal Force to Shear Plane");
            dgvForces.Columns.Add("NormalRake", "Normal Force to Rake");
            dgvForces.Columns.Add("CuttingForceMoment", "Cutting Force Moment");


            // Dock DataGridView inside the panel
            pnlForceValues.Controls.Clear();     // optional (remove old controls)
            pnlAnglesWithThickness.Controls.Clear();

            pnlForceValues.Controls.Add(dgvForces);
            pnlAnglesWithThickness.Controls.Add(dgvAngleAndthickness);
        }

        public void AddForceRow(double theta, double cuttingForce, double activeForce, double frictionForce, double thrustForce, double shearForce, double normalToShear, double normalToRake, double MomentOfCuttingForce)
        {
            dgvForces.Rows.Add(theta, cuttingForce, activeForce, frictionForce, thrustForce, shearForce, normalToShear, normalToRake, MomentOfCuttingForce);
        }

        public void AddAngleWithChipThicknessRow(double Angle, double chipThickness)
        {
            dgvAngleAndthickness.Rows.Add(Angle, chipThickness);
        }



        // Cutting Environment
        private double _FeedVelocity = .0d;
        private double _MaxCuttingVelocity = .0d;
        private double _CoefficientOfFriction = .0d;
        private double _DepthOfCutWoodInMeter = .0d;
        private int _NumberOfBlades = 0;
        private double _TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWoodInMeter = .0d;
        private double _VolumetricProductionRateMeter3Hour = .0d;


        // Tool Properties 
        private double _RakeAngleInDegrees = .0d;
        private double _BladeDiameter = .0d;
        private double _KerfThicknessInMeter = .0d;
        private int _NumberOfTooth = 0;



        // Calculated Values
        double _FeedPerTeethInMeterPerTeeth = .0d;
        double _NumberOfRotationsInRPM = .0d;
        double _FrictionAngleInDegrees = .0d;
        double _ShearAngleInDegrees = .0d;
        double _FrictionCorrectionCoefficient = .0d;
        double _ShearingStrainAlongShearPlane = .0d;
        double _EnterAngleInDegrees = .0d;
        double _ExitAngleInDegrees = .0d;
        double _CenterAngleOfCuttingInDegrees = .0d;
        double _TheMeanChipThicknessInMeter = .0d;
        double _CuttingForceInNewton = .0d;
        List<double> _StudiedAngles = new List<double>();
        Dictionary<double, double> _ChipThicknessAtStudiedAngles = new Dictionary<double, double>();
        double _ActiveForceInNewton = .0d;
        double _FrictionForceOnRakeInNewton = .0d;
        double _ThrustForceInNewton = .0d;
        double _ShearForceInNewton = .0d;
        double _NormalForceToShearPlaneInNewton = .0d;
        double _NormalForceToRakeInNewton = .0d;
        double _CuttingForceMomentInNewtonMeter = .0d;
        double _MaxSheftsTorque = .0d;
        double _ShearYieldStress = .0d;
        double _SpecificWorkToSurfaceSeparationInJoulPerMeter2 = .0d;
        WoodType _SelectedWood;


        private void _FillPropertiesValue()
        {


            _FeedVelocity = Convert.ToDouble(clsHelper.ReadFromConfiguration("FeedVelocity"));  // m/min
            _NumberOfBlades = Convert.ToInt32(clsHelper.ReadFromConfiguration("NumberOfBlades"));

            _MaxCuttingVelocity = clsHelper.MeterPerSecToMeterPerMin(Convert.ToDouble(clsHelper.ReadFromConfiguration("MaxCuttingVelocity"))); // m/sec
            _DepthOfCutWoodInMeter = clsHelper.MillimeterToMeter(Convert.ToDouble(clsHelper.ReadFromConfiguration("DepthOfCutWood")));  // mm
            _TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWoodInMeter = clsHelper.MillimeterToMeter(Convert.ToDouble(clsHelper.ReadFromConfiguration("TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWood"))); // mm
            _RakeAngleInDegrees = Convert.ToDouble(clsHelper.ReadFromConfiguration("RakeAngle")); // degrees
            _NumberOfTooth = Convert.ToInt32(clsHelper.ReadFromConfiguration("NumberOfTooth"));  // tooth
            _BladeDiameter = clsHelper.MillimeterToMeter(Convert.ToDouble(clsHelper.ReadFromConfiguration("BladeDiameter")));  // mm
            _KerfThicknessInMeter = clsHelper.MillimeterToMeter(Convert.ToDouble(clsHelper.ReadFromConfiguration("KerfThickness"))); // mm
        }


        private void _PerformingCalculations()
        {
            _FeedPerTeethInMeterPerTeeth = clsMainEquations.FeedPerTeeth_Unit_MeterPerTeeth(_MaxCuttingVelocity, _FeedVelocity, _BladeDiameter, _NumberOfTooth);
            _NumberOfRotationsInRPM = clsMainEquations.NumberOfRotations_Unit_RPM(_FeedVelocity, _FeedPerTeethInMeterPerTeeth, _NumberOfTooth);
            _FrictionAngleInDegrees = clsMainEquations.FrictionAngle_Unit_Degrees(_CoefficientOfFriction);
            _ShearAngleInDegrees = clsMainEquations.ShearAngle_Unit_Degrees(clsHelper.DegreesToRadians(_FrictionAngleInDegrees), clsHelper.DegreesToRadians(_RakeAngleInDegrees));
            _FrictionCorrectionCoefficient = clsMainEquations.FrictionCorrectionCoefficient_Unit_None(clsHelper.DegreesToRadians(_FrictionAngleInDegrees), clsHelper.DegreesToRadians(_ShearAngleInDegrees), clsHelper.DegreesToRadians(_RakeAngleInDegrees));
            _ShearingStrainAlongShearPlane = clsMainEquations.ShearingStrainAlongShearPlane(clsHelper.DegreesToRadians(_ShearAngleInDegrees), clsHelper.DegreesToRadians(_RakeAngleInDegrees));
            _EnterAngleInDegrees = clsMainEquations.EnterAngle_Unit_Degrees(_DepthOfCutWoodInMeter, _TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWoodInMeter, _BladeDiameter / 2);
            _ExitAngleInDegrees = clsMainEquations.ExitAngle_Unit_Degrees(_TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWoodInMeter, _BladeDiameter / 2);
            _CenterAngleOfCuttingInDegrees = clsMainEquations.CenterAngleOfCutting(_DepthOfCutWoodInMeter, _TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWoodInMeter, _BladeDiameter / 2);
            _TheMeanChipThicknessInMeter = clsMainEquations.TheMeanChipThickness_Unit_Meter(_CenterAngleOfCuttingInDegrees, _FeedPerTeethInMeterPerTeeth);
            _StudiedAngles = clsMainEquations.GetStudiedAngles(_DepthOfCutWoodInMeter, _TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWoodInMeter, _BladeDiameter / 2, _NumberOfTooth);
            _ChipThicknessAtStudiedAngles = clsMainEquations.ChipThicknessAtStudiedAngles(_StudiedAngles, _FeedPerTeethInMeterPerTeeth);
            _VolumetricProductionRateMeter3Hour = clsMainEquations.VolumetricProductionRateMeter3PerHour(clsHelper.MeterPerMinToMeterPerSec(_FeedVelocity), (0.03 * 0.2));
        }
        private void _FullAngleWithChipThicknessTable()
        {
            foreach (KeyValuePair<double, double> kvp in _ChipThicknessAtStudiedAngles)
                AddAngleWithChipThicknessRow(kvp.Key, kvp.Value);
        }
        private void _ResultToScreen()
        {

            lblFeedVelocity.Text = _FeedVelocity.ToString();
            lblMaxCuttingVelocity.Text = _MaxCuttingVelocity.ToString();
            lblCoefficientOfFriction.Text = _CoefficientOfFriction.ToString();
            lblFeedPerTeeth.Text = _FeedPerTeethInMeterPerTeeth.ToString();
            lblNumberOfRotations.Text = _NumberOfRotationsInRPM.ToString();
            lblFrictionAngle.Text = _FrictionAngleInDegrees.ToString();
            lblShearAngle.Text = _ShearAngleInDegrees.ToString();
            lblFrictionCorrectionCoefficient.Text = _FrictionCorrectionCoefficient.ToString();
            lblShearingStrainAlongShearPlane.Text = _ShearingStrainAlongShearPlane.ToString();
            lblEnterAngle.Text = _EnterAngleInDegrees.ToString();
            lblExitAngle.Text = _ExitAngleInDegrees.ToString();
            lblCenterCuttingAngle.Text = _CenterAngleOfCuttingInDegrees.ToString();
            lblTheMeanChipThickness.Text = _TheMeanChipThicknessInMeter.ToString();
            lblNumberOfTeethInvolvedInCutting.Text = (_StudiedAngles.Count - 1).ToString(); // Without Enter Angle 
            _FullAngleWithChipThicknessTable();
            lblNumberOfBlades.Text = _NumberOfBlades.ToString();
            lblVolumetricProductionRateMeter3Hour.Text = _VolumetricProductionRateMeter3Hour.ToString().Substring(0, 4);

        }


        private void _DisplayResult()
        {
            _FillPropertiesValue();
            _PerformingCalculations();
            _ResultToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _FullComboBoxWithWoodTypes();
            pnlCalculationPage.Controls.Add(pnlHeader);
            pnlCalculationPage.Controls.Add(pnlForceValues);
            pnlCalculationPage.Controls.Add(pnlBody);
            pnlCalculationPage.Visible = true;
            pnlMachinePerformence.Visible = false;
            pnlHistoryPage.Visible = false;
            pnlMaintenancePage.Visible = false;
        }

        private void btnCalculateForces_Click(object sender, EventArgs e)
        {
            if (cbWoodType.SelectedIndex != 0)
            {

                _DisplayResult();

                CalculateForces();
                lblCuttingForce.Text = $"{_CuttingForceInNewton}";
                lblActiveForce.Text = $"{_ActiveForceInNewton}";
                lblThrustForce.Text = $"{_ThrustForceInNewton}";
                lblShearForce.Text = $"{_ShearForceInNewton}";
                lblNormalForceToShearPlane.Text = $"{_NormalForceToShearPlaneInNewton}";
                lblNormalForceToRake.Text = $"{_NormalForceToRakeInNewton}";
                lblFrictionForceOnRake.Text = $"{_FrictionForceOnRakeInNewton}";
                // _PlotLinearFunction(slope: 485979, intercept: 6.3814, xMin: 0, xMax: 0.002, step: 0.000001);
                //F1zc = 485979hm + 6.3814

                double _ForceSlop = (_ShearYieldStress * 1000000 * _KerfThicknessInMeter * _ShearingStrainAlongShearPlane) / _FrictionCorrectionCoefficient;
                double _ForceIntercept = _SpecificWorkToSurfaceSeparationInJoulPerMeter2 * _KerfThicknessInMeter / _FrictionCorrectionCoefficient;


                double _MomentSlop = _ForceSlop * _NumberOfBlades * (_BladeDiameter / 2);
                double _MomentIntercept = _ForceIntercept * _NumberOfBlades * (_BladeDiameter / 2);

                lblSheftTorquAsFunction.Text = $"{_MomentSlop} hm + {_MomentIntercept}";
                lblCuttingForceAsAFunction.Text = $"{_ForceSlop} hm + {_ForceIntercept}";

                _PlotLinearCuttingForceFunction(slope: _ForceSlop, intercept: _ForceIntercept, xMin: 0, xMax: _ChipThicknessAtStudiedAngles.Values.ToList()[0], step: 0.000001);
                _PlotLinearMomentForceFunction(slope: _MomentSlop, intercept: _MomentIntercept, xMin: 0, xMax: _ChipThicknessAtStudiedAngles.Values.ToList()[0], step: 0.000001);


                _FillDataGridView();
                btnStartMachine.Enabled = true;
            }
            else
                MessageBox.Show("Select a wood type to perform calculations", "Select to confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalculateForces()
        {

            _CuttingForceInNewton = clsMainEquations.CuttingForce_Unit_Newton(_ShearYieldStress, _KerfThicknessInMeter, _ShearingStrainAlongShearPlane
                , _FrictionCorrectionCoefficient, _TheMeanChipThicknessInMeter, _SpecificWorkToSurfaceSeparationInJoulPerMeter2);

            _ActiveForceInNewton = clsMainEquations.ActiveForce_Unit_Newton(_CuttingForceInNewton);
            _ThrustForceInNewton = clsMainEquations.ThrustForce_Unit_Newton(_CuttingForceInNewton);
            _ShearForceInNewton = clsMainEquations.ShearForce_Unit_Newton(clsHelper.DegreesToRadians(_ShearAngleInDegrees), _CuttingForceInNewton);
            _NormalForceToShearPlaneInNewton = clsMainEquations.NormalForceToShearPlane_Unit_Newton(clsHelper.DegreesToRadians(_ShearAngleInDegrees), _CuttingForceInNewton);
            _NormalForceToRakeInNewton = clsMainEquations.NormalForceToRake_Unit_Newton(clsHelper.DegreesToRadians(_FrictionAngleInDegrees), _CuttingForceInNewton);
            _FrictionForceOnRakeInNewton = clsMainEquations.FrictionForceOnRake_Unit_Newton(clsHelper.DegreesToRadians(_FrictionAngleInDegrees), _CuttingForceInNewton);
        }

        private void _FillDataGridView()
        {
            if (dgvForces.Rows.Count > 0)
            {
                dgvForces.Rows.Clear();
            }

            for (int i = 0; i < _ChipThicknessAtStudiedAngles.Count; i++)
            {
                _CuttingForceInNewton = clsMainEquations.CuttingForce_Unit_Newton(_ShearYieldStress, _KerfThicknessInMeter, _ShearingStrainAlongShearPlane
                   , _FrictionCorrectionCoefficient, _ChipThicknessAtStudiedAngles.Values.ToList()[i], _SpecificWorkToSurfaceSeparationInJoulPerMeter2);
                _ActiveForceInNewton = clsMainEquations.ActiveForce_Unit_Newton(_CuttingForceInNewton);
                _ThrustForceInNewton = clsMainEquations.ThrustForce_Unit_Newton(_CuttingForceInNewton);
                _ShearForceInNewton = clsMainEquations.ShearForce_Unit_Newton(clsHelper.DegreesToRadians(_ShearAngleInDegrees), _CuttingForceInNewton);
                _NormalForceToShearPlaneInNewton = clsMainEquations.NormalForceToShearPlane_Unit_Newton(clsHelper.DegreesToRadians(_ShearAngleInDegrees), _CuttingForceInNewton);
                _NormalForceToRakeInNewton = clsMainEquations.NormalForceToRake_Unit_Newton(clsHelper.DegreesToRadians(_FrictionAngleInDegrees), _CuttingForceInNewton);
                _FrictionForceOnRakeInNewton = clsMainEquations.FrictionForceOnRake_Unit_Newton(clsHelper.DegreesToRadians(_FrictionAngleInDegrees), _CuttingForceInNewton);
                _CuttingForceMomentInNewtonMeter = clsMainEquations.MomentOfCuttingForce_Unit_NewtonMeter(_CuttingForceInNewton, _BladeDiameter / 2);
                AddForceRow(_StudiedAngles[i], _CuttingForceInNewton, _ActiveForceInNewton, _FrictionForceOnRakeInNewton, _ThrustForceInNewton, _ShearForceInNewton, _NormalForceToShearPlaneInNewton, _NormalForceToRakeInNewton, _CuttingForceMomentInNewtonMeter);
            }

            pnlForceValues.AutoSize = true;

            double _MaxTorque = dgvForces.Rows
            .Cast<DataGridViewRow>()
            .Where(r => !r.IsNewRow && r.Cells["CuttingForceMoment"].Value != null)
            .Select(r => double.TryParse(r.Cells["CuttingForceMoment"].Value.ToString(), out double v) ? v : double.MinValue)
            .Max();

            lblMaxSheftsTorque.Text = Convert.ToDouble(_MaxTorque * _NumberOfBlades).ToString();

        }


        private void _PlotLinearCuttingForceFunction(double slope, double intercept, double xMin, double xMax, double step)
        {
            List<double> hm = new List<double>();

            for (double x = xMin; x <= xMax; x += step)
                hm.Add(x);

            double[] Fc = hm.Select(x => slope * x + intercept).ToArray();

            double scale = 1e6; // m → µm
            double[] hmScaled = hm.Select(x => x * scale).ToArray();

            formsPlot1.Plot.Clear();

            var scatter = formsPlot1.Plot.Add.Scatter(hmScaled, Fc);
            scatter.MarkerSize = 3;

            formsPlot1.Plot.Title("Cutting Force vs Chip Thickness");
            formsPlot1.Plot.Axes.Title.Label.ForeColor = ScottPlot.Color.FromHex("#4E6E81");
            formsPlot1.Plot.XLabel("Chip Thickness (µm)");         
            formsPlot1.Plot.YLabel("Cutting Force per Tooth (N)");

            formsPlot1.Plot.Axes.SetLimits(
                hmScaled.Min(),
                hmScaled.Max(),
                Fc.Min(),
                Fc.Max()
            );


            scatter.LineWidth = 2;          // thicker line
            scatter.MarkerSize = 4;         // visible points

            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericAutomatic();
            formsPlot1.Plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericAutomatic();

            formsPlot1.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#F0F0F0"); // light gray
            formsPlot1.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#FFFFFF"); // white


            scatter.LegendText = "Fc = a·hm + b";
            formsPlot1.Plot.Legend.IsVisible = true;



            formsPlot1.Refresh();
        }

        private void _PlotLinearMomentForceFunction(double slope, double intercept, double xMin, double xMax, double step)
        {
            List<double> hm = new List<double>();

            for (double x = xMin; x <= xMax; x += step)
                hm.Add(x);

            double[] Mc = hm.Select(x => slope * x + intercept).ToArray();

            double scale = 1e6; // m → µm
            double[] hmScaled = hm.Select(x => x * scale).ToArray();

            formsPlot2.Plot.Clear();

            var scatter = formsPlot2.Plot.Add.Scatter(hmScaled, Mc);
            scatter.MarkerSize = 3;

            formsPlot2.Plot.Title("Sheft moment vs Chip Thickness");
            formsPlot2.Plot.Axes.Title.Label.ForeColor = ScottPlot.Color.FromHex("#4E6E81"); 
            formsPlot2.Plot.XLabel("Chip Thickness (µm)");   
            formsPlot2.Plot.YLabel("Moment per Tooth (N/m)");

            formsPlot2.Plot.Axes.SetLimits(
                hmScaled.Min(),
                hmScaled.Max(),
                Mc.Min(),
                Mc.Max()
            );


            scatter.LineWidth = 1;          // thicker line
            scatter.MarkerSize = 4;         // visible points
            scatter.Color = ScottPlot.Color.FromHex("#d30000");


            formsPlot2.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericAutomatic();
            formsPlot2.Plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericAutomatic();

            formsPlot2.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("#F0F0F0"); // light gray
            formsPlot2.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#FFFFFF"); // white


            scatter.LegendText = "Mc = a·hm + b";
            formsPlot2.Plot.Legend.IsVisible = true;



            formsPlot2.Refresh();
        }

        private void cbWoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWoodType.SelectedIndex != 0)
            {
                _SelectedWood = WoodCRUD.GetWoodByName(cbWoodType.SelectedItem!.ToString()!);

                _ShearYieldStress = _SelectedWood.ShearYieldStressInMpa;
                _SpecificWorkToSurfaceSeparationInJoulPerMeter2 = _SelectedWood.SpecificWorkToSurfaceSeparationJoulPerMeter2;
                _CoefficientOfFriction = _SelectedWood.CoefficientOfFriction;

                lblShearYieldStress.Text = _ShearYieldStress.ToString();
                lblSpecificWorkToSurfaceSeparation.Text = _SpecificWorkToSurfaceSeparationInJoulPerMeter2.ToString();
                lblCoefficientOfFriction.Text = _CoefficientOfFriction.ToString();

                btnCalculateForces.Enabled = true;

            }
            else
            {
                btnCalculateForces.Enabled = false;
                btnStartMachine.Enabled = false;
                btnStopMachine.Enabled = false;
            }

        }

    

        private void btnStartMachine_Click(object sender, EventArgs e)
        {

            timer1.Start();
            btnStartMachine.Enabled = false;
            btnStopMachine.Enabled = true;
        }



        double feedSpeed = 11.0 / 60.0; // m/s


        int TimerValueInMilleSecond = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerValueInMilleSecond += timer1.Interval;
            MachinePerformanceControl.LiveChart(feedSpeed / 60);

        }

        private void btnMachinePerformance_Click(object sender, EventArgs e)
        {
            pnlCalculationPage.Visible = false;
            pnlMachinePerformence.Visible = true;
            pnlHistoryPage.Visible = false;
            pnlMaintenancePage.Visible = false;
        }

        private void btnCalculationPage_Click(object sender, EventArgs e)
        {
            pnlCalculationPage.Visible = true;
            pnlMachinePerformence.Visible = false;
            pnlMaintenancePage.Visible = false;
            pnlHistoryPage.Visible = false;

        }
        private void _IntializeHistoryPage()
        {
            pnlHistoryPage = new Panel();
            var HistoryControl = new ucHistory();
           
            pnlHistoryPage.Name = "pnlHistoryPage";
            pnlHistoryPage.Controls.Add(HistoryControl);
            pnlHistoryPage.Dock = DockStyle.Fill;
            pnlHistoryPage.BackColor = SystemColors.Control;
            this.Controls.Add(pnlHistoryPage);
            pnlHistoryPage.BringToFront(); 

        }

        private void _IntializeMaintenancePage()
        {
            pnlMaintenancePage = new Panel();
            var MaintenanceControl = new ucMaintenance();
          
            pnlMaintenancePage.Name = "pnlMaintenancePage";
            pnlMaintenancePage.Controls.Add(MaintenanceControl);
            pnlMaintenancePage.Dock = DockStyle.Fill;
            pnlMaintenancePage.BackColor = SystemColors.Control;
            this.Controls.Add(pnlMaintenancePage);
            pnlMaintenancePage.BringToFront();

        }

        private void _IntializeMachinePerformancePage()
        {
            pnlMachinePerformence = new Panel();
            MachinePerformanceControl = new ucMachinePerformance();

            pnlMachinePerformence.Name = "pnlMachinePerformence";
            pnlMachinePerformence.Controls.Add(MachinePerformanceControl);
            pnlMachinePerformence.Dock = DockStyle.Fill;
            pnlMachinePerformence.BackColor = SystemColors.Control;
            this.Controls.Add(pnlMachinePerformence);
            pnlMachinePerformence.BringToFront();
        }

    

        private void btnStopMachine_Click(object sender, EventArgs e)
        {

            // Here the code that will log the cutting process informations
            timer1.Stop();
            btnStartMachine.Enabled = true;
            btnStopMachine.Enabled = false;
        }

        private void btnProcessHistory_Click(object sender, EventArgs e)
        {
            pnlCalculationPage.Visible = false;
            pnlMachinePerformence.Visible = false;
            pnlMaintenancePage.Visible = false;
            pnlHistoryPage.Visible = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCalculationPage.Visible = false;
            pnlMachinePerformence.Visible = false;
            pnlHistoryPage.Visible = false;
            pnlMaintenancePage.Visible = true;
        }


    }
}
