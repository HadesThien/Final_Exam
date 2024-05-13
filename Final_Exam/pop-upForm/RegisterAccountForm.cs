using BUS;
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
        //Properties
        BUS_Account account;
        DataTable dt;
        private AccountInfoForm form;
        //Contructor
        public RegisterAccountForm(AccountInfoForm form) {
            InitializeComponent();
            passwordTextBox.PasswordChar = true;
            this.form = form;
        }
        public RegisterAccountForm( BUS_Account account, AccountInfoForm form ) {
            InitializeComponent();
            this.account = account;
            passwordTextBox.PasswordChar = true;
            accountTextBox.Texts = account.getUsername();
            accountTextBox.Enabled = false;
            passwordTextBox.Texts= account.getPassword();
            passwordTextBox.Enabled = false;
            roleComboBox.Texts = account.getRole();
            emailTextBox.Texts = account.getEmail();
            numberPhoneTextBox.Texts = account.getNumberphone();
            nameTextBox.Texts = account.getName();
            this.form = form;
            saveBtn.Text = "Cập nhật";
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

 
        private void emailTextBox_Leave(object sender, EventArgs e) {
            alertEmail.Visible = (!emailTextBox.Texts.Contains("@") &&  !emailTextBox.Texts.Contains(".")) ? true : false;

        }


        private void saveBtn_Click(object sender, EventArgs e) {
            if(passwordFormattingAlert.Visible||alertEmail.Visible || alertEmail.Visible || alertNumberphone.Visible || alertName.Visible  && saveBtn.Text =="Lưu") 
            {
                MessageBox.Show("Không thể tạo tại khoản, vui lòng điền thông tin hợp lệ", "Thông báo tài khoản đang tạo!", MessageBoxButtons.OK);
            }else
            {
                if(MessageBox.Show("Bạn có chắc đã kiểm tra kỹ thông tin tài khoản trước khi đăng ký ?", "Nhắc nhở", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                    string username = accountTextBox.Texts.Trim();
                    string password = passwordTextBox.Texts.Trim();
                    string role = roleComboBox.Texts;
                    if (role == "Quản lý") role = "admin"; else role = "user";
                    string email = emailTextBox.Texts.Trim();
                    string numberphone =numberPhoneTextBox.Texts.Trim();
                    string name = nameTextBox.Texts.Trim();
                    account = new BUS_Account(username,password,DateTime.Now,DateTime.Now, role, email, numberphone, name);
                    if(saveBtn.Text.Equals("Lưu")) account.addAccount();
                    else if (saveBtn.Text.Equals("Cập nhật")) account.updateAccount();
                    form.updateGridView();
                    this.Close();
                }
            }
        }

        private void numberPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
            alertNumberphone.Visible = false;
        }

        private void accountTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            alertAccount.Visible = false;
        }
        private void accountTextBox_Leave(object sender, EventArgs e) {
            if(accountTextBox.Texts == "") {
                alertAccount.Visible = true;
                alertAccount.Text = "Tên đăng nhập là bắt buộc!";
            }else {
                account = new BUS_Account("", "", DateTime.Now, DateTime.Now, "", "", "", "");
                dt = account.showAccounts();
                foreach (DataRow row in  dt.Rows) {
                    if (row[0].ToString() == accountTextBox.Texts) {
                        alertAccount.Visible = true;
                        alertAccount.Text = "Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!";
                        break;
                    }
                }
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e) {
            if(nameTextBox.Texts == "") alertName.Visible = true;
            
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            alertName.Visible = false;
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            alertEmail.Visible = false;
        }

        private void numberPhoneTextBox_Leave(object sender, EventArgs e) {
            if (numberPhoneTextBox.Texts == "") alertNumberphone.Visible = true;
        }

 
        private void confirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) saveBtn_Click(sender, e);
        }
        private bool CheckPasswordFormat(string password) {
            if (password.Length < 8 || password.Length > 20) {
                passwordFormattingAlert.Text = "*Độ dài mật khẩu phải từ 8-20";
                return false;
            }

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit)) {
                passwordFormattingAlert.Text = "*Mật khẩu phải có ít nhất một chữ hoa,\n một chữ thường và một chữ số";
                return false;
            }
            return true;
        }

        private void passwordTextBox_Leave(object sender, EventArgs e) {
            if (CheckPasswordFormat(passwordTextBox.Texts)) {
                passwordFormattingAlert.Visible= true;
            }
        }
    }
}
