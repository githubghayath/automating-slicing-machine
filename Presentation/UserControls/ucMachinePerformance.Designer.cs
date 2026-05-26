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
            SuspendLayout();
            // 
            // formsPlot1MachinePerformance
            // 
            formsPlot1MachinePerformance.Location = new Point(128, 54);
            formsPlot1MachinePerformance.Name = "formsPlot1MachinePerformance";
            formsPlot1MachinePerformance.Size = new Size(483, 436);
            formsPlot1MachinePerformance.TabIndex = 0;
            // 
            // formsPlotProductionVolume
            // 
            formsPlotProductionVolume.Location = new Point(880, 54);
            formsPlotProductionVolume.Name = "formsPlotProductionVolume";
            formsPlotProductionVolume.Size = new Size(483, 436);
            formsPlotProductionVolume.TabIndex = 1;
            // 
            // ucMachinePerformance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(formsPlotProductionVolume);
            Controls.Add(formsPlot1MachinePerformance);
            Name = "ucMachinePerformance";
            Size = new Size(1584, 918);
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1MachinePerformance;
        private ScottPlot.WinForms.FormsPlot formsPlotProductionVolume;
    }
}
