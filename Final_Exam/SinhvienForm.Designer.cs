namespace Final_Exam {
    partial class QuanLySinhVienForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySinhVienForm));
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.studentGridView = new Final_Exam.RoundedGridView();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatcaBtn = new CustomControls.RJControls.RJButton();
            this.thoihocBtn = new CustomControls.RJControls.RJButton();
            this.settingBtn = new CustomControls.RJControls.RJButton();
            this.danghocBtn = new CustomControls.RJControls.RJButton();
            this.changeStatusBtn = new CustomControls.RJControls.RJButton();
            this.createBtn = new CustomControls.RJControls.RJButton();
            this.hocthuBtn = new CustomControls.RJControls.RJButton();
            this.filterBtn = new CustomControls.RJControls.RJButton();
            this.searchBtn = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách học sinh";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(521, 104);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(544, 31);
            this.searchTextBox.TabIndex = 9;
            this.searchTextBox.Visible = false;
            // 
            // studentGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.studentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentGridView.BorderRadius = 7;
            this.studentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentGridView.ColumnHeadersHeight = 50;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.name,
            this.numberPhone,
            this.Classes,
            this.dob,
            this.gender,
            this.dateCreated});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentGridView.EnableHeadersVisualStyles = false;
            this.studentGridView.GridColor = System.Drawing.Color.GhostWhite;
            this.studentGridView.Location = new System.Drawing.Point(17, 157);
            this.studentGridView.Name = "studentGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.studentGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.studentGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.studentGridView.RowTemplate.DividerHeight = 1;
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.Size = new System.Drawing.Size(1167, 523);
            this.studentGridView.TabIndex = 10;
            this.studentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellClick);
            this.studentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellContentClick);
            this.studentGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.studentGridView_CellFormatting);
            // 
            // studentId
            // 
            this.studentId.HeaderText = "Mã học sinh";
            this.studentId.Name = "studentId";
            // 
            // name
            // 
            this.name.HeaderText = "Họ và Tên";
            this.name.Name = "name";
            // 
            // numberPhone
            // 
            this.numberPhone.HeaderText = "Số điện thoại";
            this.numberPhone.Name = "numberPhone";
            // 
            // Classes
            // 
            this.Classes.HeaderText = "Lớp học";
            this.Classes.Name = "Classes";
            // 
            // dob
            // 
            this.dob.HeaderText = "Ngày sinh";
            this.dob.Name = "dob";
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            // 
            // dateCreated
            // 
            this.dateCreated.HeaderText = "Ngày tạo";
            this.dateCreated.Name = "dateCreated";
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
            this.tatcaBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tatcaBtn.ForeColor = System.Drawing.Color.White;
            this.tatcaBtn.Location = new System.Drawing.Point(17, 95);
            this.tatcaBtn.Name = "tatcaBtn";
            this.tatcaBtn.Size = new System.Drawing.Size(114, 40);
            this.tatcaBtn.TabIndex = 5;
            this.tatcaBtn.Text = "Tất cả ";
            this.tatcaBtn.TextColor = System.Drawing.Color.White;
            this.tatcaBtn.UseVisualStyleBackColor = false;
            this.tatcaBtn.Click += new System.EventHandler(this.tatcaBtn_Click);
            // 
            // thoihocBtn
            // 
            this.thoihocBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.thoihocBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.thoihocBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.thoihocBtn.BorderRadius = 0;
            this.thoihocBtn.BorderSize = 0;
            this.thoihocBtn.FlatAppearance.BorderSize = 0;
            this.thoihocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoihocBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoihocBtn.ForeColor = System.Drawing.Color.White;
            this.thoihocBtn.Location = new System.Drawing.Point(363, 95);
            this.thoihocBtn.Name = "thoihocBtn";
            this.thoihocBtn.Size = new System.Drawing.Size(114, 40);
            this.thoihocBtn.TabIndex = 5;
            this.thoihocBtn.Text = "Thôi học";
            this.thoihocBtn.TextColor = System.Drawing.Color.White;
            this.thoihocBtn.UseVisualStyleBackColor = false;
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
            this.settingBtn.Location = new System.Drawing.Point(1134, 12);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(50, 40);
            this.settingBtn.TabIndex = 3;
            this.settingBtn.TextColor = System.Drawing.Color.White;
            this.settingBtn.UseVisualStyleBackColor = false;
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
            this.danghocBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danghocBtn.ForeColor = System.Drawing.Color.White;
            this.danghocBtn.Location = new System.Drawing.Point(132, 95);
            this.danghocBtn.Name = "danghocBtn";
            this.danghocBtn.Size = new System.Drawing.Size(114, 40);
            this.danghocBtn.TabIndex = 5;
            this.danghocBtn.Text = "Đang học";
            this.danghocBtn.TextColor = System.Drawing.Color.White;
            this.danghocBtn.UseVisualStyleBackColor = false;
            this.danghocBtn.Click += new System.EventHandler(this.danghocBtn_Click);
            // 
            // changeStatusBtn
            // 
            this.changeStatusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeStatusBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.changeStatusBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.changeStatusBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.changeStatusBtn.BorderRadius = 12;
            this.changeStatusBtn.BorderSize = 0;
            this.changeStatusBtn.FlatAppearance.BorderSize = 0;
            this.changeStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatusBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatusBtn.ForeColor = System.Drawing.Color.White;
            this.changeStatusBtn.Image = ((System.Drawing.Image)(resources.GetObject("changeStatusBtn.Image")));
            this.changeStatusBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeStatusBtn.Location = new System.Drawing.Point(904, 12);
            this.changeStatusBtn.Name = "changeStatusBtn";
            this.changeStatusBtn.Size = new System.Drawing.Size(109, 40);
            this.changeStatusBtn.TabIndex = 3;
            this.changeStatusBtn.Text = "      Thôi học";
            this.changeStatusBtn.TextColor = System.Drawing.Color.White;
            this.changeStatusBtn.UseVisualStyleBackColor = false;
            this.changeStatusBtn.Visible = false;
            this.changeStatusBtn.Click += new System.EventHandler(this.createBtn_Click);
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
            this.createBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Image = ((System.Drawing.Image)(resources.GetObject("createBtn.Image")));
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(1019, 12);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(109, 40);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "   Tạo mới";
            this.createBtn.TextColor = System.Drawing.Color.White;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
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
            this.hocthuBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocthuBtn.ForeColor = System.Drawing.Color.White;
            this.hocthuBtn.Location = new System.Drawing.Point(247, 95);
            this.hocthuBtn.Name = "hocthuBtn";
            this.hocthuBtn.Size = new System.Drawing.Size(114, 40);
            this.hocthuBtn.TabIndex = 5;
            this.hocthuBtn.Text = "Học thử";
            this.hocthuBtn.TextColor = System.Drawing.Color.White;
            this.hocthuBtn.UseVisualStyleBackColor = false;
            this.hocthuBtn.Click += new System.EventHandler(this.hocthuBtn_Click);
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
            this.filterBtn.Location = new System.Drawing.Point(1138, 98);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(46, 37);
            this.filterBtn.TabIndex = 3;
            this.filterBtn.Text = " ";
            this.filterBtn.TextColor = System.Drawing.Color.White;
            this.filterBtn.UseVisualStyleBackColor = false;
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
            this.searchBtn.Location = new System.Drawing.Point(1082, 98);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(46, 37);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = " ";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // QuanLySinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.tatcaBtn);
            this.Controls.Add(this.thoihocBtn);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.danghocBtn);
            this.Controls.Add(this.changeStatusBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.hocthuBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLySinhVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.QuanLySinhVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton settingBtn;
        private CustomControls.RJControls.RJButton searchBtn;
        private CustomControls.RJControls.RJButton createBtn;
        private CustomControls.RJControls.RJButton thoihocBtn;
        private CustomControls.RJControls.RJButton hocthuBtn;
        private CustomControls.RJControls.RJButton danghocBtn;
        private CustomControls.RJControls.RJButton tatcaBtn;
        private CustomControls.RJControls.RJButton filterBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private RoundedGridView studentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
        private CustomControls.RJControls.RJButton changeStatusBtn;
    }
}