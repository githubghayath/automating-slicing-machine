namespace Presentation.Forms
{
    partial class frmMachinePerformance
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            timer1 = new System.Windows.Forms.Timer(components);
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(51, 36);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(563, 479);
            formsPlot1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // formsPlot2
            // 
            formsPlot2.Location = new Point(772, 36);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(563, 479);
            formsPlot2.TabIndex = 1;
            // 
            // frmMachinePerformance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 626);
            Controls.Add(formsPlot2);
            Controls.Add(formsPlot1);
            Name = "frmMachinePerformance";
            Text = "frmMachinePerformance";
            Load += frmMachinePerformance_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer timer1;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
    }
}