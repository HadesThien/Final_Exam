using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam.pop_upForm {
    public partial class DoiMatKhauForm : Form {
        private BUS_Account account;
        public DoiMatKhauForm(ref BUS_Account account) {
            InitializeComponent();
            this.account= account;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            if(MessageBox.Show($"Bạn có chắc muốn đổi mật khẩu thành {passwordTextbox.Texts}","Đổi mật khẩu", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                string newPassword = passwordTextbox.Texts;
                if (CheckPasswordFormat(newPassword)) {
                    account.changePassword(newPassword);
                    this.Close();
                }else {
                    alert.Visible = true;
                }
            }
        }

        private void DoiMatKhauForm_Load(object sender, EventArgs e) {
            passwordTextbox.PasswordChar = true;
            alert.Visible = false;
        }

        private void passwordTextbox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) saveBtn_Click(sender, e);
        }
        private bool CheckPasswordFormat(string password) {
            if (password.Length < 8 || password.Length > 20) {
                alert.Text = "*Độ dài mật khẩu phải từ 8-20";
                return false;
            }

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit)) {
                alert.Text = "*Mật khẩu phải có ít nhất một chữ hoa,\n một chữ thường và một chữ số";
                return false;
            }
            return true;
        }


        private void passwordTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            alert.Visible=false;
        }
    }
}
