namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblFeedVelocity = new Label();
            label5 = new Label();
            lblMaxCuttingVelocity = new Label();
            lblFeedPerTeeth = new Label();
            label4 = new Label();
            lblNumberOfRotations = new Label();
            label6 = new Label();
            lblFrictionAngle = new Label();
            label8 = new Label();
            lblShearAngle = new Label();
            label9 = new Label();
            lblFrictionCorrectionCoefficient = new Label();
            label10 = new Label();
            lblShearingStrainAlongShearPlane = new Label();
            label11 = new Label();
            lblEnterAngle = new Label();
            label12 = new Label();
            lblExitAngle = new Label();
            label14 = new Label();
            lblCenterCuttingAngle = new Label();
            label13 = new Label();
            lblTheMeanChipThickness = new Label();
            label15 = new Label();
            label7 = new Label();
            label16 = new Label();
            lblCuttingForce = new Label();
            btnCalculateForces = new Button();
            lblActiveForce = new Label();
            lblFrictionForceOnRake = new Label();
            lblNormalForceToRake = new Label();
            lblNormalForceToShearPlane = new Label();
            lblShearForce = new Label();
            lblThrustForce = new Label();
            lblNumberOfTeethInvolvedInCutting = new Label();
            label18 = new Label();
            label17 = new Label();
            label21 = new Label();
            label22 = new Label();
            lblCoefficientOfFriction = new Label();
            lblCuttingForceAsAFunction = new Label();
            label25 = new Label();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            label24 = new Label();
            pnlHeader = new Panel();
            btnEndProcess = new Button();
            label38 = new Label();
            label19 = new Label();
            label36 = new Label();
            btnStartMachine = new Button();
            btnStopMachine = new Button();
            label2 = new Label();
            pnlAnglesWithThickness = new Panel();
            label23 = new Label();
            lblSpecificWorkToSurfaceSeparation = new Label();
            lblShearYieldStress = new Label();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            lblSheftTorquAsFunction = new Label();
            label27 = new Label();
            lblMaxSheftsTorque = new Label();
            label26 = new Label();
            cbWoodType = new ComboBox();
            lblVolumetricProductionRateMeter3Hour = new Label();
            label20 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            lblNumberOfBlades = new Label();
            label28 = new Label();
            pnlSideBar = new Panel();
            btnMaintenance = new Button();
            label3 = new Label();
            pnlForceValues = new Panel();
            btnProcessHistory = new Button();
            btnMachinePerformance = new Button();
            btnCalculationPage = new Button();
            pbLogo = new PictureBox();
            pnlBody = new Panel();
            pnlRightSideBar = new Panel();
            pnlCalculationPage = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(672, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 0;
            label1.Text = "Feed Velocity [m/min]:";
            // 
            // lblFeedVelocity
            // 
            lblFeedVelocity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFeedVelocity.AutoSize = true;
            lblFeedVelocity.Font = new Font("Segoe UI", 8F);
            lblFeedVelocity.Location = new Point(812, 56);
            lblFeedVelocity.Margin = new Padding(4, 0, 4, 0);
            lblFeedVelocity.Name = "lblFeedVelocity";
            lblFeedVelocity.Size = new Size(41, 19);
            lblFeedVelocity.TabIndex = 1;
            lblFeedVelocity.Text = "[N/A]";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(655, 79);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 19);
            label5.TabIndex = 4;
            label5.Text = "Cutting Velocity [m/min]:";
            // 
            // lblMaxCuttingVelocity
            // 
            lblMaxCuttingVelocity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMaxCuttingVelocity.AutoSize = true;
            lblMaxCuttingVelocity.Font = new Font("Segoe UI", 8F);
            lblMaxCuttingVelocity.Location = new Point(812, 79);
            lblMaxCuttingVelocity.Margin = new Padding(4, 0, 4, 0);
            lblMaxCuttingVelocity.Name = "lblMaxCuttingVelocity";
            lblMaxCuttingVelocity.Size = new Size(41, 19);
            lblMaxCuttingVelocity.TabIndex = 5;
            lblMaxCuttingVelocity.Text = "[N/A]";
            // 
            // lblFeedPerTeeth
            // 
            lblFeedPerTeeth.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFeedPerTeeth.AutoSize = true;
            lblFeedPerTeeth.Font = new Font("Segoe UI", 8F);
            lblFeedPerTeeth.Location = new Point(812, 102);
            lblFeedPerTeeth.Margin = new Padding(4, 0, 4, 0);
            lblFeedPerTeeth.Name = "lblFeedPerTeeth";
            lblFeedPerTeeth.Size = new Size(41, 19);
            lblFeedPerTeeth.TabIndex = 7;
            lblFeedPerTeeth.Text = "[N/A]";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(652, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 19);
            label4.TabIndex = 6;
            label4.Text = "Feed per teeth [m/tooth]:";
            // 
            // lblNumberOfRotations
            // 
            lblNumberOfRotations.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNumberOfRotations.AutoSize = true;
            lblNumberOfRotations.Font = new Font("Segoe UI", 8F);
            lblNumberOfRotations.Location = new Point(812, 125);
            lblNumberOfRotations.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfRotations.Name = "lblNumberOfRotations";
            lblNumberOfRotations.Size = new Size(41, 19);
            lblNumberOfRotations.TabIndex = 9;
            lblNumberOfRotations.Text = "[N/A]";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.Location = new Point(638, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(178, 19);
            label6.TabIndex = 8;
            label6.Text = "Number of rotations [RPM]:";
            // 
            // lblFrictionAngle
            // 
            lblFrictionAngle.AutoSize = true;
            lblFrictionAngle.Font = new Font("Segoe UI", 8F);
            lblFrictionAngle.Location = new Point(1374, 56);
            lblFrictionAngle.Margin = new Padding(4, 0, 4, 0);
            lblFrictionAngle.Name = "lblFrictionAngle";
            lblFrictionAngle.Size = new Size(41, 19);
            lblFrictionAngle.TabIndex = 12;
            lblFrictionAngle.Text = "[N/A]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F);
            label8.Location = new Point(1276, 56);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 19);
            label8.TabIndex = 11;
            label8.Text = "Friction Angle: ";
            // 
            // lblShearAngle
            // 
            lblShearAngle.AutoSize = true;
            lblShearAngle.Font = new Font("Segoe UI", 8F);
            lblShearAngle.Location = new Point(1374, 79);
            lblShearAngle.Margin = new Padding(4, 0, 4, 0);
            lblShearAngle.Name = "lblShearAngle";
            lblShearAngle.Size = new Size(41, 19);
            lblShearAngle.TabIndex = 14;
            lblShearAngle.Text = "[N/A]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F);
            label9.Location = new Point(1287, 79);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 19);
            label9.TabIndex = 13;
            label9.Text = "Shear Angle: ";
            // 
            // lblFrictionCorrectionCoefficient
            // 
            lblFrictionCorrectionCoefficient.AutoSize = true;
            lblFrictionCorrectionCoefficient.Font = new Font("Segoe UI", 8F);
            lblFrictionCorrectionCoefficient.Location = new Point(1374, 102);
            lblFrictionCorrectionCoefficient.Margin = new Padding(4, 0, 4, 0);
            lblFrictionCorrectionCoefficient.Name = "lblFrictionCorrectionCoefficient";
            lblFrictionCorrectionCoefficient.Size = new Size(41, 19);
            lblFrictionCorrectionCoefficient.TabIndex = 16;
            lblFrictionCorrectionCoefficient.Text = "[N/A]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F);
            label10.Location = new Point(1183, 102);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(193, 19);
            label10.TabIndex = 15;
            label10.Text = "Friction Correction Coefficient:";
            // 
            // lblShearingStrainAlongShearPlane
            // 
            lblShearingStrainAlongShearPlane.AutoSize = true;
            lblShearingStrainAlongShearPlane.Font = new Font("Segoe UI", 8F);
            lblShearingStrainAlongShearPlane.Location = new Point(1374, 125);
            lblShearingStrainAlongShearPlane.Margin = new Padding(4, 0, 4, 0);
            lblShearingStrainAlongShearPlane.Name = "lblShearingStrainAlongShearPlane";
            lblShearingStrainAlongShearPlane.Size = new Size(41, 19);
            lblShearingStrainAlongShearPlane.TabIndex = 18;
            lblShearingStrainAlongShearPlane.Text = "[N/A]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8F);
            label11.Location = new Point(1157, 125);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(219, 19);
            label11.TabIndex = 17;
            label11.Text = "Shearing Strain Along Shear Plane:";
            // 
            // lblEnterAngle
            // 
            lblEnterAngle.AutoSize = true;
            lblEnterAngle.Font = new Font("Segoe UI", 8F);
            lblEnterAngle.Location = new Point(1374, 148);
            lblEnterAngle.Margin = new Padding(4, 0, 4, 0);
            lblEnterAngle.Name = "lblEnterAngle";
            lblEnterAngle.Size = new Size(41, 19);
            lblEnterAngle.TabIndex = 20;
            lblEnterAngle.Text = "[N/A]";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8F);
            label12.Location = new Point(1293, 148);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(83, 19);
            label12.TabIndex = 19;
            label12.Text = "Enter Angle:";
            // 
            // lblExitAngle
            // 
            lblExitAngle.AutoSize = true;
            lblExitAngle.Font = new Font("Segoe UI", 8F);
            lblExitAngle.Location = new Point(1374, 171);
            lblExitAngle.Margin = new Padding(4, 0, 4, 0);
            lblExitAngle.Name = "lblExitAngle";
            lblExitAngle.Size = new Size(41, 19);
            lblExitAngle.TabIndex = 22;
            lblExitAngle.Text = "[N/A]";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8F);
            label14.Location = new Point(1304, 171);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(72, 19);
            label14.TabIndex = 21;
            label14.Text = "Exit Angle:";
            // 
            // lblCenterCuttingAngle
            // 
            lblCenterCuttingAngle.AutoSize = true;
            lblCenterCuttingAngle.Font = new Font("Segoe UI", 8F);
            lblCenterCuttingAngle.Location = new Point(1374, 194);
            lblCenterCuttingAngle.Margin = new Padding(4, 0, 4, 0);
            lblCenterCuttingAngle.Name = "lblCenterCuttingAngle";
            lblCenterCuttingAngle.Size = new Size(41, 19);
            lblCenterCuttingAngle.TabIndex = 24;
            lblCenterCuttingAngle.Text = "[N/A]";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F);
            label13.Location = new Point(1234, 194);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(142, 19);
            label13.TabIndex = 23;
            label13.Text = "Center Cutting Angle:";
            // 
            // lblTheMeanChipThickness
            // 
            lblTheMeanChipThickness.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTheMeanChipThickness.AutoSize = true;
            lblTheMeanChipThickness.Font = new Font("Segoe UI", 8F);
            lblTheMeanChipThickness.Location = new Point(276, 56);
            lblTheMeanChipThickness.Margin = new Padding(4, 0, 4, 0);
            lblTheMeanChipThickness.Name = "lblTheMeanChipThickness";
            lblTheMeanChipThickness.Size = new Size(41, 19);
            lblTheMeanChipThickness.TabIndex = 26;
            lblTheMeanChipThickness.Text = "[N/A]";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8F);
            label15.Location = new Point(63, 56);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(215, 19);
            label15.TabIndex = 25;
            label15.Text = "The Mean Chip Thickness [meter]:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(172, 178);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(169, 20);
            label7.TabIndex = 27;
            label7.Text = "Shear yield stress [Mpa]:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(46, 204);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(295, 20);
            label16.TabIndex = 28;
            label16.Text = "Specific work to surface separation [J/m*2]:";
            // 
            // lblCuttingForce
            // 
            lblCuttingForce.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCuttingForce.AutoSize = true;
            lblCuttingForce.Font = new Font("Segoe UI", 8F);
            lblCuttingForce.Location = new Point(212, 79);
            lblCuttingForce.Margin = new Padding(4, 0, 4, 0);
            lblCuttingForce.Name = "lblCuttingForce";
            lblCuttingForce.Size = new Size(41, 19);
            lblCuttingForce.TabIndex = 31;
            lblCuttingForce.Text = "[N/A]";
            // 
            // btnCalculateForces
            // 
            btnCalculateForces.Location = new Point(448, 132);
            btnCalculateForces.Margin = new Padding(4, 5, 4, 5);
            btnCalculateForces.Name = "btnCalculateForces";
            btnCalculateForces.Size = new Size(151, 37);
            btnCalculateForces.TabIndex = 32;
            btnCalculateForces.Text = "Calculate Forces";
            btnCalculateForces.UseVisualStyleBackColor = true;
            btnCalculateForces.Click += btnCalculateForces_Click;
            // 
            // lblActiveForce
            // 
            lblActiveForce.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblActiveForce.AutoSize = true;
            lblActiveForce.Font = new Font("Segoe UI", 8F);
            lblActiveForce.Location = new Point(212, 102);
            lblActiveForce.Margin = new Padding(4, 0, 4, 0);
            lblActiveForce.Name = "lblActiveForce";
            lblActiveForce.Size = new Size(41, 19);
            lblActiveForce.TabIndex = 33;
            lblActiveForce.Text = "[N/A]";
            // 
            // lblFrictionForceOnRake
            // 
            lblFrictionForceOnRake.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFrictionForceOnRake.AutoSize = true;
            lblFrictionForceOnRake.Font = new Font("Segoe UI", 8F);
            lblFrictionForceOnRake.Location = new Point(212, 125);
            lblFrictionForceOnRake.Margin = new Padding(4, 0, 4, 0);
            lblFrictionForceOnRake.Name = "lblFrictionForceOnRake";
            lblFrictionForceOnRake.Size = new Size(41, 19);
            lblFrictionForceOnRake.TabIndex = 34;
            lblFrictionForceOnRake.Text = "[N/A]";
            // 
            // lblNormalForceToRake
            // 
            lblNormalForceToRake.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNormalForceToRake.AutoSize = true;
            lblNormalForceToRake.Font = new Font("Segoe UI", 8F);
            lblNormalForceToRake.Location = new Point(212, 219);
            lblNormalForceToRake.Margin = new Padding(4, 0, 4, 0);
            lblNormalForceToRake.Name = "lblNormalForceToRake";
            lblNormalForceToRake.Size = new Size(41, 19);
            lblNormalForceToRake.TabIndex = 35;
            lblNormalForceToRake.Text = "[N/A]";
            // 
            // lblNormalForceToShearPlane
            // 
            lblNormalForceToShearPlane.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNormalForceToShearPlane.AutoSize = true;
            lblNormalForceToShearPlane.Font = new Font("Segoe UI", 8F);
            lblNormalForceToShearPlane.Location = new Point(212, 194);
            lblNormalForceToShearPlane.Margin = new Padding(4, 0, 4, 0);
            lblNormalForceToShearPlane.Name = "lblNormalForceToShearPlane";
            lblNormalForceToShearPlane.Size = new Size(41, 19);
            lblNormalForceToShearPlane.TabIndex = 36;
            lblNormalForceToShearPlane.Text = "[N/A]";
            // 
            // lblShearForce
            // 
            lblShearForce.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblShearForce.AutoSize = true;
            lblShearForce.Font = new Font("Segoe UI", 8F);
            lblShearForce.Location = new Point(212, 171);
            lblShearForce.Margin = new Padding(4, 0, 4, 0);
            lblShearForce.Name = "lblShearForce";
            lblShearForce.Size = new Size(41, 19);
            lblShearForce.TabIndex = 37;
            lblShearForce.Text = "[N/A]";
            // 
            // lblThrustForce
            // 
            lblThrustForce.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblThrustForce.AutoSize = true;
            lblThrustForce.Font = new Font("Segoe UI", 8F);
            lblThrustForce.Location = new Point(212, 148);
            lblThrustForce.Margin = new Padding(4, 0, 4, 0);
            lblThrustForce.Name = "lblThrustForce";
            lblThrustForce.Size = new Size(41, 19);
            lblThrustForce.TabIndex = 38;
            lblThrustForce.Text = "[N/A]";
            // 
            // lblNumberOfTeethInvolvedInCutting
            // 
            lblNumberOfTeethInvolvedInCutting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNumberOfTeethInvolvedInCutting.AutoSize = true;
            lblNumberOfTeethInvolvedInCutting.Font = new Font("Segoe UI", 8F);
            lblNumberOfTeethInvolvedInCutting.Location = new Point(876, 194);
            lblNumberOfTeethInvolvedInCutting.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfTeethInvolvedInCutting.Name = "lblNumberOfTeethInvolvedInCutting";
            lblNumberOfTeethInvolvedInCutting.Size = new Size(41, 19);
            lblNumberOfTeethInvolvedInCutting.TabIndex = 40;
            lblNumberOfTeethInvolvedInCutting.Text = "[N/A]";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 8F);
            label18.Location = new Point(595, 194);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(285, 19);
            label18.TabIndex = 39;
            label18.Text = "Number Of Teeth Involved In Cutting [Teeth]:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(224, 92, 26);
            label17.Location = new Point(40, 21);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(261, 23);
            label17.TabIndex = 46;
            label17.Text = "Cutting force at centeral angle:";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(224, 92, 26);
            label21.Location = new Point(678, 21);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(201, 23);
            label21.TabIndex = 47;
            label21.Text = "Cutting Tool Properties:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label22.ForeColor = Color.FromArgb(224, 92, 26);
            label22.Location = new Point(1254, 21);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(186, 23);
            label22.TabIndex = 48;
            label22.Text = "Calculated Properties:";
            // 
            // lblCoefficientOfFriction
            // 
            lblCoefficientOfFriction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCoefficientOfFriction.AutoSize = true;
            lblCoefficientOfFriction.Font = new Font("Segoe UI", 9F);
            lblCoefficientOfFriction.Location = new Point(339, 230);
            lblCoefficientOfFriction.Margin = new Padding(4, 0, 4, 0);
            lblCoefficientOfFriction.Name = "lblCoefficientOfFriction";
            lblCoefficientOfFriction.Size = new Size(46, 20);
            lblCoefficientOfFriction.TabIndex = 50;
            lblCoefficientOfFriction.Text = "[N/A]";
            // 
            // lblCuttingForceAsAFunction
            // 
            lblCuttingForceAsAFunction.AutoSize = true;
            lblCuttingForceAsAFunction.Font = new Font("Segoe UI", 9F);
            lblCuttingForceAsAFunction.Location = new Point(712, 401);
            lblCuttingForceAsAFunction.Margin = new Padding(4, 0, 4, 0);
            lblCuttingForceAsAFunction.Name = "lblCuttingForceAsAFunction";
            lblCuttingForceAsAFunction.Size = new Size(46, 20);
            lblCuttingForceAsAFunction.TabIndex = 52;
            lblCuttingForceAsAFunction.Text = "[N/A]";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label25.ForeColor = Color.FromArgb(224, 92, 26);
            label25.Location = new Point(669, 401);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(51, 20);
            label25.TabIndex = 51;
            label25.Text = "Fc​(h): ";
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top;
            formsPlot1.ForeColor = Color.FromArgb(78, 110, 129);
            formsPlot1.ImeMode = ImeMode.NoControl;
            formsPlot1.Location = new Point(669, 26);
            formsPlot1.Margin = new Padding(3, 4, 3, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(444, 356);
            formsPlot1.TabIndex = 53;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F);
            label24.Location = new Point(184, 230);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(157, 20);
            label24.TabIndex = 54;
            label24.Text = "Coefficient Of Friction:";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnEndProcess);
            pnlHeader.Controls.Add(label38);
            pnlHeader.Controls.Add(label19);
            pnlHeader.Controls.Add(label36);
            pnlHeader.Controls.Add(btnStartMachine);
            pnlHeader.Controls.Add(btnStopMachine);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(formsPlot1);
            pnlHeader.Controls.Add(pnlAnglesWithThickness);
            pnlHeader.Controls.Add(label23);
            pnlHeader.Controls.Add(label24);
            pnlHeader.Controls.Add(lblSpecificWorkToSurfaceSeparation);
            pnlHeader.Controls.Add(lblShearYieldStress);
            pnlHeader.Controls.Add(lblCoefficientOfFriction);
            pnlHeader.Controls.Add(formsPlot2);
            pnlHeader.Controls.Add(lblSheftTorquAsFunction);
            pnlHeader.Controls.Add(label27);
            pnlHeader.Controls.Add(lblMaxSheftsTorque);
            pnlHeader.Controls.Add(label26);
            pnlHeader.Controls.Add(cbWoodType);
            pnlHeader.Controls.Add(lblCuttingForceAsAFunction);
            pnlHeader.Controls.Add(label25);
            pnlHeader.Controls.Add(label7);
            pnlHeader.Controls.Add(label16);
            pnlHeader.Controls.Add(btnCalculateForces);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(118, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1584, 477);
            pnlHeader.TabIndex = 56;
            // 
            // btnEndProcess
            // 
            btnEndProcess.FlatAppearance.BorderSize = 0;
            btnEndProcess.FlatStyle = FlatStyle.System;
            btnEndProcess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEndProcess.ForeColor = SystemColors.ButtonFace;
            btnEndProcess.Location = new Point(383, 75);
            btnEndProcess.Name = "btnEndProcess";
            btnEndProcess.Size = new Size(116, 31);
            btnEndProcess.TabIndex = 79;
            btnEndProcess.Text = "End Process";
            btnEndProcess.TextAlign = ContentAlignment.BottomCenter;
            btnEndProcess.UseVisualStyleBackColor = true;
            btnEndProcess.Click += btnEndProcess_Click;
            // 
            // label38
            // 
            label38.BackColor = Color.FromArgb(224, 92, 26);
            label38.Location = new Point(8, 9);
            label38.Name = "label38";
            label38.Size = new Size(13, 60);
            label38.TabIndex = 78;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(224, 92, 26);
            label19.Location = new Point(40, 456);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(241, 20);
            label19.TabIndex = 73;
            label19.Text = "Force components for each angle:";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.FromArgb(224, 92, 26);
            label36.Location = new Point(17, 9);
            label36.Name = "label36";
            label36.Size = new Size(266, 60);
            label36.TabIndex = 72;
            label36.Text = "Home Panel";
            // 
            // btnStartMachine
            // 
            btnStartMachine.FlatAppearance.BorderSize = 0;
            btnStartMachine.FlatStyle = FlatStyle.System;
            btnStartMachine.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnStartMachine.ForeColor = SystemColors.ButtonFace;
            btnStartMachine.Location = new Point(383, 38);
            btnStartMachine.Name = "btnStartMachine";
            btnStartMachine.Size = new Size(116, 31);
            btnStartMachine.TabIndex = 68;
            btnStartMachine.Text = "Start";
            btnStartMachine.TextAlign = ContentAlignment.BottomCenter;
            btnStartMachine.UseVisualStyleBackColor = true;
            btnStartMachine.Click += btnStartMachine_Click;
            // 
            // btnStopMachine
            // 
            btnStopMachine.FlatAppearance.BorderSize = 0;
            btnStopMachine.FlatStyle = FlatStyle.System;
            btnStopMachine.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnStopMachine.ForeColor = SystemColors.ButtonFace;
            btnStopMachine.Location = new Point(505, 38);
            btnStopMachine.Name = "btnStopMachine";
            btnStopMachine.Size = new Size(116, 31);
            btnStopMachine.TabIndex = 69;
            btnStopMachine.Text = "Stop";
            btnStopMachine.TextAlign = ContentAlignment.BottomCenter;
            btnStopMachine.UseVisualStyleBackColor = true;
            btnStopMachine.Click += btnStopMachine_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 92, 26);
            label2.Location = new Point(40, 268);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(288, 20);
            label2.TabIndex = 70;
            label2.Text = "The angles of teeth shared in the cutting:";
            // 
            // pnlAnglesWithThickness
            // 
            pnlAnglesWithThickness.Location = new Point(40, 290);
            pnlAnglesWithThickness.Name = "pnlAnglesWithThickness";
            pnlAnglesWithThickness.Size = new Size(576, 152);
            pnlAnglesWithThickness.TabIndex = 66;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label23.ForeColor = Color.FromArgb(224, 92, 26);
            label23.Location = new Point(46, 113);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(230, 20);
            label23.TabIndex = 61;
            label23.Text = "Choose type of wood to process:";
            // 
            // lblSpecificWorkToSurfaceSeparation
            // 
            lblSpecificWorkToSurfaceSeparation.AutoSize = true;
            lblSpecificWorkToSurfaceSeparation.Font = new Font("Segoe UI", 9F);
            lblSpecificWorkToSurfaceSeparation.Location = new Point(339, 204);
            lblSpecificWorkToSurfaceSeparation.Margin = new Padding(4, 0, 4, 0);
            lblSpecificWorkToSurfaceSeparation.Name = "lblSpecificWorkToSurfaceSeparation";
            lblSpecificWorkToSurfaceSeparation.Size = new Size(46, 20);
            lblSpecificWorkToSurfaceSeparation.TabIndex = 60;
            lblSpecificWorkToSurfaceSeparation.Text = "[N/A]";
            // 
            // lblShearYieldStress
            // 
            lblShearYieldStress.AutoSize = true;
            lblShearYieldStress.Font = new Font("Segoe UI", 9F);
            lblShearYieldStress.Location = new Point(339, 178);
            lblShearYieldStress.Margin = new Padding(4, 0, 4, 0);
            lblShearYieldStress.Name = "lblShearYieldStress";
            lblShearYieldStress.Size = new Size(46, 20);
            lblShearYieldStress.TabIndex = 59;
            lblShearYieldStress.Text = "[N/A]";
            // 
            // formsPlot2
            // 
            formsPlot2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            formsPlot2.ForeColor = Color.FromArgb(78, 110, 129);
            formsPlot2.ImeMode = ImeMode.NoControl;
            formsPlot2.Location = new Point(1125, 26);
            formsPlot2.Margin = new Padding(3, 4, 3, 4);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(444, 356);
            formsPlot2.TabIndex = 58;
            // 
            // lblSheftTorquAsFunction
            // 
            lblSheftTorquAsFunction.AutoSize = true;
            lblSheftTorquAsFunction.Font = new Font("Segoe UI", 9F);
            lblSheftTorquAsFunction.Location = new Point(1164, 401);
            lblSheftTorquAsFunction.Margin = new Padding(4, 0, 4, 0);
            lblSheftTorquAsFunction.Name = "lblSheftTorquAsFunction";
            lblSheftTorquAsFunction.Size = new Size(46, 20);
            lblSheftTorquAsFunction.TabIndex = 57;
            lblSheftTorquAsFunction.Text = "[N/A]";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label27.ForeColor = Color.FromArgb(224, 92, 26);
            label27.Location = new Point(1125, 401);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(40, 20);
            label27.TabIndex = 56;
            label27.Text = "T(h):";
            // 
            // lblMaxSheftsTorque
            // 
            lblMaxSheftsTorque.AutoSize = true;
            lblMaxSheftsTorque.Font = new Font("Segoe UI", 9F);
            lblMaxSheftsTorque.Location = new Point(1254, 430);
            lblMaxSheftsTorque.Margin = new Padding(4, 0, 4, 0);
            lblMaxSheftsTorque.Name = "lblMaxSheftsTorque";
            lblMaxSheftsTorque.Size = new Size(46, 20);
            lblMaxSheftsTorque.TabIndex = 55;
            lblMaxSheftsTorque.Text = "[N/A]";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label26.ForeColor = Color.FromArgb(224, 92, 26);
            label26.Location = new Point(1125, 429);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(143, 20);
            label26.TabIndex = 54;
            label26.Text = "sheft torque [N.m]: ";
            // 
            // cbWoodType
            // 
            cbWoodType.FormattingEnabled = true;
            cbWoodType.Items.AddRange(new object[] { "Select Wood Type" });
            cbWoodType.Location = new Point(46, 137);
            cbWoodType.Margin = new Padding(3, 4, 3, 4);
            cbWoodType.Name = "cbWoodType";
            cbWoodType.Size = new Size(390, 28);
            cbWoodType.TabIndex = 53;
            cbWoodType.SelectedIndexChanged += cbWoodType_SelectedIndexChanged;
            // 
            // lblVolumetricProductionRateMeter3Hour
            // 
            lblVolumetricProductionRateMeter3Hour.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblVolumetricProductionRateMeter3Hour.AutoSize = true;
            lblVolumetricProductionRateMeter3Hour.Font = new Font("Segoe UI", 8F);
            lblVolumetricProductionRateMeter3Hour.Location = new Point(812, 171);
            lblVolumetricProductionRateMeter3Hour.Margin = new Padding(4, 0, 4, 0);
            lblVolumetricProductionRateMeter3Hour.Name = "lblVolumetricProductionRateMeter3Hour";
            lblVolumetricProductionRateMeter3Hour.Size = new Size(41, 19);
            lblVolumetricProductionRateMeter3Hour.TabIndex = 67;
            lblVolumetricProductionRateMeter3Hour.Text = "[N/A]";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 8F);
            label20.Location = new Point(574, 171);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(242, 19);
            label20.TabIndex = 66;
            label20.Text = "Volumetric production rate [m3/hour]:";
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 8F);
            label29.Location = new Point(99, 79);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(117, 19);
            label29.TabIndex = 59;
            label29.Text = "Cutting Force [N]:";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 8F);
            label30.Location = new Point(108, 102);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(108, 19);
            label30.TabIndex = 60;
            label30.Text = "Active Force [N]:";
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 8F);
            label31.Location = new Point(44, 125);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(172, 19);
            label31.TabIndex = 61;
            label31.Text = "Friction Force On Rake [N]:";
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 8F);
            label32.Location = new Point(49, 219);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(167, 19);
            label32.TabIndex = 62;
            label32.Text = "Normal Force To Rake [N]:";
            // 
            // label33
            // 
            label33.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 8F);
            label33.Location = new Point(7, 194);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(209, 19);
            label33.TabIndex = 63;
            label33.Text = "Normal Force To Shear Plane [N]:";
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 8F);
            label34.Location = new Point(111, 171);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(105, 19);
            label34.TabIndex = 64;
            label34.Text = "Shear Force [N]:";
            // 
            // label35
            // 
            label35.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 8F);
            label35.Location = new Point(106, 148);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(110, 19);
            label35.TabIndex = 65;
            label35.Text = "Thrust Force [N]:";
            // 
            // lblNumberOfBlades
            // 
            lblNumberOfBlades.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNumberOfBlades.AutoSize = true;
            lblNumberOfBlades.Font = new Font("Segoe UI", 8F);
            lblNumberOfBlades.Location = new Point(812, 148);
            lblNumberOfBlades.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfBlades.Name = "lblNumberOfBlades";
            lblNumberOfBlades.Size = new Size(41, 19);
            lblNumberOfBlades.TabIndex = 58;
            lblNumberOfBlades.Text = "[N/A]";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 8F);
            label28.Location = new Point(691, 148);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(125, 19);
            label28.TabIndex = 58;
            label28.Text = "Number of blades: ";
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(23, 70, 62);
            pnlSideBar.Controls.Add(btnMaintenance);
            pnlSideBar.Controls.Add(label3);
            pnlSideBar.Controls.Add(pnlForceValues);
            pnlSideBar.Controls.Add(btnProcessHistory);
            pnlSideBar.Controls.Add(btnMachinePerformance);
            pnlSideBar.Controls.Add(btnCalculationPage);
            pnlSideBar.Controls.Add(pbLogo);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(118, 918);
            pnlSideBar.TabIndex = 68;
            // 
            // btnMaintenance
            // 
            btnMaintenance.Dock = DockStyle.Top;
            btnMaintenance.FlatAppearance.BorderSize = 0;
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.Font = new Font("Segoe UI", 9F);
            btnMaintenance.ForeColor = SystemColors.ButtonFace;
            btnMaintenance.Image = (Image)resources.GetObject("btnMaintenance.Image");
            btnMaintenance.Location = new Point(0, 375);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(118, 87);
            btnMaintenance.TabIndex = 72;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.TextAlign = ContentAlignment.BottomCenter;
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(7, 870);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 71;
            label3.Text = "Version: Alpha";
            // 
            // pnlForceValues
            // 
            pnlForceValues.Location = new Point(39, 483);
            pnlForceValues.Name = "pnlForceValues";
            pnlForceValues.Size = new Size(1542, 172);
            pnlForceValues.TabIndex = 70;
            // 
            // btnProcessHistory
            // 
            btnProcessHistory.Dock = DockStyle.Top;
            btnProcessHistory.FlatAppearance.BorderSize = 0;
            btnProcessHistory.FlatStyle = FlatStyle.Flat;
            btnProcessHistory.Font = new Font("Segoe UI", 9F);
            btnProcessHistory.ForeColor = SystemColors.ButtonFace;
            btnProcessHistory.Image = Presentation.Properties.Resources.history_40dp__DABC72_FILL0_wght400_GRAD0_opsz40;
            btnProcessHistory.Location = new Point(0, 288);
            btnProcessHistory.Name = "btnProcessHistory";
            btnProcessHistory.Size = new Size(118, 87);
            btnProcessHistory.TabIndex = 71;
            btnProcessHistory.Text = "History";
            btnProcessHistory.TextAlign = ContentAlignment.BottomCenter;
            btnProcessHistory.UseVisualStyleBackColor = true;
            btnProcessHistory.Click += btnProcessHistory_Click;
            // 
            // btnMachinePerformance
            // 
            btnMachinePerformance.Dock = DockStyle.Top;
            btnMachinePerformance.FlatAppearance.BorderSize = 0;
            btnMachinePerformance.FlatStyle = FlatStyle.Flat;
            btnMachinePerformance.Font = new Font("Segoe UI", 9F);
            btnMachinePerformance.ForeColor = SystemColors.ButtonFace;
            btnMachinePerformance.Image = Presentation.Properties.Resources.ssid_chart_40dp__DABC72_FILL0_wght400_GRAD0_opsz40;
            btnMachinePerformance.Location = new Point(0, 201);
            btnMachinePerformance.Name = "btnMachinePerformance";
            btnMachinePerformance.Size = new Size(118, 87);
            btnMachinePerformance.TabIndex = 68;
            btnMachinePerformance.Text = "Charts";
            btnMachinePerformance.TextAlign = ContentAlignment.BottomCenter;
            btnMachinePerformance.UseVisualStyleBackColor = true;
            btnMachinePerformance.Click += btnMachinePerformance_Click;
            // 
            // btnCalculationPage
            // 
            btnCalculationPage.Dock = DockStyle.Top;
            btnCalculationPage.FlatAppearance.BorderSize = 0;
            btnCalculationPage.FlatStyle = FlatStyle.Flat;
            btnCalculationPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculationPage.ForeColor = SystemColors.ButtonFace;
            btnCalculationPage.Image = Presentation.Properties.Resources.home_40dp__DABC72_FILL0_wght400_GRAD0_opsz40;
            btnCalculationPage.Location = new Point(0, 114);
            btnCalculationPage.Name = "btnCalculationPage";
            btnCalculationPage.Size = new Size(118, 87);
            btnCalculationPage.TabIndex = 68;
            btnCalculationPage.Text = "Home";
            btnCalculationPage.TextAlign = ContentAlignment.BottomCenter;
            btnCalculationPage.UseVisualStyleBackColor = true;
            btnCalculationPage.Click += btnCalculationPage_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImageLayout = ImageLayout.None;
            pbLogo.Dock = DockStyle.Top;
            pbLogo.Image = Presentation.Properties.Resources.result_0__3_;
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Padding = new Padding(0, 10, 0, 0);
            pbLogo.Size = new Size(118, 114);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 80;
            pbLogo.TabStop = false;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(label22);
            pnlBody.Controls.Add(lblCenterCuttingAngle);
            pnlBody.Controls.Add(lblVolumetricProductionRateMeter3Hour);
            pnlBody.Controls.Add(label13);
            pnlBody.Controls.Add(label17);
            pnlBody.Controls.Add(lblExitAngle);
            pnlBody.Controls.Add(label35);
            pnlBody.Controls.Add(label14);
            pnlBody.Controls.Add(label20);
            pnlBody.Controls.Add(lblEnterAngle);
            pnlBody.Controls.Add(lblShearForce);
            pnlBody.Controls.Add(label12);
            pnlBody.Controls.Add(lblNormalForceToShearPlane);
            pnlBody.Controls.Add(lblShearingStrainAlongShearPlane);
            pnlBody.Controls.Add(lblNumberOfRotations);
            pnlBody.Controls.Add(label11);
            pnlBody.Controls.Add(label34);
            pnlBody.Controls.Add(lblFrictionCorrectionCoefficient);
            pnlBody.Controls.Add(lblNormalForceToRake);
            pnlBody.Controls.Add(label9);
            pnlBody.Controls.Add(label21);
            pnlBody.Controls.Add(lblShearAngle);
            pnlBody.Controls.Add(label6);
            pnlBody.Controls.Add(label8);
            pnlBody.Controls.Add(lblThrustForce);
            pnlBody.Controls.Add(label10);
            pnlBody.Controls.Add(lblFeedVelocity);
            pnlBody.Controls.Add(lblFrictionAngle);
            pnlBody.Controls.Add(label33);
            pnlBody.Controls.Add(label15);
            pnlBody.Controls.Add(label1);
            pnlBody.Controls.Add(label32);
            pnlBody.Controls.Add(lblNumberOfBlades);
            pnlBody.Controls.Add(lblTheMeanChipThickness);
            pnlBody.Controls.Add(label31);
            pnlBody.Controls.Add(label18);
            pnlBody.Controls.Add(lblCuttingForce);
            pnlBody.Controls.Add(lblFrictionForceOnRake);
            pnlBody.Controls.Add(label28);
            pnlBody.Controls.Add(label30);
            pnlBody.Controls.Add(label5);
            pnlBody.Controls.Add(label29);
            pnlBody.Controls.Add(lblActiveForce);
            pnlBody.Controls.Add(lblFeedPerTeeth);
            pnlBody.Controls.Add(label4);
            pnlBody.Controls.Add(lblMaxCuttingVelocity);
            pnlBody.Controls.Add(lblNumberOfTeethInvolvedInCutting);
            pnlBody.Dock = DockStyle.Bottom;
            pnlBody.Location = new Point(118, 656);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1584, 262);
            pnlBody.TabIndex = 69;
            // 
            // pnlRightSideBar
            // 
            pnlRightSideBar.Dock = DockStyle.Right;
            pnlRightSideBar.Location = new Point(1702, 0);
            pnlRightSideBar.Name = "pnlRightSideBar";
            pnlRightSideBar.Size = new Size(33, 918);
            pnlRightSideBar.TabIndex = 68;
            // 
            // pnlCalculationPage
            // 
            pnlCalculationPage.BackColor = SystemColors.Control;
            pnlCalculationPage.Dock = DockStyle.Fill;
            pnlCalculationPage.Location = new Point(118, 0);
            pnlCalculationPage.Name = "pnlCalculationPage";
            pnlCalculationPage.Size = new Size(1584, 656);
            pnlCalculationPage.TabIndex = 68;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1735, 918);
            Controls.Add(pnlHeader);
            Controls.Add(pnlCalculationPage);
            Controls.Add(pnlBody);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlRightSideBar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFeedVelocity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxCuttingVelocity;
        private System.Windows.Forms.Label lblFeedPerTeeth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfRotations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFrictionAngle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblShearAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFrictionCorrectionCoefficient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblShearingStrainAlongShearPlane;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEnterAngle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblExitAngle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCenterCuttingAngle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTheMeanChipThickness;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCuttingForce;
        private System.Windows.Forms.Button btnCalculateForces;
        private System.Windows.Forms.Label lblActiveForce;
        private System.Windows.Forms.Label lblFrictionForceOnRake;
        private System.Windows.Forms.Label lblNormalForceToRake;
        private System.Windows.Forms.Label lblNormalForceToShearPlane;
        private System.Windows.Forms.Label lblShearForce;
        private System.Windows.Forms.Label lblThrustForce;
        private System.Windows.Forms.Label lblNumberOfTeethInvolvedInCutting;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCoefficientOfFriction;
        private System.Windows.Forms.Label lblCuttingForceAsAFunction;
        private System.Windows.Forms.Label label25;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ComboBox cbWoodType;
        private System.Windows.Forms.Label lblMaxSheftsTorque;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblNumberOfBlades;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblSheftTorquAsFunction;
        private System.Windows.Forms.Label label27;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private Label lblSpecificWorkToSurfaceSeparation;
        private Label lblShearYieldStress;
        private Label label23;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Panel pnlAnglesWithThickness;
        private Label lblVolumetricProductionRateMeter3Hour;
        private Label label20;
        private Panel pnlSideBar;
        private Panel pnlBody;
        private Panel pnlForceValues;
        private Panel pnlRightSideBar;
        private Panel pnlCalculationPage;
        private Button btnCalculationPage;
        private Button btnMachinePerformance;
        private Button btnStartMachine;
        private System.Windows.Forms.Timer timer1;
        private Button btnStopMachine;
        private Label label2;
        private Button btnProcessHistory;
        private Label label3;
        private Button btnMaintenance;
        private Label label36;
        private Label label19;
        private Label label38;
        private Button btnEndProcess;
        private PictureBox pbLogo;
    }
}

