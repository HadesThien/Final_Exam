namespace Final_Exam {
    partial class AccountInfoForm {
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.accountLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberPhoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roundedGridView1 = new Final_Exam.RoundedGridView();
            this.registerBtn = new CustomControls.RJControls.RJButton();
            this.changePwBtn = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLabel.Location = new System.Drawing.Point(30, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(384, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Trung tâm quản lý tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.accountLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.numberPhoneLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 152);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(163, 0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(34, 21);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "null";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(163, 76);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(34, 21);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên người dùng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(483, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "null";
            // 
            // numberPhoneLabel
            // 
            this.numberPhoneLabel.AutoSize = true;
            this.numberPhoneLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPhoneLabel.Location = new System.Drawing.Point(483, 76);
            this.numberPhoneLabel.Name = "numberPhoneLabel";
            this.numberPhoneLabel.Size = new System.Drawing.Size(34, 21);
            this.numberPhoneLabel.TabIndex = 0;
            this.numberPhoneLabel.Text = "null";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(803, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(34, 21);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "null";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(643, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(420, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Role";
            // 
            // roundedGridView1
            // 
            this.roundedGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundedGridView1.BorderRadius = 10;
            this.roundedGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roundedGridView1.Location = new System.Drawing.Point(37, 228);
            this.roundedGridView1.Name = "roundedGridView1";
            this.roundedGridView1.Size = new System.Drawing.Size(1151, 487);
            this.roundedGridView1.TabIndex = 3;
            this.roundedGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roundedGridView1_CellClick);
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.registerBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.registerBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.registerBtn.BorderRadius = 20;
            this.registerBtn.BorderSize = 0;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(1004, 70);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerBtn.Size = new System.Drawing.Size(191, 51);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Đăng ký ";
            this.registerBtn.TextColor = System.Drawing.Color.White;
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // changePwBtn
            // 
            this.changePwBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changePwBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.changePwBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.changePwBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.changePwBtn.BorderRadius = 20;
            this.changePwBtn.BorderSize = 0;
            this.changePwBtn.FlatAppearance.BorderSize = 0;
            this.changePwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePwBtn.ForeColor = System.Drawing.Color.White;
            this.changePwBtn.Location = new System.Drawing.Point(1004, 146);
            this.changePwBtn.Name = "changePwBtn";
            this.changePwBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changePwBtn.Size = new System.Drawing.Size(191, 51);
            this.changePwBtn.TabIndex = 5;
            this.changePwBtn.Text = "Đổi mật khẩu";
            this.changePwBtn.TextColor = System.Drawing.Color.White;
            this.changePwBtn.UseVisualStyleBackColor = false;
            this.changePwBtn.Visible = false;
            this.changePwBtn.Click += new System.EventHandler(this.changePwBtn_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(685, 147);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rjButton1.Size = new System.Drawing.Size(191, 51);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Xóa";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Visible = false;
            this.rjButton1.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.ControlBox = false;
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.roundedGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.changePwBtn);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton registerBtn;
        private CustomControls.RJControls.RJButton changePwBtn;
        private RoundedGridView roundedGridView1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberPhoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}