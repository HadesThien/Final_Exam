namespace Final_Exam {
    partial class DashboardForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.registeredStudentPanel = new System.Windows.Forms.Panel();
            this.revenuePanel = new System.Windows.Forms.Panel();
            this.debtPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.containerViewPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.containerViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.AutoSize = true;
            this.dashboardLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardLabel.Location = new System.Drawing.Point(0, 0);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(138, 29);
            this.dashboardLabel.TabIndex = 16;
            this.dashboardLabel.Text = "Tổng quan";
            // 
            // registeredStudentPanel
            // 
            this.registeredStudentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registeredStudentPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registeredStudentPanel.Location = new System.Drawing.Point(28, 13);
            this.registeredStudentPanel.Margin = new System.Windows.Forms.Padding(18, 3, 16, 3);
            this.registeredStudentPanel.Name = "registeredStudentPanel";
            this.registeredStudentPanel.Size = new System.Drawing.Size(345, 127);
            this.registeredStudentPanel.TabIndex = 17;
            // 
            // revenuePanel
            // 
            this.revenuePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.revenuePanel.BackColor = System.Drawing.Color.Tomato;
            this.revenuePanel.Location = new System.Drawing.Point(407, 13);
            this.revenuePanel.Margin = new System.Windows.Forms.Padding(18, 3, 16, 3);
            this.revenuePanel.Name = "revenuePanel";
            this.revenuePanel.Size = new System.Drawing.Size(345, 127);
            this.revenuePanel.TabIndex = 18;
            // 
            // debtPanel
            // 
            this.debtPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.debtPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.debtPanel.Location = new System.Drawing.Point(786, 13);
            this.debtPanel.Margin = new System.Windows.Forms.Padding(18, 3, 16, 3);
            this.debtPanel.Name = "debtPanel";
            this.debtPanel.Size = new System.Drawing.Size(345, 127);
            this.debtPanel.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1000, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 212);
            this.panel1.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Controls.Add(this.registeredStudentPanel);
            this.flowLayoutPanel1.Controls.Add(this.revenuePanel);
            this.flowLayoutPanel1.Controls.Add(this.debtPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 162);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(3, 249);
            this.panel2.MaximumSize = new System.Drawing.Size(1000, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 212);
            this.panel2.TabIndex = 20;
            // 
            // containerViewPanel
            // 
            this.containerViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerViewPanel.Controls.Add(this.panel1);
            this.containerViewPanel.Controls.Add(this.panel2);
            this.containerViewPanel.Location = new System.Drawing.Point(407, 215);
            this.containerViewPanel.Name = "containerViewPanel";
            this.containerViewPanel.Size = new System.Drawing.Size(724, 464);
            this.containerViewPanel.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(28, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 461);
            this.panel3.TabIndex = 23;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.containerViewPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dashboardLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.containerViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Panel registeredStudentPanel;
        private System.Windows.Forms.Panel revenuePanel;
        private System.Windows.Forms.Panel debtPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel containerViewPanel;
        private System.Windows.Forms.Panel panel3;
    }
}