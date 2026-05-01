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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFeedVelocity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinCuttingVelocity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaxCuttingVelocity = new System.Windows.Forms.Label();
            this.lblFeedPerTeeth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfRotations = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrictionAngle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblShearAngle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFrictionCorrectionCoefficient = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblShearingStrainAlongShearPlane = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEnterAngle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblExitAngle = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCenterCuttingAngle = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTheMeanChipThickness = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtShearYieldStress = new System.Windows.Forms.TextBox();
            this.txtSpecificWorkToSurfaceSeparation = new System.Windows.Forms.TextBox();
            this.lblCuttingForce = new System.Windows.Forms.Label();
            this.btnCalculateForces = new System.Windows.Forms.Button();
            this.lblActiveForce = new System.Windows.Forms.Label();
            this.lblFrictionForceOnRake = new System.Windows.Forms.Label();
            this.lblNormalForceToRake = new System.Windows.Forms.Label();
            this.lblNormalForceToShearPlane = new System.Windows.Forms.Label();
            this.lblShearForce = new System.Windows.Forms.Label();
            this.lblThrustForce = new System.Windows.Forms.Label();
            this.lblNumberOfTeethInvolvedInCutting = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAnglesOfTeethInvolvedInCutting = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblChipThicknessAtStudiedAngles = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblCoefficientOfFriction = new System.Windows.Forms.Label();
            this.lblCuttingForceAsAFunction = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCoefficientOfFriction = new System.Windows.Forms.TextBox();
            this.pnlForceValues = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            this.lblSheftTorquAsFunction = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblMaxSheftsTorque = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbWoodType = new System.Windows.Forms.ComboBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblNumberOfBlades = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 576);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feed Velocity [m/min]:";
            // 
            // lblFeedVelocity
            // 
            this.lblFeedVelocity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFeedVelocity.AutoSize = true;
            this.lblFeedVelocity.Location = new System.Drawing.Point(774, 576);
            this.lblFeedVelocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedVelocity.Name = "lblFeedVelocity";
            this.lblFeedVelocity.Size = new System.Drawing.Size(44, 16);
            this.lblFeedVelocity.TabIndex = 1;
            this.lblFeedVelocity.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 611);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min Cutting Velocity [m/min]:";
            // 
            // lblMinCuttingVelocity
            // 
            this.lblMinCuttingVelocity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMinCuttingVelocity.AutoSize = true;
            this.lblMinCuttingVelocity.Location = new System.Drawing.Point(774, 611);
            this.lblMinCuttingVelocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinCuttingVelocity.Name = "lblMinCuttingVelocity";
            this.lblMinCuttingVelocity.Size = new System.Drawing.Size(44, 16);
            this.lblMinCuttingVelocity.TabIndex = 3;
            this.lblMinCuttingVelocity.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 650);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Cutting Velocity [m/min]:";
            // 
            // lblMaxCuttingVelocity
            // 
            this.lblMaxCuttingVelocity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMaxCuttingVelocity.AutoSize = true;
            this.lblMaxCuttingVelocity.Location = new System.Drawing.Point(774, 650);
            this.lblMaxCuttingVelocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxCuttingVelocity.Name = "lblMaxCuttingVelocity";
            this.lblMaxCuttingVelocity.Size = new System.Drawing.Size(44, 16);
            this.lblMaxCuttingVelocity.TabIndex = 5;
            this.lblMaxCuttingVelocity.Text = "label6";
            // 
            // lblFeedPerTeeth
            // 
            this.lblFeedPerTeeth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFeedPerTeeth.AutoSize = true;
            this.lblFeedPerTeeth.Location = new System.Drawing.Point(774, 683);
            this.lblFeedPerTeeth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedPerTeeth.Name = "lblFeedPerTeeth";
            this.lblFeedPerTeeth.Size = new System.Drawing.Size(44, 16);
            this.lblFeedPerTeeth.TabIndex = 7;
            this.lblFeedPerTeeth.Text = "label6";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 683);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Feed per teeth [m/tooth]:";
            // 
            // lblNumberOfRotations
            // 
            this.lblNumberOfRotations.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNumberOfRotations.AutoSize = true;
            this.lblNumberOfRotations.Location = new System.Drawing.Point(774, 716);
            this.lblNumberOfRotations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfRotations.Name = "lblNumberOfRotations";
            this.lblNumberOfRotations.Size = new System.Drawing.Size(44, 16);
            this.lblNumberOfRotations.TabIndex = 9;
            this.lblNumberOfRotations.Text = "label6";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 716);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of rotations [RPM]:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 527);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cutting Process Conditions:";
            // 
            // lblFrictionAngle
            // 
            this.lblFrictionAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrictionAngle.AutoSize = true;
            this.lblFrictionAngle.Location = new System.Drawing.Point(1175, 576);
            this.lblFrictionAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrictionAngle.Name = "lblFrictionAngle";
            this.lblFrictionAngle.Size = new System.Drawing.Size(44, 16);
            this.lblFrictionAngle.TabIndex = 12;
            this.lblFrictionAngle.Text = "label6";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1047, 576);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Friction Angle: ";
            // 
            // lblShearAngle
            // 
            this.lblShearAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShearAngle.AutoSize = true;
            this.lblShearAngle.Location = new System.Drawing.Point(1175, 611);
            this.lblShearAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShearAngle.Name = "lblShearAngle";
            this.lblShearAngle.Size = new System.Drawing.Size(44, 16);
            this.lblShearAngle.TabIndex = 14;
            this.lblShearAngle.Text = "label6";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1047, 611);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Shear Angle: ";
            // 
            // lblFrictionCorrectionCoefficient
            // 
            this.lblFrictionCorrectionCoefficient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrictionCorrectionCoefficient.AutoSize = true;
            this.lblFrictionCorrectionCoefficient.Location = new System.Drawing.Point(1266, 650);
            this.lblFrictionCorrectionCoefficient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrictionCorrectionCoefficient.Name = "lblFrictionCorrectionCoefficient";
            this.lblFrictionCorrectionCoefficient.Size = new System.Drawing.Size(44, 16);
            this.lblFrictionCorrectionCoefficient.TabIndex = 16;
            this.lblFrictionCorrectionCoefficient.Text = "label6";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1047, 650);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Friction Correction Coefficient:";
            // 
            // lblShearingStrainAlongShearPlane
            // 
            this.lblShearingStrainAlongShearPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShearingStrainAlongShearPlane.AutoSize = true;
            this.lblShearingStrainAlongShearPlane.Location = new System.Drawing.Point(1291, 683);
            this.lblShearingStrainAlongShearPlane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShearingStrainAlongShearPlane.Name = "lblShearingStrainAlongShearPlane";
            this.lblShearingStrainAlongShearPlane.Size = new System.Drawing.Size(44, 16);
            this.lblShearingStrainAlongShearPlane.TabIndex = 18;
            this.lblShearingStrainAlongShearPlane.Text = "label6";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1047, 683);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Shearing Strain Along Shear Plane:";
            // 
            // lblEnterAngle
            // 
            this.lblEnterAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnterAngle.AutoSize = true;
            this.lblEnterAngle.Location = new System.Drawing.Point(1161, 716);
            this.lblEnterAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterAngle.Name = "lblEnterAngle";
            this.lblEnterAngle.Size = new System.Drawing.Size(44, 16);
            this.lblEnterAngle.TabIndex = 20;
            this.lblEnterAngle.Text = "label6";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1047, 716);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Enter Angle:";
            // 
            // lblExitAngle
            // 
            this.lblExitAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExitAngle.AutoSize = true;
            this.lblExitAngle.Location = new System.Drawing.Point(1161, 748);
            this.lblExitAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitAngle.Name = "lblExitAngle";
            this.lblExitAngle.Size = new System.Drawing.Size(44, 16);
            this.lblExitAngle.TabIndex = 22;
            this.lblExitAngle.Text = "label6";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1047, 748);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Exit Angle:";
            // 
            // lblCenterCuttingAngle
            // 
            this.lblCenterCuttingAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCenterCuttingAngle.AutoSize = true;
            this.lblCenterCuttingAngle.Location = new System.Drawing.Point(1198, 772);
            this.lblCenterCuttingAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterCuttingAngle.Name = "lblCenterCuttingAngle";
            this.lblCenterCuttingAngle.Size = new System.Drawing.Size(44, 16);
            this.lblCenterCuttingAngle.TabIndex = 24;
            this.lblCenterCuttingAngle.Text = "label6";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1047, 772);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Center Cutting Angle:";
            // 
            // lblTheMeanChipThickness
            // 
            this.lblTheMeanChipThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTheMeanChipThickness.AutoSize = true;
            this.lblTheMeanChipThickness.Location = new System.Drawing.Point(239, 592);
            this.lblTheMeanChipThickness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheMeanChipThickness.Name = "lblTheMeanChipThickness";
            this.lblTheMeanChipThickness.Size = new System.Drawing.Size(44, 16);
            this.lblTheMeanChipThickness.TabIndex = 26;
            this.lblTheMeanChipThickness.Text = "label6";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 592);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "The Mean Chip Thickness [meter]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Shear yield stress [Mpa]:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 65);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(262, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Specific work to surface separation [J/m*2]:";
            // 
            // txtShearYieldStress
            // 
            this.txtShearYieldStress.Location = new System.Drawing.Point(313, 28);
            this.txtShearYieldStress.Margin = new System.Windows.Forms.Padding(4);
            this.txtShearYieldStress.Name = "txtShearYieldStress";
            this.txtShearYieldStress.Size = new System.Drawing.Size(180, 22);
            this.txtShearYieldStress.TabIndex = 29;
            // 
            // txtSpecificWorkToSurfaceSeparation
            // 
            this.txtSpecificWorkToSurfaceSeparation.Location = new System.Drawing.Point(313, 60);
            this.txtSpecificWorkToSurfaceSeparation.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecificWorkToSurfaceSeparation.Name = "txtSpecificWorkToSurfaceSeparation";
            this.txtSpecificWorkToSurfaceSeparation.Size = new System.Drawing.Size(180, 22);
            this.txtSpecificWorkToSurfaceSeparation.TabIndex = 30;
            // 
            // lblCuttingForce
            // 
            this.lblCuttingForce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuttingForce.AutoSize = true;
            this.lblCuttingForce.Location = new System.Drawing.Point(1545, 54);
            this.lblCuttingForce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuttingForce.Name = "lblCuttingForce";
            this.lblCuttingForce.Size = new System.Drawing.Size(109, 16);
            this.lblCuttingForce.TabIndex = 31;
            this.lblCuttingForce.Text = "Cutting Force [N]:";
            // 
            // btnCalculateForces
            // 
            this.btnCalculateForces.Location = new System.Drawing.Point(327, 131);
            this.btnCalculateForces.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateForces.Name = "btnCalculateForces";
            this.btnCalculateForces.Size = new System.Drawing.Size(155, 36);
            this.btnCalculateForces.TabIndex = 32;
            this.btnCalculateForces.Text = "Calculate Forces";
            this.btnCalculateForces.UseVisualStyleBackColor = true;
            this.btnCalculateForces.Click += new System.EventHandler(this.btnCalculateForces_Click);
            // 
            // lblActiveForce
            // 
            this.lblActiveForce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveForce.AutoSize = true;
            this.lblActiveForce.Location = new System.Drawing.Point(1548, 81);
            this.lblActiveForce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveForce.Name = "lblActiveForce";
            this.lblActiveForce.Size = new System.Drawing.Size(106, 16);
            this.lblActiveForce.TabIndex = 33;
            this.lblActiveForce.Text = "Active Force [N]:";
            // 
            // lblFrictionForceOnRake
            // 
            this.lblFrictionForceOnRake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrictionForceOnRake.AutoSize = true;
            this.lblFrictionForceOnRake.Location = new System.Drawing.Point(1486, 108);
            this.lblFrictionForceOnRake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrictionForceOnRake.Name = "lblFrictionForceOnRake";
            this.lblFrictionForceOnRake.Size = new System.Drawing.Size(168, 16);
            this.lblFrictionForceOnRake.TabIndex = 34;
            this.lblFrictionForceOnRake.Text = "Friction Force On Rake [N]:";
            // 
            // lblNormalForceToRake
            // 
            this.lblNormalForceToRake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNormalForceToRake.AutoSize = true;
            this.lblNormalForceToRake.Location = new System.Drawing.Point(1485, 216);
            this.lblNormalForceToRake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNormalForceToRake.Name = "lblNormalForceToRake";
            this.lblNormalForceToRake.Size = new System.Drawing.Size(169, 16);
            this.lblNormalForceToRake.TabIndex = 35;
            this.lblNormalForceToRake.Text = "Normal Force To Rake [N]:";
            // 
            // lblNormalForceToShearPlane
            // 
            this.lblNormalForceToShearPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNormalForceToShearPlane.AutoSize = true;
            this.lblNormalForceToShearPlane.Location = new System.Drawing.Point(1444, 189);
            this.lblNormalForceToShearPlane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNormalForceToShearPlane.Name = "lblNormalForceToShearPlane";
            this.lblNormalForceToShearPlane.Size = new System.Drawing.Size(210, 16);
            this.lblNormalForceToShearPlane.TabIndex = 36;
            this.lblNormalForceToShearPlane.Text = "Normal Force To Shear Plane [N]:";
            // 
            // lblShearForce
            // 
            this.lblShearForce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShearForce.AutoSize = true;
            this.lblShearForce.Location = new System.Drawing.Point(1549, 162);
            this.lblShearForce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShearForce.Name = "lblShearForce";
            this.lblShearForce.Size = new System.Drawing.Size(105, 16);
            this.lblShearForce.TabIndex = 37;
            this.lblShearForce.Text = "Shear Force [N]:";
            // 
            // lblThrustForce
            // 
            this.lblThrustForce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThrustForce.AutoSize = true;
            this.lblThrustForce.Location = new System.Drawing.Point(1548, 135);
            this.lblThrustForce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThrustForce.Name = "lblThrustForce";
            this.lblThrustForce.Size = new System.Drawing.Size(106, 16);
            this.lblThrustForce.TabIndex = 38;
            this.lblThrustForce.Text = "Thrust Force [N]:";
            // 
            // lblNumberOfTeethInvolvedInCutting
            // 
            this.lblNumberOfTeethInvolvedInCutting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumberOfTeethInvolvedInCutting.AutoSize = true;
            this.lblNumberOfTeethInvolvedInCutting.Location = new System.Drawing.Point(311, 627);
            this.lblNumberOfTeethInvolvedInCutting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfTeethInvolvedInCutting.Name = "lblNumberOfTeethInvolvedInCutting";
            this.lblNumberOfTeethInvolvedInCutting.Size = new System.Drawing.Size(44, 16);
            this.lblNumberOfTeethInvolvedInCutting.TabIndex = 40;
            this.lblNumberOfTeethInvolvedInCutting.Text = "label6";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 627);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(268, 16);
            this.label18.TabIndex = 39;
            this.label18.Text = "Number Of Teeth Involved In Cutting [Teeth]:";
            // 
            // lblAnglesOfTeethInvolvedInCutting
            // 
            this.lblAnglesOfTeethInvolvedInCutting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAnglesOfTeethInvolvedInCutting.AutoSize = true;
            this.lblAnglesOfTeethInvolvedInCutting.Location = new System.Drawing.Point(325, 655);
            this.lblAnglesOfTeethInvolvedInCutting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnglesOfTeethInvolvedInCutting.Name = "lblAnglesOfTeethInvolvedInCutting";
            this.lblAnglesOfTeethInvolvedInCutting.Size = new System.Drawing.Size(44, 16);
            this.lblAnglesOfTeethInvolvedInCutting.TabIndex = 42;
            this.lblAnglesOfTeethInvolvedInCutting.Text = "label6";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 655);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(280, 16);
            this.label19.TabIndex = 41;
            this.label19.Text = "Angles Of Teeth Involved In Cutting [Degrees]:";
            // 
            // lblChipThicknessAtStudiedAngles
            // 
            this.lblChipThicknessAtStudiedAngles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChipThicknessAtStudiedAngles.AutoSize = true;
            this.lblChipThicknessAtStudiedAngles.Location = new System.Drawing.Point(295, 734);
            this.lblChipThicknessAtStudiedAngles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChipThicknessAtStudiedAngles.Name = "lblChipThicknessAtStudiedAngles";
            this.lblChipThicknessAtStudiedAngles.Size = new System.Drawing.Size(44, 16);
            this.lblChipThicknessAtStudiedAngles.TabIndex = 44;
            this.lblChipThicknessAtStudiedAngles.Text = "label6";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 734);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(247, 16);
            this.label20.TabIndex = 43;
            this.label20.Text = "Chip thickness at studied Angles [Meter]:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1530, 13);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(261, 23);
            this.label17.TabIndex = 46;
            this.label17.Text = "Cutting force at centeral angle:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(564, 527);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(201, 23);
            this.label21.TabIndex = 47;
            this.label21.Text = "Cutting Tool Properties:";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1047, 527);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(186, 23);
            this.label22.TabIndex = 48;
            this.label22.Text = "Calculated Properties:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(138, 103);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 16);
            this.label23.TabIndex = 49;
            this.label23.Text = "Coefficient Of Friction:";
            // 
            // lblCoefficientOfFriction
            // 
            this.lblCoefficientOfFriction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCoefficientOfFriction.AutoSize = true;
            this.lblCoefficientOfFriction.Location = new System.Drawing.Point(171, 562);
            this.lblCoefficientOfFriction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoefficientOfFriction.Name = "lblCoefficientOfFriction";
            this.lblCoefficientOfFriction.Size = new System.Drawing.Size(134, 16);
            this.lblCoefficientOfFriction.TabIndex = 50;
            this.lblCoefficientOfFriction.Text = "Coefficient Of Friction:";
            // 
            // lblCuttingForceAsAFunction
            // 
            this.lblCuttingForceAsAFunction.AutoSize = true;
            this.lblCuttingForceAsAFunction.Location = new System.Drawing.Point(212, 274);
            this.lblCuttingForceAsAFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuttingForceAsAFunction.Name = "lblCuttingForceAsAFunction";
            this.lblCuttingForceAsAFunction.Size = new System.Drawing.Size(134, 16);
            this.lblCuttingForceAsAFunction.TabIndex = 52;
            this.lblCuttingForceAsAFunction.Text = "Coefficient Of Friction:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(31, 274);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(163, 16);
            this.label25.TabIndex = 51;
            this.label25.Text = "Cutting force as a function: ";
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formsPlot1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formsPlot1.Location = new System.Drawing.Point(626, 22);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(526, 363);
            this.formsPlot1.TabIndex = 53;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 562);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 16);
            this.label24.TabIndex = 54;
            this.label24.Text = "Coefficient Of Friction:";
            // 
            // txtCoefficientOfFriction
            // 
            this.txtCoefficientOfFriction.Location = new System.Drawing.Point(312, 98);
            this.txtCoefficientOfFriction.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoefficientOfFriction.Name = "txtCoefficientOfFriction";
            this.txtCoefficientOfFriction.Size = new System.Drawing.Size(180, 22);
            this.txtCoefficientOfFriction.TabIndex = 55;
            // 
            // pnlForceValues
            // 
            this.pnlForceValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForceValues.Location = new System.Drawing.Point(10, 401);
            this.pnlForceValues.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForceValues.Name = "pnlForceValues";
            this.pnlForceValues.Size = new System.Drawing.Size(1654, 108);
            this.pnlForceValues.TabIndex = 45;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.formsPlot2);
            this.pnlHeader.Controls.Add(this.lblSheftTorquAsFunction);
            this.pnlHeader.Controls.Add(this.label27);
            this.pnlHeader.Controls.Add(this.lblMaxSheftsTorque);
            this.pnlHeader.Controls.Add(this.label26);
            this.pnlHeader.Controls.Add(this.cbWoodType);
            this.pnlHeader.Controls.Add(this.lblCuttingForceAsAFunction);
            this.pnlHeader.Controls.Add(this.label25);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1865, 394);
            this.pnlHeader.TabIndex = 56;
            // 
            // formsPlot2
            // 
            this.formsPlot2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formsPlot2.Location = new System.Drawing.Point(1325, 22);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(503, 363);
            this.formsPlot2.TabIndex = 58;
            // 
            // lblSheftTorquAsFunction
            // 
            this.lblSheftTorquAsFunction.AutoSize = true;
            this.lblSheftTorquAsFunction.Location = new System.Drawing.Point(212, 313);
            this.lblSheftTorquAsFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSheftTorquAsFunction.Name = "lblSheftTorquAsFunction";
            this.lblSheftTorquAsFunction.Size = new System.Drawing.Size(153, 16);
            this.lblSheftTorquAsFunction.TabIndex = 57;
            this.lblSheftTorquAsFunction.Text = "Sheft torqu as a function: ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(35, 313);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(153, 16);
            this.label27.TabIndex = 56;
            this.label27.Text = "Sheft torqu as a function: ";
            // 
            // lblMaxSheftsTorque
            // 
            this.lblMaxSheftsTorque.AutoSize = true;
            this.lblMaxSheftsTorque.Location = new System.Drawing.Point(290, 357);
            this.lblMaxSheftsTorque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxSheftsTorque.Name = "lblMaxSheftsTorque";
            this.lblMaxSheftsTorque.Size = new System.Drawing.Size(163, 16);
            this.lblMaxSheftsTorque.TabIndex = 55;
            this.lblMaxSheftsTorque.Text = "Cutting force as a function: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 357);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(237, 16);
            this.label26.TabIndex = 54;
            this.label26.Text = "The shefts must rotate with torqu [N/m]: ";
            // 
            // cbWoodType
            // 
            this.cbWoodType.FormattingEnabled = true;
            this.cbWoodType.Location = new System.Drawing.Point(65, 187);
            this.cbWoodType.Name = "cbWoodType";
            this.cbWoodType.Size = new System.Drawing.Size(390, 24);
            this.cbWoodType.TabIndex = 53;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblNumberOfBlades);
            this.pnlBody.Controls.Add(this.label28);
            this.pnlBody.Controls.Add(this.label17);
            this.pnlBody.Controls.Add(this.lblCuttingForce);
            this.pnlBody.Controls.Add(this.lblActiveForce);
            this.pnlBody.Controls.Add(this.lblFrictionForceOnRake);
            this.pnlBody.Controls.Add(this.lblNormalForceToRake);
            this.pnlBody.Controls.Add(this.lblNormalForceToShearPlane);
            this.pnlBody.Controls.Add(this.lblShearForce);
            this.pnlBody.Controls.Add(this.lblThrustForce);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBody.Location = new System.Drawing.Point(0, 514);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1877, 339);
            this.pnlBody.TabIndex = 57;
            // 
            // lblNumberOfBlades
            // 
            this.lblNumberOfBlades.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNumberOfBlades.AutoSize = true;
            this.lblNumberOfBlades.Location = new System.Drawing.Point(774, 234);
            this.lblNumberOfBlades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfBlades.Name = "lblNumberOfBlades";
            this.lblNumberOfBlades.Size = new System.Drawing.Size(44, 16);
            this.lblNumberOfBlades.TabIndex = 58;
            this.lblNumberOfBlades.Text = "label6";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(567, 234);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 16);
            this.label28.TabIndex = 58;
            this.label28.Text = "Number of blades: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1877, 853);
            this.Controls.Add(this.txtCoefficientOfFriction);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.lblCoefficientOfFriction);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblChipThicknessAtStudiedAngles);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblAnglesOfTeethInvolvedInCutting);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblNumberOfTeethInvolvedInCutting);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnCalculateForces);
            this.Controls.Add(this.txtSpecificWorkToSurfaceSeparation);
            this.Controls.Add(this.txtShearYieldStress);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTheMeanChipThickness);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblCenterCuttingAngle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblExitAngle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblEnterAngle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblShearingStrainAlongShearPlane);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFrictionCorrectionCoefficient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblShearAngle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFrictionAngle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfRotations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFeedPerTeeth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaxCuttingVelocity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMinCuttingVelocity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFeedVelocity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlForceValues);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFeedVelocity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinCuttingVelocity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxCuttingVelocity;
        private System.Windows.Forms.Label lblFeedPerTeeth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfRotations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox txtShearYieldStress;
        private System.Windows.Forms.TextBox txtSpecificWorkToSurfaceSeparation;
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
        private System.Windows.Forms.Label lblAnglesOfTeethInvolvedInCutting;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblChipThicknessAtStudiedAngles;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblCoefficientOfFriction;
        private System.Windows.Forms.Label lblCuttingForceAsAFunction;
        private System.Windows.Forms.Label label25;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCoefficientOfFriction;
        private System.Windows.Forms.Panel pnlForceValues;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.ComboBox cbWoodType;
        private System.Windows.Forms.Label lblMaxSheftsTorque;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblNumberOfBlades;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblSheftTorquAsFunction;
        private System.Windows.Forms.Label label27;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
    }
}

