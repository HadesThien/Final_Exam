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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LophocForm));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classGridView = new Final_Exam.RoundedGridView();
            this.updateBtn = new CustomControls.RJControls.RJButton();
            this.createBtn = new CustomControls.RJControls.RJButton();
            this.searchBtn = new CustomControls.RJControls.RJButton();
            this.tatcaBtn = new CustomControls.RJControls.RJButton();
            this.daDongBtn = new CustomControls.RJControls.RJButton();
            this.dangMoBtn = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(397, 101);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(724, 31);
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.Visible = false;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh sách lớp học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // classGridView
            // 
            this.classGridView.AllowUserToAddRows = false;
            this.classGridView.AllowUserToDeleteRows = false;
            this.classGridView.AllowUserToResizeColumns = false;
            this.classGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.classGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.classGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.classGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.classGridView.BorderRadius = 7;
            this.classGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.classGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.classGridView.ColumnHeadersHeight = 50;
            this.classGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.classGridView.EnableHeadersVisualStyles = false;
            this.classGridView.GridColor = System.Drawing.Color.GhostWhite;
            this.classGridView.Location = new System.Drawing.Point(17, 151);
            this.classGridView.MultiSelect = false;
            this.classGridView.Name = "classGridView";
            this.classGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.classGridView.RowHeadersVisible = false;
            this.classGridView.RowHeadersWidth = 51;
            this.classGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.classGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.classGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.classGridView.RowTemplate.DividerHeight = 1;
            this.classGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classGridView.Size = new System.Drawing.Size(1167, 529);
            this.classGridView.TabIndex = 16;
            this.classGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classGridView_CellClick);
            this.classGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classGridView_CellContentClick);
            this.classGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.classGridView_CellFormatting);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.updateBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.updateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateBtn.BorderRadius = 12;
            this.updateBtn.BorderSize = 0;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(960, 23);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(109, 40);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "  Sửa";
            this.updateBtn.TextColor = System.Drawing.Color.White;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.createBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.createBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createBtn.BorderRadius = 12;
            this.createBtn.BorderSize = 0;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Image = ((System.Drawing.Image)(resources.GetObject("createBtn.Image")));
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(1075, 23);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(109, 40);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "   Tạo mới";
            this.createBtn.TextColor = System.Drawing.Color.White;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.searchBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 12;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(1138, 98);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(46, 37);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = " ";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // tatcaBtn
            // 
            this.tatcaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.tatcaBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
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
            // daDongBtn
            // 
            this.daDongBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.daDongBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.daDongBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.daDongBtn.BorderRadius = 0;
            this.daDongBtn.BorderSize = 0;
            this.daDongBtn.FlatAppearance.BorderSize = 0;
            this.daDongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daDongBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daDongBtn.ForeColor = System.Drawing.Color.White;
            this.daDongBtn.Location = new System.Drawing.Point(247, 92);
            this.daDongBtn.Name = "daDongBtn";
            this.daDongBtn.Size = new System.Drawing.Size(114, 40);
            this.daDongBtn.TabIndex = 5;
            this.daDongBtn.Text = "Đã đóng";
            this.daDongBtn.TextColor = System.Drawing.Color.White;
            this.daDongBtn.UseVisualStyleBackColor = false;
            this.daDongBtn.Click += new System.EventHandler(this.daDongBtn_Click);
            // 
            // dangMoBtn
            // 
            this.dangMoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.dangMoBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.dangMoBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dangMoBtn.BorderRadius = 0;
            this.dangMoBtn.BorderSize = 0;
            this.dangMoBtn.FlatAppearance.BorderSize = 0;
            this.dangMoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangMoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangMoBtn.ForeColor = System.Drawing.Color.White;
            this.dangMoBtn.Location = new System.Drawing.Point(132, 92);
            this.dangMoBtn.Name = "dangMoBtn";
            this.dangMoBtn.Size = new System.Drawing.Size(114, 40);
            this.dangMoBtn.TabIndex = 5;
            this.dangMoBtn.Text = "Đang mở";
            this.dangMoBtn.TextColor = System.Drawing.Color.White;
            this.dangMoBtn.UseVisualStyleBackColor = false;
            this.dangMoBtn.Click += new System.EventHandler(this.dangMoBtn_Click);
            // 
            // LophocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.classGridView);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.tatcaBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private CustomControls.RJControls.RJButton searchBtn;
        private CustomControls.RJControls.RJButton createBtn;
        private CustomControls.RJControls.RJButton tatcaBtn;
        private CustomControls.RJControls.RJButton daDongBtn;
        private CustomControls.RJControls.RJButton dangMoBtn;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton updateBtn;
        private RoundedGridView classGridView;
    }
}