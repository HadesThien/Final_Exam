using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam.pop_upForm {
    public partial class RegisterAccountForm : Form {
        public RegisterAccountForm() {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void confirmPasswordTextBox_Leave(object sender, EventArgs e) {
            alertPassword.Visible = (confirmPasswordTextBox.Texts != passwordTextBox.Texts) ? true : false;
        }

        private void emailTextBox_Leave(object sender, EventArgs e) {
            alertEmail.Visible = (!emailTextBox.Texts.Contains("@") &&  emailTextBox.Texts.Contains(".")) ? true : false;
        }

        private void accountTextBox_Leave(object sender, EventArgs e) {

        }

        private void saveBtn_Click(object sender, EventArgs e) {
            if(alertPassword.Visible && alertEmail.Visible && alertEmail.Visible) 
            {
                MessageBox.Show("Không thể tạo tại khoản, vui lòng điền thông tin hợp lệ", "Thông báo tài khoản đang tạo!", MessageBoxButtons.OK);
            }else
            {

            }
        }

        private void numberPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }
    }
}
