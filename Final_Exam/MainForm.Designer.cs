namespace Final_Exam {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopbarPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hiddenBtn = new CustomControls.RJControls.RJButton();
            this.minimizeBtn = new CustomControls.RJControls.RJButton();
            this.exitBtn = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.accountBtn = new CustomControls.RJControls.RJButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.hocVienBtn = new CustomControls.RJControls.RJButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.logoutBtn = new CustomControls.RJControls.RJButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lopHocBtn = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardBtn = new CustomControls.RJControls.RJButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.khoDeBtn = new CustomControls.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.congNoBtn = new CustomControls.RJControls.RJButton();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.TopbarPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopbarPanel
            // 
            this.TopbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopbarPanel.BackColor = System.Drawing.Color.White;
            this.TopbarPanel.Controls.Add(this.flowLayoutPanel1);
            this.TopbarPanel.Controls.Add(this.label1);
            this.TopbarPanel.Controls.Add(this.menuBtn);
            this.TopbarPanel.Location = new System.Drawing.Point(0, -1);
            this.TopbarPanel.Name = "TopbarPanel";
            this.TopbarPanel.Size = new System.Drawing.Size(1201, 46);
            this.TopbarPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.hiddenBtn);
            this.flowLayoutPanel1.Controls.Add(this.minimizeBtn);
            this.flowLayoutPanel1.Controls.Add(this.exitBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1111, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(87, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // hiddenBtn
            // 
            this.hiddenBtn.BackColor = System.Drawing.Color.LightGreen;
            this.hiddenBtn.BackgroundColor = System.Drawing.Color.LightGreen;
            this.hiddenBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hiddenBtn.BorderRadius = 10;
            this.hiddenBtn.BorderSize = 0;
            this.hiddenBtn.FlatAppearance.BorderSize = 0;
            this.hiddenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiddenBtn.ForeColor = System.Drawing.Color.White;
            this.hiddenBtn.Location = new System.Drawing.Point(3, 3);
            this.hiddenBtn.Name = "hiddenBtn";
            this.hiddenBtn.Size = new System.Drawing.Size(21, 22);
            this.hiddenBtn.TabIndex = 1;
            this.hiddenBtn.TextColor = System.Drawing.Color.White;
            this.hiddenBtn.UseVisualStyleBackColor = false;
            this.hiddenBtn.Click += new System.EventHandler(this.hiddenBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Gold;
            this.minimizeBtn.BackgroundColor = System.Drawing.Color.Gold;
            this.minimizeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.minimizeBtn.BorderRadius = 10;
            this.minimizeBtn.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(30, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(21, 22);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.TextColor = System.Drawing.Color.White;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.BackgroundColor = System.Drawing.Color.Red;
            this.exitBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exitBtn.BorderRadius = 10;
            this.exitBtn.BorderSize = 0;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(57, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(21, 22);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.TextColor = System.Drawing.Color.White;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu | Sidebar";
            // 
            // menuBtn
            // 
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(14, 8);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(35, 33);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            this.menuBtn.MouseLeave += new System.EventHandler(this.menuBtn_MouseLeave);
            this.menuBtn.MouseHover += new System.EventHandler(this.menuBtn_MouseHover);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(235, 692);
            this.sidebar.MinimumSize = new System.Drawing.Size(62, 692);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(235, 692);
            this.sidebar.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel9.Controls.Add(this.accountBtn);
            this.panel9.Location = new System.Drawing.Point(0, 635);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(235, 56);
            this.panel9.TabIndex = 3;
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.accountBtn.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.accountBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.accountBtn.BorderRadius = 0;
            this.accountBtn.BorderSize = 0;
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBtn.ForeColor = System.Drawing.Color.White;
            this.accountBtn.Image = ((System.Drawing.Image)(resources.GetObject("accountBtn.Image")));
            this.accountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.Location = new System.Drawing.Point(-15, -3);
            this.accountBtn.Margin = new System.Windows.Forms.Padding(0);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.accountBtn.Size = new System.Drawing.Size(270, 64);
            this.accountBtn.TabIndex = 2;
            this.accountBtn.Text = "       Tài khoản";
            this.accountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.TextColor = System.Drawing.Color.White;
            this.accountBtn.UseVisualStyleBackColor = false;
            this.accountBtn.Click += new System.EventHandler(this.rjButton9_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.hocVienBtn);
            this.panel6.Location = new System.Drawing.Point(0, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 56);
            this.panel6.TabIndex = 3;
            // 
            // hocVienBtn
            // 
            this.hocVienBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.hocVienBtn.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.hocVienBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hocVienBtn.BorderRadius = 0;
            this.hocVienBtn.BorderSize = 0;
            this.hocVienBtn.FlatAppearance.BorderSize = 0;
            this.hocVienBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hocVienBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocVienBtn.ForeColor = System.Drawing.Color.White;
            this.hocVienBtn.Image = ((System.Drawing.Image)(resources.GetObject("hocVienBtn.Image")));
            this.hocVienBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hocVienBtn.Location = new System.Drawing.Point(-14, -6);
            this.hocVienBtn.Margin = new System.Windows.Forms.Padding(0);
            this.hocVienBtn.Name = "hocVienBtn";
            this.hocVienBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.hocVienBtn.Size = new System.Drawing.Size(270, 64);
            this.hocVienBtn.TabIndex = 2;
            this.hocVienBtn.Text = "       Học viên";
            this.hocVienBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hocVienBtn.TextColor = System.Drawing.Color.White;
            this.hocVienBtn.UseVisualStyleBackColor = false;
            this.hocVienBtn.Click += new System.EventHandler(this.hocVienBtn_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.Controls.Add(this.logoutBtn);
            this.panel8.Location = new System.Drawing.Point(0, 568);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 56);
            this.panel8.TabIndex = 3;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logoutBtn.BorderRadius = 0;
            this.logoutBtn.BorderSize = 0;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(-15, -3);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(270, 64);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "       Đăng xuất";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextColor = System.Drawing.Color.White;
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lopHocBtn);
            this.panel7.Location = new System.Drawing.Point(0, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 56);
            this.panel7.TabIndex = 3;
            // 
            // lopHocBtn
            // 
            this.lopHocBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.lopHocBtn.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.lopHocBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lopHocBtn.BorderRadius = 0;
            this.lopHocBtn.BorderSize = 0;
            this.lopHocBtn.FlatAppearance.BorderSize = 0;
            this.lopHocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lopHocBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopHocBtn.ForeColor = System.Drawing.Color.White;
            this.lopHocBtn.Image = ((System.Drawing.Image)(resources.GetObject("lopHocBtn.Image")));
            this.lopHocBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lopHocBtn.Location = new System.Drawing.Point(-14, -4);
            this.lopHocBtn.Margin = new System.Windows.Forms.Padding(0);
            this.lopHocBtn.Name = "lopHocBtn";
            this.lopHocBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.lopHocBtn.Size = new System.Drawing.Size(270, 64);
            this.lopHocBtn.TabIndex = 2;
            this.lopHocBtn.Text = "       Lớp học";
            this.lopHocBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lopHocBtn.TextColor = System.Drawing.Color.White;
            this.lopHocBtn.UseVisualStyleBackColor = false;
            this.lopHocBtn.Click += new System.EventHandler(this.lopHocBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dashboardBtn);
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 56);
            this.panel3.TabIndex = 3;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.dashboardBtn.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dashboardBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dashboardBtn.BorderRadius = 0;
            this.dashboardBtn.BorderSize = 0;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(-15, -8);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(270, 64);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Text = "       Tổng quan";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextColor = System.Drawing.Color.White;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.khoDeBtn);
            this.panel5.Location = new System.Drawing.Point(0, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 56);
            this.panel5.TabIndex = 3;
            // 
            // khoDeBtn
            // 
            this.khoDeBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.khoDeBtn.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.khoDeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.khoDeBtn.BorderRadius = 0;
            this.khoDeBtn.BorderSize = 0;
            this.khoDeBtn.FlatAppearance.BorderSize = 0;
            this.khoDeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.khoDeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoDeBtn.ForeColor = System.Drawing.Color.White;
            this.khoDeBtn.Image = ((System.Drawing.Image)(resources.GetObject("khoDeBtn.Image")));
            this.khoDeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.khoDeBtn.Location = new System.Drawing.Point(-14, -4);
            this.khoDeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.khoDeBtn.Name = "khoDeBtn";
            this.khoDeBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.khoDeBtn.Size = new System.Drawing.Size(270, 64);
            this.khoDeBtn.TabIndex = 2;
            this.khoDeBtn.Text = "       Kho đề";
            this.khoDeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.khoDeBtn.TextColor = System.Drawing.Color.White;
            this.khoDeBtn.UseVisualStyleBackColor = false;
            this.khoDeBtn.Click += new System.EventHandler(this.khoDeBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.congNoBtn);
            this.panel4.Location = new System.Drawing.Point(0, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 56);
            this.panel4.TabIndex = 3;
            // 
            // congNoBtn
            // 
            this.congNoBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.congNoBtn.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.congNoBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.congNoBtn.BorderRadius = 0;
            this.congNoBtn.BorderSize = 0;
            this.congNoBtn.FlatAppearance.BorderSize = 0;
            this.congNoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.congNoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congNoBtn.ForeColor = System.Drawing.Color.White;
            this.congNoBtn.Image = ((System.Drawing.Image)(resources.GetObject("congNoBtn.Image")));
            this.congNoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.congNoBtn.Location = new System.Drawing.Point(-14, -8);
            this.congNoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.congNoBtn.Name = "congNoBtn";
            this.congNoBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.congNoBtn.Size = new System.Drawing.Size(270, 64);
            this.congNoBtn.TabIndex = 2;
            this.congNoBtn.Text = "       Thu phí";
            this.congNoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.congNoBtn.TextColor = System.Drawing.Color.White;
            this.congNoBtn.UseVisualStyleBackColor = false;
            this.congNoBtn.Click += new System.EventHandler(this.congNoBtn_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyPanel.Location = new System.Drawing.Point(231, 45);
            this.bodyPanel.MaximumSize = new System.Drawing.Size(1137, 647);
            this.bodyPanel.MinimumSize = new System.Drawing.Size(969, 647);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bodyPanel.Size = new System.Drawing.Size(969, 647);
            this.bodyPanel.TabIndex = 2;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.TopbarPanel);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopbarPanel.ResumeLayout(false);
            this.TopbarPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopbarPanel;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton exitBtn;
        private CustomControls.RJControls.RJButton hiddenBtn;
        private CustomControls.RJControls.RJButton minimizeBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel sidebar;
        private CustomControls.RJControls.RJButton dashboardBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.RJControls.RJButton hocVienBtn;
        private System.Windows.Forms.Panel panel5;
        private CustomControls.RJControls.RJButton congNoBtn;
        private System.Windows.Forms.Panel panel6;
        private CustomControls.RJControls.RJButton khoDeBtn;
        private System.Windows.Forms.Panel panel7;
        private CustomControls.RJControls.RJButton lopHocBtn;
        private System.Windows.Forms.Panel panel8;
        private CustomControls.RJControls.RJButton logoutBtn;
        private System.Windows.Forms.Panel panel9;
        private CustomControls.RJControls.RJButton accountBtn;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Timer sideBarTimer;
    }
}