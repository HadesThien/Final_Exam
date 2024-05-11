namespace Final_Exam {
    partial class ThanhToanForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToanForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchStudentTextBox = new System.Windows.Forms.TextBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.cancelBtn = new CustomControls.RJControls.RJButton();
            this.saveBtn = new CustomControls.RJControls.RJButton();
            this.documentCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.classCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.promotionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.tempCheckoutLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.payBtn = new CustomControls.RJControls.RJButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.roundedGridView1 = new Final_Exam.RoundedGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.searchStudentTextBox);
            this.panel1.Controls.Add(this.studentListBox);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.documentCheckedListBox);
            this.panel1.Controls.Add(this.classCheckedListBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.promotionLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkoutLabel);
            this.panel1.Controls.Add(this.tempCheckoutLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.payBtn);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(876, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 727);
            this.panel1.TabIndex = 0;
            // 
            // searchStudentTextBox
            // 
            this.searchStudentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudentTextBox.Location = new System.Drawing.Point(21, 47);
            this.searchStudentTextBox.Name = "searchStudentTextBox";
            this.searchStudentTextBox.Size = new System.Drawing.Size(291, 37);
            this.searchStudentTextBox.TabIndex = 16;
            this.searchStudentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchStudentTextBox_KeyDown_1);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 28;
            this.studentListBox.Location = new System.Drawing.Point(21, 76);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(291, 116);
            this.studentListBox.TabIndex = 15;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Lavender;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.Lavender;
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(24, 679);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(88, 40);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Đóng";
            this.cancelBtn.TextColor = System.Drawing.Color.Black;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 0;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(118, 679);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 40);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // documentCheckedListBox
            // 
            this.documentCheckedListBox.FormattingEnabled = true;
            this.documentCheckedListBox.Location = new System.Drawing.Point(21, 417);
            this.documentCheckedListBox.Name = "documentCheckedListBox";
            this.documentCheckedListBox.Size = new System.Drawing.Size(291, 120);
            this.documentCheckedListBox.TabIndex = 11;
            this.documentCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.documentCheckedListBox_ItemCheck);
            this.documentCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.documentCheckedListBox_SelectedIndexChanged);
            // 
            // classCheckedListBox
            // 
            this.classCheckedListBox.FormattingEnabled = true;
            this.classCheckedListBox.Location = new System.Drawing.Point(22, 242);
            this.classCheckedListBox.Name = "classCheckedListBox";
            this.classCheckedListBox.Size = new System.Drawing.Size(291, 120);
            this.classCheckedListBox.TabIndex = 11;
            this.classCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.classCheckedListBox_ItemCheck);
            this.classCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.classCheckedListBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Thành tiền";
            // 
            // promotionLabel
            // 
            this.promotionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promotionLabel.AutoSize = true;
            this.promotionLabel.Location = new System.Drawing.Point(148, 616);
            this.promotionLabel.Name = "promotionLabel";
            this.promotionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.promotionLabel.Size = new System.Drawing.Size(23, 28);
            this.promotionLabel.TabIndex = 8;
            this.promotionLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Khuyến mãi:";
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Location = new System.Drawing.Point(148, 648);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkoutLabel.Size = new System.Drawing.Size(23, 28);
            this.checkoutLabel.TabIndex = 8;
            this.checkoutLabel.Text = "0";
            // 
            // tempCheckoutLabel
            // 
            this.tempCheckoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempCheckoutLabel.AutoSize = true;
            this.tempCheckoutLabel.Location = new System.Drawing.Point(148, 587);
            this.tempCheckoutLabel.Name = "tempCheckoutLabel";
            this.tempCheckoutLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tempCheckoutLabel.Size = new System.Drawing.Size(23, 28);
            this.tempCheckoutLabel.TabIndex = 8;
            this.tempCheckoutLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tạm tính:";
            // 
            // payBtn
            // 
            this.payBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.payBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.payBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.payBtn.BorderRadius = 0;
            this.payBtn.BorderSize = 0;
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(212, 679);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(88, 40);
            this.payBtn.TabIndex = 7;
            this.payBtn.Text = "Thanh toán";
            this.payBtn.TextColor = System.Drawing.Color.White;
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(100, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 37);
            this.label12.TabIndex = 5;
            this.label12.Text = "Đề cương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(100, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn học sinh tại đây";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin học viên";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(12, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi Chú:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.Location = new System.Drawing.Point(88, 518);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(782, 197);
            this.noteTextBox.TabIndex = 6;
            this.noteTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(8, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đăng ký mới / Thanh toán";
            // 
            // studentLabel
            // 
            this.studentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.studentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.studentLabel.Location = new System.Drawing.Point(537, 15);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.studentLabel.Size = new System.Drawing.Size(218, 28);
            this.studentLabel.TabIndex = 7;
            this.studentLabel.Text = "[Học sinh thanh toán]";
            // 
            // roundedGridView1
            // 
            this.roundedGridView1.AllowUserToAddRows = false;
            this.roundedGridView1.AllowUserToDeleteRows = false;
            this.roundedGridView1.AllowUserToResizeColumns = false;
            this.roundedGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.roundedGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roundedGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roundedGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.roundedGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedGridView1.BorderRadius = 7;
            this.roundedGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roundedGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roundedGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roundedGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roundedGridView1.ColumnHeadersHeight = 50;
            this.roundedGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roundedGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.roundedGridView1.EnableHeadersVisualStyles = false;
            this.roundedGridView1.GridColor = System.Drawing.Color.GhostWhite;
            this.roundedGridView1.Location = new System.Drawing.Point(12, 57);
            this.roundedGridView1.MultiSelect = false;
            this.roundedGridView1.Name = "roundedGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roundedGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.roundedGridView1.RowHeadersVisible = false;
            this.roundedGridView1.RowHeadersWidth = 51;
            this.roundedGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.roundedGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.roundedGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.roundedGridView1.RowTemplate.DividerHeight = 1;
            this.roundedGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roundedGridView1.Size = new System.Drawing.Size(858, 455);
            this.roundedGridView1.TabIndex = 11;
            this.roundedGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.roundedGridView1_CellValueChanged);
            // 
            // ThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.ControlBox = false;
            this.Controls.Add(this.roundedGridView1);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThanhToanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ThanhToanForm_Load);
            this.Shown += new System.EventHandler(this.ThanhToanForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox noteTextBox;
        private CustomControls.RJControls.RJButton payBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label promotionLabel;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.Label tempCheckoutLabel;
        private System.Windows.Forms.CheckedListBox classCheckedListBox;
        private System.Windows.Forms.CheckedListBox documentCheckedListBox;
        private System.Windows.Forms.Label label12;
        private CustomControls.RJControls.RJButton saveBtn;
        private CustomControls.RJControls.RJButton cancelBtn;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.TextBox searchStudentTextBox;
        private RoundedGridView roundedGridView1;
    }
}