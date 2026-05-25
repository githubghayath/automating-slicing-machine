namespace Presentation.UserControls
{
    partial class ucHistory
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
            components = new System.ComponentModel.Container();
            lblEmptyText = new Label();
            pnlHistoryTable = new Panel();
            dgvHistory = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            exportToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            panel1 = new Panel();
            label6 = new Label();
            lblTotalFees = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            lblProductionVolume = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            lblConsumedEnergy = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            pnlHistoryTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblEmptyText
            // 
            lblEmptyText.AutoSize = true;
            lblEmptyText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmptyText.Location = new Point(552, 419);
            lblEmptyText.Name = "lblEmptyText";
            lblEmptyText.Size = new Size(517, 41);
            lblEmptyText.TabIndex = 0;
            lblEmptyText.Text = "There is no operation stored before....";
            lblEmptyText.Visible = false;
            // 
            // pnlHistoryTable
            // 
            pnlHistoryTable.Controls.Add(dgvHistory);
            pnlHistoryTable.Location = new Point(19, 463);
            pnlHistoryTable.Name = "pnlHistoryTable";
            pnlHistoryTable.Size = new Size(1541, 426);
            pnlHistoryTable.TabIndex = 1;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.ContextMenuStrip = contextMenuStrip1;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(0, 0);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvHistory.Size = new Size(1541, 426);
            dgvHistory.TabIndex = 0;
            dgvHistory.CellMouseDown += dgvHistory_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { exportToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(122, 28);
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(121, 24);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 92, 26);
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(291, 60);
            label1.TabIndex = 2;
            label1.Text = "History Panel";
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(966, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(500, 428);
            formsPlot1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblTotalFees);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(342, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 133);
            panel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 88);
            label6.Name = "label6";
            label6.Size = new Size(255, 40);
            label6.TabIndex = 11;
            label6.Text = "This is the total cost based on the data\r\nrecorded over the last 10 days";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.Location = new Point(49, 43);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(85, 31);
            lblTotalFees.TabIndex = 10;
            lblTotalFees.Text = "2332.2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.paid_40dp_004E00_FILL0_wght400_GRAD0_opsz40;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(224, 92, 26);
            label2.Location = new Point(41, 10);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 5;
            label2.Text = "Total Fees";
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblProductionVolume);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(37, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 133);
            panel2.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 88);
            label8.Name = "label8";
            label8.Size = new Size(216, 40);
            label8.TabIndex = 13;
            label8.Text = "The production volume executed\r\nin the last 30 days";
            // 
            // lblProductionVolume
            // 
            lblProductionVolume.AutoSize = true;
            lblProductionVolume.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductionVolume.Location = new Point(49, 43);
            lblProductionVolume.Name = "lblProductionVolume";
            lblProductionVolume.Size = new Size(85, 31);
            lblProductionVolume.TabIndex = 12;
            lblProductionVolume.Text = "2332.2";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.done_all_40dp_004E00_FILL0_wght400_GRAD0_opsz40;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(224, 92, 26);
            label3.Location = new Point(41, 10);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 5;
            label3.Text = "Production Volume";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblConsumedEnergy);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(646, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 133);
            panel3.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 88);
            label7.Name = "label7";
            label7.Size = new Size(241, 40);
            label7.TabIndex = 12;
            label7.Text = "The amount of electricity consumed \r\nin the last 30 days";
            // 
            // lblConsumedEnergy
            // 
            lblConsumedEnergy.AutoSize = true;
            lblConsumedEnergy.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumedEnergy.Location = new Point(49, 43);
            lblConsumedEnergy.Name = "lblConsumedEnergy";
            lblConsumedEnergy.Size = new Size(85, 31);
            lblConsumedEnergy.TabIndex = 12;
            lblConsumedEnergy.Text = "2332.2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.electric_bolt_40dp_CCCCCC_FILL0_wght400_GRAD0_opsz40;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(224, 92, 26);
            label4.Location = new Point(41, 10);
            label4.Name = "label4";
            label4.Size = new Size(179, 28);
            label4.TabIndex = 5;
            label4.Text = "Consumed energy";
            // 
            // formsPlot2
            // 
            formsPlot2.BackColor = Color.Transparent;
            formsPlot2.Location = new Point(37, 319);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(816, 169);
            formsPlot2.TabIndex = 8;
            // 
            // ucHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(formsPlot2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(formsPlot1);
            Controls.Add(label1);
            Controls.Add(pnlHistoryTable);
            Controls.Add(lblEmptyText);
            Name = "ucHistory";
            Size = new Size(1584, 918);
            Load += ucHistory_Load;
            pnlHistoryTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmptyText;
        private Panel pnlHistoryTable;
        private DataGridView dgvHistory;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exportToolStripMenuItem;
        private Label label1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Panel panel1;
        private Label label2;
        private Label lblTotalFees;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Label label6;
        private Label lblConsumedEnergy;
        private PictureBox pictureBox2;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label8;
        private Label lblProductionVolume;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
    }
}
