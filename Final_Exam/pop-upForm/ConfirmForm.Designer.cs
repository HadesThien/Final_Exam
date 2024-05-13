namespace Final_Exam.pop_upForm {
    partial class ConfirmForm {
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
            this.haederLabel = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.passwordTextBox = new CustomControls.RJControls.RJTextBox();
            this.cancelBtn = new CustomControls.RJControls.RJButton();
            this.saveBtn = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // haederLabel
            // 
            this.haederLabel.AutoSize = true;
            this.haederLabel.Font = new System.Drawing.Font("Quicksand SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haederLabel.Location = new System.Drawing.Point(82, 19);
            this.haederLabel.Name = "haederLabel";
            this.haederLabel.Size = new System.Drawing.Size(249, 40);
            this.haederLabel.TabIndex = 2;
            this.haederLabel.Text = "Xác nhận yêu cầu";
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(197, 108);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(196, 21);
            this.alert.TabIndex = 3;
            this.alert.Text = "*Hãy nhập \"Tôi muốn CÓ\"";
            this.alert.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderRadius = 0;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Quicksand SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.passwordTextBox.Location = new System.Drawing.Point(13, 65);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordTextBox.PasswordChar = false;
            this.passwordTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.PlaceholderText = "Hãy nhập \"Tôi muốn  CÓ\"";
            this.passwordTextBox.Size = new System.Drawing.Size(380, 39);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = false;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightGray;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.LightGray;
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(184, 138);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 40);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Hủy bỏ";
            this.cancelBtn.TextColor = System.Drawing.Color.Black;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.saveBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 0;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(292, 138);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 40);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Xác nhận";
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 190);
            this.ControlBox = false;
            this.Controls.Add(this.alert);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.haederLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label haederLabel;
        private CustomControls.RJControls.RJButton saveBtn;
        private CustomControls.RJControls.RJButton cancelBtn;
        private CustomControls.RJControls.RJTextBox passwordTextBox;
        private System.Windows.Forms.Label alert;
    }
}