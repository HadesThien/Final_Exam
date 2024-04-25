namespace Final_Exam {
    partial class TaoLopForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.monHocTextBox = new CustomControls.RJControls.RJTextBox();
            this.soBuoiTextBox = new CustomControls.RJControls.RJTextBox();
            this.soHocSinhTextBox = new CustomControls.RJControls.RJTextBox();
            this.caHocTextBox = new CustomControls.RJControls.RJTextBox();
            this.khoiHocTextBox = new CustomControls.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maLopTextBox = new CustomControls.RJControls.RJTextBox();
            this.giaTienTextBox = new CustomControls.RJControls.RJTextBox();
            this.tenLopTextBox = new CustomControls.RJControls.RJTextBox();
            this.cancelBtn = new CustomControls.RJControls.RJButton();
            this.saveBtn = new CustomControls.RJControls.RJButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo lớp học";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ca học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Khối học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số buổi học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số lượng học sinh:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.monHocTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.soBuoiTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.soHocSinhTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.caHocTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.khoiHocTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 538);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // monHocTextBox
            // 
            this.monHocTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monHocTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.monHocTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.monHocTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.monHocTextBox.BorderRadius = 0;
            this.monHocTextBox.BorderSize = 2;
            this.monHocTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monHocTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monHocTextBox.Location = new System.Drawing.Point(332, 4);
            this.monHocTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.monHocTextBox.Multiline = false;
            this.monHocTextBox.Name = "monHocTextBox";
            this.monHocTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.monHocTextBox.PasswordChar = false;
            this.monHocTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.monHocTextBox.PlaceholderText = "";
            this.monHocTextBox.Size = new System.Drawing.Size(321, 36);
            this.monHocTextBox.TabIndex = 0;
            this.monHocTextBox.Texts = "";
            this.monHocTextBox.UnderlinedStyle = false;
            this.monHocTextBox.Leave += new System.EventHandler(this.monHocTextBox_Leave);
            // 
            // soBuoiTextBox
            // 
            this.soBuoiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soBuoiTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.soBuoiTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.soBuoiTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.soBuoiTextBox.BorderRadius = 0;
            this.soBuoiTextBox.BorderSize = 2;
            this.soBuoiTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soBuoiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soBuoiTextBox.Location = new System.Drawing.Point(332, 325);
            this.soBuoiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.soBuoiTextBox.Multiline = false;
            this.soBuoiTextBox.Name = "soBuoiTextBox";
            this.soBuoiTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.soBuoiTextBox.PasswordChar = false;
            this.soBuoiTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.soBuoiTextBox.PlaceholderText = "";
            this.soBuoiTextBox.Size = new System.Drawing.Size(321, 36);
            this.soBuoiTextBox.TabIndex = 3;
            this.soBuoiTextBox.Texts = "";
            this.soBuoiTextBox.UnderlinedStyle = false;
            this.soBuoiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soBuoiTextBox_KeyPress);
            // 
            // soHocSinhTextBox
            // 
            this.soHocSinhTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soHocSinhTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.soHocSinhTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.soHocSinhTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.soHocSinhTextBox.BorderRadius = 0;
            this.soHocSinhTextBox.BorderSize = 2;
            this.soHocSinhTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soHocSinhTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soHocSinhTextBox.Location = new System.Drawing.Point(332, 432);
            this.soHocSinhTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.soHocSinhTextBox.Multiline = false;
            this.soHocSinhTextBox.Name = "soHocSinhTextBox";
            this.soHocSinhTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.soHocSinhTextBox.PasswordChar = false;
            this.soHocSinhTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.soHocSinhTextBox.PlaceholderText = "";
            this.soHocSinhTextBox.Size = new System.Drawing.Size(321, 36);
            this.soHocSinhTextBox.TabIndex = 4;
            this.soHocSinhTextBox.Texts = "";
            this.soHocSinhTextBox.UnderlinedStyle = false;
            this.soHocSinhTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soHocSinhTextBox_KeyPress);
            // 
            // caHocTextBox
            // 
            this.caHocTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caHocTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.caHocTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.caHocTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.caHocTextBox.BorderRadius = 0;
            this.caHocTextBox.BorderSize = 2;
            this.caHocTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caHocTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.caHocTextBox.Location = new System.Drawing.Point(332, 218);
            this.caHocTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.caHocTextBox.Multiline = false;
            this.caHocTextBox.Name = "caHocTextBox";
            this.caHocTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.caHocTextBox.PasswordChar = false;
            this.caHocTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.caHocTextBox.PlaceholderText = "";
            this.caHocTextBox.Size = new System.Drawing.Size(321, 36);
            this.caHocTextBox.TabIndex = 2;
            this.caHocTextBox.Texts = "";
            this.caHocTextBox.UnderlinedStyle = false;
            this.caHocTextBox.Leave += new System.EventHandler(this.caHocTextBox_Leave);
            // 
            // khoiHocTextBox
            // 
            this.khoiHocTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khoiHocTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.khoiHocTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.khoiHocTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.khoiHocTextBox.BorderRadius = 0;
            this.khoiHocTextBox.BorderSize = 2;
            this.khoiHocTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoiHocTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.khoiHocTextBox.Location = new System.Drawing.Point(332, 111);
            this.khoiHocTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.khoiHocTextBox.Multiline = false;
            this.khoiHocTextBox.Name = "khoiHocTextBox";
            this.khoiHocTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.khoiHocTextBox.PasswordChar = false;
            this.khoiHocTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.khoiHocTextBox.PlaceholderText = "";
            this.khoiHocTextBox.Size = new System.Drawing.Size(321, 36);
            this.khoiHocTextBox.TabIndex = 1;
            this.khoiHocTextBox.Texts = "";
            this.khoiHocTextBox.UnderlinedStyle = false;
            this.khoiHocTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.khoiHocTextBox_KeyPress);
            this.khoiHocTextBox.Leave += new System.EventHandler(this.khoiHocTextBox_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(707, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã lớp (phát sinh tự động): ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(707, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 37);
            this.label9.TabIndex = 1;
            this.label9.Text = "Giá tiền:";
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(710, 526);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(250, 21);
            this.alert.TabIndex = 8;
            this.alert.Text = "*Giá tiền phải lớn hơn 1.000 đồng";
            this.alert.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(1094, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = ".Vnđ";
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maLopTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.maLopTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.maLopTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.maLopTextBox.BorderRadius = 0;
            this.maLopTextBox.BorderSize = 2;
            this.maLopTextBox.Enabled = false;
            this.maLopTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLopTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maLopTextBox.Location = new System.Drawing.Point(712, 147);
            this.maLopTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maLopTextBox.Multiline = false;
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.maLopTextBox.PasswordChar = false;
            this.maLopTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.maLopTextBox.PlaceholderText = "";
            this.maLopTextBox.Size = new System.Drawing.Size(434, 40);
            this.maLopTextBox.TabIndex = 4;
            this.maLopTextBox.Texts = "";
            this.maLopTextBox.UnderlinedStyle = false;
            // 
            // giaTienTextBox
            // 
            this.giaTienTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giaTienTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.giaTienTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.giaTienTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.giaTienTextBox.BorderRadius = 0;
            this.giaTienTextBox.BorderSize = 2;
            this.giaTienTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaTienTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.giaTienTextBox.Location = new System.Drawing.Point(712, 477);
            this.giaTienTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.giaTienTextBox.Multiline = false;
            this.giaTienTextBox.Name = "giaTienTextBox";
            this.giaTienTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.giaTienTextBox.PasswordChar = false;
            this.giaTienTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.giaTienTextBox.PlaceholderText = "";
            this.giaTienTextBox.Size = new System.Drawing.Size(434, 40);
            this.giaTienTextBox.TabIndex = 5;
            this.giaTienTextBox.Texts = "";
            this.giaTienTextBox.UnderlinedStyle = false;
            this.giaTienTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giaTienTextBox_KeyPress);
            this.giaTienTextBox.Leave += new System.EventHandler(this.giaTienTextBox_Leave);
            // 
            // tenLopTextBox
            // 
            this.tenLopTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tenLopTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.tenLopTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tenLopTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tenLopTextBox.BorderRadius = 0;
            this.tenLopTextBox.BorderSize = 2;
            this.tenLopTextBox.Enabled = false;
            this.tenLopTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenLopTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tenLopTextBox.Location = new System.Drawing.Point(712, 320);
            this.tenLopTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tenLopTextBox.Multiline = false;
            this.tenLopTextBox.Name = "tenLopTextBox";
            this.tenLopTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tenLopTextBox.PasswordChar = false;
            this.tenLopTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tenLopTextBox.PlaceholderText = "";
            this.tenLopTextBox.Size = new System.Drawing.Size(434, 40);
            this.tenLopTextBox.TabIndex = 4;
            this.tenLopTextBox.Texts = "";
            this.tenLopTextBox.UnderlinedStyle = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.Lavender;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.Lavender;
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(829, 587);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 40);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Đóng";
            this.cancelBtn.TextColor = System.Drawing.Color.Black;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 0;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(998, 587);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(150, 40);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // TaoLopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1170, 639);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.maLopTextBox);
            this.Controls.Add(this.giaTienTextBox);
            this.Controls.Add(this.tenLopTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaoLopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox monHocTextBox;
        private CustomControls.RJControls.RJTextBox caHocTextBox;
        private CustomControls.RJControls.RJTextBox khoiHocTextBox;
        private CustomControls.RJControls.RJTextBox soBuoiTextBox;
        private CustomControls.RJControls.RJTextBox soHocSinhTextBox;
        private CustomControls.RJControls.RJButton saveBtn;
        private CustomControls.RJControls.RJButton cancelBtn;
        private CustomControls.RJControls.RJTextBox tenLopTextBox;
        private CustomControls.RJControls.RJTextBox maLopTextBox;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox giaTienTextBox;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.Label label10;
    }
}