namespace Final_Exam
{
    partial class LophocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LophocForm));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tatcaBtn = new CustomControls.RJControls.RJButton();
            this.danghocBtn = new CustomControls.RJControls.RJButton();
            this.hocthuBtn = new CustomControls.RJControls.RJButton();
            this.hocsinhGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new CustomControls.RJControls.RJButton();
            this.filterBtn = new CustomControls.RJControls.RJButton();
            this.createBtn = new CustomControls.RJControls.RJButton();
            this.settingBtn = new CustomControls.RJControls.RJButton();
            this.tatcaBtn = new CustomControls.RJControls.RJButton();
            this.danghocBtn = new CustomControls.RJControls.RJButton();
            this.hocthuBtn = new CustomControls.RJControls.RJButton();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(521, 104);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(544, 31);
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.filterBtn);
            this.panel3.Location = new System.Drawing.Point(1082, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 50);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.createBtn);
            this.panel2.Controls.Add(this.settingBtn);
            this.panel2.Location = new System.Drawing.Point(1020, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 48);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tatcaBtn);
            this.panel1.Controls.Add(this.danghocBtn);
            this.panel1.Controls.Add(this.hocthuBtn);
            this.panel1.Location = new System.Drawing.Point(17, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 53);
            this.panel1.TabIndex = 12;
            // 
            // hocsinhGridView
            // 
            this.hocsinhGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hocsinhGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hocsinhGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.hocsinhGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hocsinhGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hocsinhGridView.Location = new System.Drawing.Point(17, 180);
            this.hocsinhGridView.Name = "hocsinhGridView";
            this.hocsinhGridView.RowHeadersWidth = 51;
            this.hocsinhGridView.Size = new System.Drawing.Size(1170, 500);
            this.hocsinhGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh sách lớp học";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 12;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(3, 7);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(46, 37);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = " ";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.filterBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.filterBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filterBtn.BorderRadius = 12;
            this.filterBtn.BorderSize = 0;
            this.filterBtn.FlatAppearance.BorderSize = 0;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterBtn.Image")));
            this.filterBtn.Location = new System.Drawing.Point(55, 6);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(46, 37);
            this.filterBtn.TabIndex = 3;
            this.filterBtn.Text = " ";
            this.filterBtn.TextColor = System.Drawing.Color.White;
            this.filterBtn.UseVisualStyleBackColor = false;
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.createBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.createBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createBtn.BorderRadius = 12;
            this.createBtn.BorderSize = 0;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Image = ((System.Drawing.Image)(resources.GetObject("createBtn.Image")));
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(3, 3);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(109, 40);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "   Tạo mới";
            this.createBtn.TextColor = System.Drawing.Color.White;
            this.createBtn.UseVisualStyleBackColor = false;
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.settingBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.settingBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.settingBtn.BorderRadius = 12;
            this.settingBtn.BorderSize = 0;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingBtn.Image")));
            this.settingBtn.Location = new System.Drawing.Point(114, 3);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(50, 40);
            this.settingBtn.TabIndex = 3;
            this.settingBtn.TextColor = System.Drawing.Color.White;
            this.settingBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tatcaBtn);
            this.panel1.Controls.Add(this.danghocBtn);
            this.panel1.Controls.Add(this.hocthuBtn);
            this.panel1.Location = new System.Drawing.Point(17, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 53);
            this.panel1.TabIndex = 12;
            // 
            // tatcaBtn
            // 
            this.tatcaBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.tatcaBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.tatcaBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.tatcaBtn.BorderRadius = 0;
            this.tatcaBtn.BorderSize = 0;
            this.tatcaBtn.FlatAppearance.BorderSize = 0;
            this.tatcaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tatcaBtn.ForeColor = System.Drawing.Color.White;
            this.tatcaBtn.Location = new System.Drawing.Point(3, 7);
            this.tatcaBtn.Name = "tatcaBtn";
            this.tatcaBtn.Size = new System.Drawing.Size(114, 40);
            this.tatcaBtn.TabIndex = 5;
            this.tatcaBtn.Text = "Tất cả ";
            this.tatcaBtn.TextColor = System.Drawing.Color.White;
            this.tatcaBtn.UseVisualStyleBackColor = false;
            // 
            // danghocBtn
            // 
            this.danghocBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.danghocBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.danghocBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.danghocBtn.BorderRadius = 0;
            this.danghocBtn.BorderSize = 0;
            this.danghocBtn.FlatAppearance.BorderSize = 0;
            this.danghocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.danghocBtn.ForeColor = System.Drawing.Color.White;
            this.danghocBtn.Location = new System.Drawing.Point(118, 7);
            this.danghocBtn.Name = "danghocBtn";
            this.danghocBtn.Size = new System.Drawing.Size(114, 40);
            this.danghocBtn.TabIndex = 5;
            this.danghocBtn.Text = "Đã đóng";
            this.danghocBtn.TextColor = System.Drawing.Color.White;
            this.danghocBtn.UseVisualStyleBackColor = false;
            // 
            // hocthuBtn
            // 
            this.hocthuBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.hocthuBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.hocthuBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.hocthuBtn.BorderRadius = 0;
            this.hocthuBtn.BorderSize = 0;
            this.hocthuBtn.FlatAppearance.BorderSize = 0;
            this.hocthuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hocthuBtn.ForeColor = System.Drawing.Color.White;
            this.hocthuBtn.Location = new System.Drawing.Point(233, 7);
            this.hocthuBtn.Name = "hocthuBtn";
            this.hocthuBtn.Size = new System.Drawing.Size(114, 40);
            this.hocthuBtn.TabIndex = 5;
            this.hocthuBtn.Text = "Đang mở";
            this.hocthuBtn.TextColor = System.Drawing.Color.White;
            this.hocthuBtn.UseVisualStyleBackColor = false;
            // 
            // hocsinhGridView
            // 
            this.hocsinhGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hocsinhGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hocsinhGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.hocsinhGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hocsinhGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hocsinhGridView.Location = new System.Drawing.Point(17, 180);
            this.hocsinhGridView.Name = "hocsinhGridView";
            this.hocsinhGridView.RowHeadersWidth = 51;
            this.hocsinhGridView.Size = new System.Drawing.Size(1170, 500);
            this.hocsinhGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh sách lớp học";
            // 
            // LophocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hocsinhGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LophocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LophocForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LophocForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hocsinhGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJButton searchBtn;
        private CustomControls.RJControls.RJButton filterBtn;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton createBtn;
        private CustomControls.RJControls.RJButton settingBtn;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton tatcaBtn;
        private CustomControls.RJControls.RJButton danghocBtn;
        private CustomControls.RJControls.RJButton hocthuBtn;
        private System.Windows.Forms.DataGridView hocsinhGridView;
        private System.Windows.Forms.Label label1;
    }
}