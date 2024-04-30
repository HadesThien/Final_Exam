namespace Final_Exam {
    partial class CongNoForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongNoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new CustomControls.RJControls.RJButton();
            this.filterBtn = new CustomControls.RJControls.RJButton();
            this.createBtn = new CustomControls.RJControls.RJButton();
            this.settingBtn = new CustomControls.RJControls.RJButton();
            this.tatcaBtn = new CustomControls.RJControls.RJButton();
            this.registeredBtn = new CustomControls.RJControls.RJButton();
            this.paidBtn = new CustomControls.RJControls.RJButton();
            this.congNoLabel = new System.Windows.Forms.Label();
            this.studentGridView = new Final_Exam.RoundedGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoaBtn = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(514, 97);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(544, 35);
            this.searchTextBox.TabIndex = 21;
            this.searchTextBox.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.searchBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
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
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.filterBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.filterBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filterBtn.BorderRadius = 12;
            this.filterBtn.BorderSize = 0;
            this.filterBtn.FlatAppearance.BorderSize = 0;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterBtn.Image")));
            this.filterBtn.Location = new System.Drawing.Point(1138, 95);
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
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.createBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.createBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createBtn.BorderRadius = 12;
            this.createBtn.BorderSize = 0;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Image = ((System.Drawing.Image)(resources.GetObject("createBtn.Image")));
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(988, 12);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(144, 40);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "   Tạo công nợ";
            this.createBtn.TextColor = System.Drawing.Color.White;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.settingBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
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
            this.tatcaBtn.Location = new System.Drawing.Point(17, 92);
            this.tatcaBtn.Name = "tatcaBtn";
            this.tatcaBtn.Size = new System.Drawing.Size(114, 40);
            this.tatcaBtn.TabIndex = 5;
            this.tatcaBtn.Text = "Tất cả ";
            this.tatcaBtn.TextColor = System.Drawing.Color.White;
            this.tatcaBtn.UseVisualStyleBackColor = false;
            this.tatcaBtn.Click += new System.EventHandler(this.tatcaBtn_Click);
            // 
            // registeredBtn
            // 
            this.registeredBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.registeredBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.registeredBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.registeredBtn.BorderRadius = 0;
            this.registeredBtn.BorderSize = 0;
            this.registeredBtn.FlatAppearance.BorderSize = 0;
            this.registeredBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registeredBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredBtn.ForeColor = System.Drawing.Color.White;
            this.registeredBtn.Location = new System.Drawing.Point(132, 92);
            this.registeredBtn.Name = "registeredBtn";
            this.registeredBtn.Size = new System.Drawing.Size(114, 40);
            this.registeredBtn.TabIndex = 5;
            this.registeredBtn.Text = "Đăng ký";
            this.registeredBtn.TextColor = System.Drawing.Color.White;
            this.registeredBtn.UseVisualStyleBackColor = false;
            this.registeredBtn.Click += new System.EventHandler(this.registeredBtn_Click);
            // 
            // paidBtn
            // 
            this.paidBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.paidBtn.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.paidBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.paidBtn.BorderRadius = 0;
            this.paidBtn.BorderSize = 0;
            this.paidBtn.FlatAppearance.BorderSize = 0;
            this.paidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paidBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidBtn.ForeColor = System.Drawing.Color.White;
            this.paidBtn.Location = new System.Drawing.Point(247, 92);
            this.paidBtn.Name = "paidBtn";
            this.paidBtn.Size = new System.Drawing.Size(122, 40);
            this.paidBtn.TabIndex = 5;
            this.paidBtn.Text = "Đã thanh toán";
            this.paidBtn.TextColor = System.Drawing.Color.White;
            this.paidBtn.UseVisualStyleBackColor = false;
            this.paidBtn.Click += new System.EventHandler(this.paidBtn_Click);
            // 
            // congNoLabel
            // 
            this.congNoLabel.AutoSize = true;
            this.congNoLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.congNoLabel.Location = new System.Drawing.Point(12, 12);
            this.congNoLabel.Name = "congNoLabel";
            this.congNoLabel.Size = new System.Drawing.Size(262, 40);
            this.congNoLabel.TabIndex = 16;
            this.congNoLabel.Text = "Danh sách thu phí";
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
            this.Id,
            this.name,
            this.Classes,
            this.price,
            this.status,
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
            this.studentGridView.RowHeadersVisible = false;
            this.studentGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.studentGridView.RowTemplate.DividerHeight = 1;
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.Size = new System.Drawing.Size(1167, 523);
            this.studentGridView.TabIndex = 22;
            this.studentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.Frozen = true;
            this.Id.HeaderText = "Mã đăng ký";
            this.Id.Name = "Id";
            this.Id.Width = 167;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.Frozen = true;
            this.name.HeaderText = "Tên học viên";
            this.name.Name = "name";
            this.name.Width = 166;
            // 
            // Classes
            // 
            this.Classes.HeaderText = "Lớp học";
            this.Classes.Name = "Classes";
            // 
            // price
            // 
            this.price.HeaderText = "Tổng tiền";
            this.price.Name = "price";
            // 
            // status
            // 
            this.status.HeaderText = "Tình trạng";
            this.status.Name = "status";
            // 
            // dateCreated
            // 
            this.dateCreated.HeaderText = "Ngày tạo";
            this.dateCreated.Name = "dateCreated";
            // 
            // xoaBtn
            // 
            this.xoaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xoaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.xoaBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
            this.xoaBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.xoaBtn.BorderRadius = 12;
            this.xoaBtn.BorderSize = 0;
            this.xoaBtn.FlatAppearance.BorderSize = 0;
            this.xoaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoaBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.ForeColor = System.Drawing.Color.White;
            this.xoaBtn.Image = ((System.Drawing.Image)(resources.GetObject("xoaBtn.Image")));
            this.xoaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoaBtn.Location = new System.Drawing.Point(838, 11);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(144, 40);
            this.xoaBtn.TabIndex = 3;
            this.xoaBtn.Text = "    Xóa công nợ";
            this.xoaBtn.TextColor = System.Drawing.Color.White;
            this.xoaBtn.UseVisualStyleBackColor = false;
            this.xoaBtn.Visible = false;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // CongNoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.tatcaBtn);
            this.Controls.Add(this.registeredBtn);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.paidBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.congNoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CongNoForm";
            this.Text = "CongNoForm";
            this.Load += new System.EventHandler(this.CongNoForm_Load);
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
        private CustomControls.RJControls.RJButton registeredBtn;
        private CustomControls.RJControls.RJButton paidBtn;
        private System.Windows.Forms.Label congNoLabel;
        private RoundedGridView studentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
        private CustomControls.RJControls.RJButton xoaBtn;
    }
}