﻿namespace Final_Exam.pop_upForm {
    partial class DoiMatKhauForm {
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
            this.passwordTextbox = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new CustomControls.RJControls.RJButton();
            this.cancelBtn = new CustomControls.RJControls.RJButton();
            this.confirmTextBox = new CustomControls.RJControls.RJTextBox();
            this.alert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextbox.BorderRadius = 0;
            this.passwordTextbox.BorderSize = 2;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.Location = new System.Drawing.Point(13, 87);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordTextbox.PasswordChar = false;
            this.passwordTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTextbox.PlaceholderText = "";
            this.passwordTextbox.Size = new System.Drawing.Size(533, 36);
            this.passwordTextbox.TabIndex = 0;
            this.passwordTextbox.Texts = "";
            this.passwordTextbox.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(190, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đổi mật khẩu ";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 0;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(376, 222);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(170, 52);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(197, 222);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(170, 52);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Thoát";
            this.cancelBtn.TextColor = System.Drawing.Color.White;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.confirmTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.confirmTextBox.BorderRadius = 0;
            this.confirmTextBox.BorderSize = 2;
            this.confirmTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmTextBox.Location = new System.Drawing.Point(13, 131);
            this.confirmTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmTextBox.Multiline = false;
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.confirmTextBox.PasswordChar = false;
            this.confirmTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.confirmTextBox.PlaceholderText = "";
            this.confirmTextBox.Size = new System.Drawing.Size(533, 36);
            this.confirmTextBox.TabIndex = 1;
            this.confirmTextBox.Texts = "";
            this.confirmTextBox.UnderlinedStyle = false;
            this.confirmTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmTextBox_KeyDown);
            this.confirmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmTextBox_KeyPress);
            this.confirmTextBox.Leave += new System.EventHandler(this.confirmTextBox_Leave);
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(254, 184);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(292, 21);
            this.alert.TabIndex = 3;
            this.alert.Text = "*Xác nhận mật khẩu không trùng khớp!";
            // 
            // DoiMatKhauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 286);
            this.ControlBox = false;
            this.Controls.Add(this.alert);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.passwordTextbox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DoiMatKhauForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoiMatKhauForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox passwordTextbox;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton saveBtn;
        private CustomControls.RJControls.RJButton cancelBtn;
        private CustomControls.RJControls.RJTextBox confirmTextBox;
        private System.Windows.Forms.Label alert;
    }
}