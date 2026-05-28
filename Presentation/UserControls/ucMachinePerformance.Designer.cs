namespace Presentation.UserControls
{
    partial class ucMachinePerformance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formsPlot1MachinePerformance = new ScottPlot.WinForms.FormsPlot();
            formsPlotProductionVolume = new ScottPlot.WinForms.FormsPlot();
            label36 = new Label();
            label1 = new Label();
            lblTimeCounter = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // formsPlot1MachinePerformance
            // 
            formsPlot1MachinePerformance.Location = new Point(216, 89);
            formsPlot1MachinePerformance.Name = "formsPlot1MachinePerformance";
            formsPlot1MachinePerformance.Size = new Size(432, 393);
            formsPlot1MachinePerformance.TabIndex = 0;
            // 
            // formsPlotProductionVolume
            // 
            formsPlotProductionVolume.Location = new Point(216, 511);
            formsPlotProductionVolume.Name = "formsPlotProductionVolume";
            formsPlotProductionVolume.Size = new Size(432, 393);
            formsPlotProductionVolume.TabIndex = 1;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.FromArgb(224, 92, 26);
            label36.Location = new Point(17, 9);
            label36.Name = "label36";
            label36.Size = new Size(400, 60);
            label36.TabIndex = 73;
            label36.Text = "Performance Panel";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 92, 26);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(13, 60);
            label1.TabIndex = 74;
            // 
            // lblTimeCounter
            // 
            lblTimeCounter.AutoSize = true;
            lblTimeCounter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeCounter.ForeColor = Color.FromArgb(224, 92, 26);
            lblTimeCounter.Location = new Point(1065, 114);
            lblTimeCounter.Name = "lblTimeCounter";
            lblTimeCounter.Size = new Size(80, 25);
            lblTimeCounter.TabIndex = 75;
            lblTimeCounter.Text = "00:00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 92, 26);
            label2.Location = new Point(901, 113);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 76;
            label2.Text = "Machine Runtime:";
            // 
            // ucMachinePerformance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(lblTimeCounter);
            Controls.Add(label1);
            Controls.Add(label36);
            Controls.Add(formsPlotProductionVolume);
            Controls.Add(formsPlot1MachinePerformance);
            Name = "ucMachinePerformance";
            Size = new Size(1584, 918);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1MachinePerformance;
        private ScottPlot.WinForms.FormsPlot formsPlotProductionVolume;
        private Label label36;
        private Label label1;
        private Label lblTimeCounter;
        private Label label2;
    }
}
