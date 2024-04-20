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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new CustomControls.RJControls.RJButton();
            this.filterBtn = new CustomControls.RJControls.RJButton();
            this.createBtn = new CustomControls.RJControls.RJButton();
            this.settingBtn = new CustomControls.RJControls.RJButton();
            this.tatcaBtn = new CustomControls.RJControls.RJButton();
            this.daDongBtn = new CustomControls.RJControls.RJButton();
            this.dangMoBtn = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.studentGridView = new Final_Exam.RoundedGridView();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
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
            this.searchBtn.Location = new System.Drawing.Point(1086, 95);
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
            this.filterBtn.Location = new System.Drawing.Point(1138, 94);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(46, 37);
            this.filterBtn.TabIndex = 3;
            this.filterBtn.Text = " ";
            this.filterBtn.TextColor = System.Drawing.Color.White;
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
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
            this.createBtn.Location = new System.Drawing.Point(1023, 12);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(109, 40);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "   Tạo mới";
            this.createBtn.TextColor = System.Drawing.Color.White;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
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
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
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
            this.tatcaBtn.Location = new System.Drawing.Point(17, 92);
            this.tatcaBtn.Name = "tatcaBtn";
            this.tatcaBtn.Size = new System.Drawing.Size(114, 40);
            this.tatcaBtn.TabIndex = 5;
            this.tatcaBtn.Text = "Tất cả ";
            this.tatcaBtn.TextColor = System.Drawing.Color.White;
            this.tatcaBtn.UseVisualStyleBackColor = false;
            // 
            // daDongBtn
            // 
            this.daDongBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.daDongBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.daDongBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.daDongBtn.BorderRadius = 0;
            this.daDongBtn.BorderSize = 0;
            this.daDongBtn.FlatAppearance.BorderSize = 0;
            this.daDongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daDongBtn.ForeColor = System.Drawing.Color.White;
            this.daDongBtn.Location = new System.Drawing.Point(132, 92);
            this.daDongBtn.Name = "daDongBtn";
            this.daDongBtn.Size = new System.Drawing.Size(114, 40);
            this.daDongBtn.TabIndex = 5;
            this.daDongBtn.Text = "Đã đóng";
            this.daDongBtn.TextColor = System.Drawing.Color.White;
            this.daDongBtn.UseVisualStyleBackColor = false;
            // 
            // dangMoBtn
            // 
            this.dangMoBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.dangMoBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dangMoBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dangMoBtn.BorderRadius = 0;
            this.dangMoBtn.BorderSize = 0;
            this.dangMoBtn.FlatAppearance.BorderSize = 0;
            this.dangMoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangMoBtn.ForeColor = System.Drawing.Color.White;
            this.dangMoBtn.Location = new System.Drawing.Point(247, 92);
            this.dangMoBtn.Name = "dangMoBtn";
            this.dangMoBtn.Size = new System.Drawing.Size(114, 40);
            this.dangMoBtn.TabIndex = 5;
            this.dangMoBtn.Text = "Đang mở";
            this.dangMoBtn.TextColor = System.Drawing.Color.White;
            this.dangMoBtn.UseVisualStyleBackColor = false;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.studentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.studentGridView.ColumnHeadersHeight = 50;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.name,
            this.numberPhone,
            this.Classes,
            this.dob,
            this.gender,
            this.dateCreated});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.studentGridView.EnableHeadersVisualStyles = false;
            this.studentGridView.GridColor = System.Drawing.Color.GhostWhite;
            this.studentGridView.Location = new System.Drawing.Point(17, 157);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersVisible = false;
            this.studentGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.studentGridView.RowTemplate.DividerHeight = 1;
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.Size = new System.Drawing.Size(1167, 523);
            this.studentGridView.TabIndex = 16;
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
            // LophocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.tatcaBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.daDongBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dangMoBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LophocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LophocForm";
            this.Load += new System.EventHandler(this.LophocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private CustomControls.RJControls.RJButton searchBtn;
        private CustomControls.RJControls.RJButton filterBtn;
        private CustomControls.RJControls.RJButton createBtn;
        private CustomControls.RJControls.RJButton settingBtn;
        private CustomControls.RJControls.RJButton tatcaBtn;
        private CustomControls.RJControls.RJButton daDongBtn;
        private CustomControls.RJControls.RJButton dangMoBtn;
        private System.Windows.Forms.Label label1;
        private RoundedGridView studentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
    }
}