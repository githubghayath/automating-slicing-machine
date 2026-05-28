namespace Presentation.UserControls
{
    partial class ucMaintenance
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
            label1 = new Label();
            label38 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(554, 439);
            label1.Name = "label1";
            label1.Size = new Size(553, 41);
            label1.TabIndex = 1;
            label1.Text = "Maintenance page will avaliable soon......";
            // 
            // label38
            // 
            label38.BackColor = Color.FromArgb(224, 92, 26);
            label38.Location = new Point(8, 9);
            label38.Name = "label38";
            label38.Size = new Size(13, 60);
            label38.TabIndex = 81;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 92, 26);
            label2.Location = new Point(18, 9);
            label2.Name = "label2";
            label2.Size = new Size(406, 60);
            label2.TabIndex = 80;
            label2.Text = "Maintenance Panel";
            // 
            // ucMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label38);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucMaintenance";
            Size = new Size(1584, 918);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label38;
        private Label label2;
    }
}
