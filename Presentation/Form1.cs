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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private DataGridView dgvForces;

        private void InitializeDataGridView()
        {
            dgvForces = new DataGridView
            {
                Dock = DockStyle.Fill,
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


            // 🔹 Dock DataGridView inside the panel
            pnlForceValues.Controls.Clear();     // optional (remove old controls)

            pnlForceValues.Controls.Add(dgvForces);
        }

        public void AddForceRow(double theta,double cuttingForce,double activeForce,double frictionForce,double thrustForce,double shearForce,double normalToShear,double normalToRake,double MomentOfCuttingForce)
        {
            dgvForces.Rows.Add(theta,cuttingForce,activeForce,frictionForce,thrustForce,shearForce,normalToShear,normalToRake, MomentOfCuttingForce);
        }



        // Cutting Environment
        private double _FeedVelocity = .0d;
        private double _MinCuttingVelocity = .0d;
        private double _MaxCuttingVelocity = .0d;
        private double _CoefficientOfFriction = .0d;
        private double _DepthOfCutWoodInMeter = .0d;
        private int _NumberOfBlades = 0;
        private double _TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWoodInMeter = .0d;


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
        List<double> _ChipThicknessAtStudiedAngles = new List<double>();
        double _ActiveForceInNewton = .0d;
        double _FrictionForceOnRakeInNewton = .0d;
        double _ThrustForceInNewton = .0d;
        double _ShearForceInNewton = .0d;
        double _NormalForceToShearPlaneInNewton = .0d;
        double _NormalForceToRakeInNewton = .0d;
        double _CuttingForceMomentInNewtonMeter = .0d;
        double _MaxSheftsTorque = .0d;


        private void _FillPropertiesValue()
        {


             _FeedVelocity = Convert.ToDouble(clsHelper.ReadFromConfiguration("FeedVelocity"));  // m/min
            _NumberOfBlades = Convert.ToInt32(clsHelper.ReadFromConfiguration("NumberOfBlades"));
            _MinCuttingVelocity = clsHelper.MeterPerSecToMeterPerMin( Convert.ToDouble(clsHelper.ReadFromConfiguration("MinCuttingVelocity"))); // m/sec
            _MaxCuttingVelocity = clsHelper.MeterPerSecToMeterPerMin(Convert.ToDouble(clsHelper.ReadFromConfiguration("MaxCuttingVelocity"))); // m/sec
             _CoefficientOfFriction = Convert.ToDouble(txtCoefficientOfFriction.Text);  // None
            _DepthOfCutWoodInMeter = clsHelper.MillimeterToMeter(Convert.ToDouble(clsHelper.ReadFromConfiguration("DepthOfCutWood")));  // mm
            _TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWoodInMeter =clsHelper.MillimeterToMeter( Convert.ToDouble(clsHelper.ReadFromConfiguration("TheDistanceBetweenTheCenterOfTheDiscAndTheLowestPointOfTheWood"))); // mm
            _RakeAngleInDegrees = Convert.ToDouble(clsHelper.ReadFromConfiguration("RakeAngle")); // degrees
            _NumberOfTooth = Convert.ToInt32(clsHelper.ReadFromConfiguration("NumberOfTooth"));  // tooth
            _BladeDiameter =clsHelper.MillimeterToMeter( Convert.ToDouble(clsHelper.ReadFromConfiguration("BladeDiameter")));  // mm
            _KerfThicknessInMeter =clsHelper.MillimeterToMeter( Convert.ToDouble(clsHelper.ReadFromConfiguration("KerfThickness"))); // mm
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
        }

        private void _ResultToScreen()
        {

            lblFeedVelocity.Text = _FeedVelocity.ToString();
            lblMinCuttingVelocity.Text = _MinCuttingVelocity.ToString();
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
            lblAnglesOfTeethInvolvedInCutting.Text = string.Join("\n", _StudiedAngles);
            lblChipThicknessAtStudiedAngles.Text = string.Join("\n", _ChipThicknessAtStudiedAngles);
            lblNumberOfBlades.Text = _NumberOfBlades.ToString();


        }


        private void _DisplayResult()
        {
            _FillPropertiesValue();
            _PerformingCalculations();
            _ResultToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Just For Test 
            txtShearYieldStress.Text = 57.155.ToString();
            txtSpecificWorkToSurfaceSeparation.Text = 1772.611.ToString();
            txtCoefficientOfFriction.Text = 0.565.ToString();


            // _DisplayResult();


            
            cbWoodType.Items.Add("Select Wood Type");
            cbWoodType.Items.Add("Native beech");
            cbWoodType.Items.Add("Bendywood");
            cbWoodType.Items.Add("DMDHEU");
            cbWoodType.Items.Add("Lignamon 783");
            cbWoodType.Items.Add("Lignamon 1185");
            cbWoodType.Items.Add("Beech16");
            cbWoodType.Items.Add("Spruce8");
            cbWoodType.Items.Add("Spruce16");
            cbWoodType.Items.Add("Beech8");
            cbWoodType.SelectedIndex = 0;
    



        }

        private void btnCalculateForces_Click(object sender, EventArgs e)
        {


            _DisplayResult();

            CalculateForces();
            lblCuttingForce.Text = $"Cutting Force [N]: {_CuttingForceInNewton}";
            lblActiveForce.Text = $"ActiveForce [N]: {_ActiveForceInNewton}";
            lblThrustForce.Text = $"Thrust Force [N]: {_ThrustForceInNewton}";
            lblShearForce.Text= $"Shear Force [N]: {_ShearForceInNewton}";
            lblNormalForceToShearPlane.Text= $"Normal Force To Shear Plane [N]: {_NormalForceToShearPlaneInNewton}";
            lblNormalForceToRake.Text= $"Normal Force To Rake [N]: {_NormalForceToRakeInNewton}";
            lblFrictionForceOnRake.Text = $"Friction Force On Rake [N]: {_FrictionForceOnRakeInNewton}";
            // _PlotLinearFunction(slope: 485979, intercept: 6.3814, xMin: 0, xMax: 0.002, step: 0.000001);
            //F1zc = 485979hm + 6.3814

            double _ForceSlop = (Convert.ToDouble(txtShearYieldStress.Text) * 1000000 * _KerfThicknessInMeter * _ShearingStrainAlongShearPlane) / _FrictionCorrectionCoefficient;
            double _ForceIntercept = Convert.ToDouble(txtSpecificWorkToSurfaceSeparation.Text) * _KerfThicknessInMeter / _FrictionCorrectionCoefficient;


            double _MomentSlop = _ForceSlop * _NumberOfBlades * (_BladeDiameter / 2);
            double _MomentIntercept = _ForceIntercept * _NumberOfBlades * (_BladeDiameter / 2);

            lblSheftTorquAsFunction.Text = $"{_MomentSlop} hm + {_MomentIntercept}";
            lblCuttingForceAsAFunction.Text = $"{_ForceSlop} hm + {_ForceIntercept}";

            _PlotLinearCuttingForceFunction(slope: _ForceSlop, intercept: _ForceIntercept, xMin: 0, xMax: _ChipThicknessAtStudiedAngles[0], step: 0.000001);
            _PlotLinearMomentForceFunction(slope: _MomentSlop, intercept: _MomentIntercept, xMin: 0, xMax: _ChipThicknessAtStudiedAngles[0], step: 0.000001);


            _FillDataGridView();
           
        }

        private void CalculateForces()
        {
            
            _CuttingForceInNewton = clsMainEquations.CuttingForce_Unit_Newton(Convert.ToDouble(txtShearYieldStress.Text), _KerfThicknessInMeter, _ShearingStrainAlongShearPlane
                , _FrictionCorrectionCoefficient, _TheMeanChipThicknessInMeter, Convert.ToDouble(txtSpecificWorkToSurfaceSeparation.Text));

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
                _CuttingForceInNewton = clsMainEquations.CuttingForce_Unit_Newton(Convert.ToDouble(txtShearYieldStress.Text), _KerfThicknessInMeter, _ShearingStrainAlongShearPlane
                   , _FrictionCorrectionCoefficient, _ChipThicknessAtStudiedAngles[i], Convert.ToDouble(txtSpecificWorkToSurfaceSeparation.Text));
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


        private void _PlotLinearCuttingForceFunction(double slope,double intercept,double xMin,double xMax,double step)
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

      
    
    }
}
