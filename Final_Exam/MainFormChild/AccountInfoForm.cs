using BUS;
using Final_Exam.pop_upForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam {
    public partial class AccountInfoForm : Form {
        //Properties 
        BUS_Account account;
        private int currentIndex;
        DataTable dt; 

        //Contructors 
        public AccountInfoForm() {
            InitializeComponent();
            
        }

        private void registerBtn_Click(object sender, EventArgs e) {
            Form form = new RegisterAccountForm(this);
            form.ShowDialog();
        }

        private void changePwBtn_Click(object sender, EventArgs e) {
            string username = accountGridView.Rows[currentIndex].Cells[0].Value.ToString();
            string password = accountGridView.Rows[currentIndex].Cells[1].Value.ToString();
            string role = accountGridView.Rows[currentIndex].Cells[2].Value.ToString();
            string numberphone = accountGridView.Rows[currentIndex].Cells[3].Value.ToString();
            string email = accountGridView.Rows[currentIndex].Cells[4].Value.ToString();
            string name = accountGridView.Rows[currentIndex].Cells[5].Value.ToString();
            string lastLoginDate= accountGridView.Rows[currentIndex].Cells[6].Value.ToString();
            string dateCreated = accountGridView.Rows[currentIndex].Cells[7].Value.ToString();
            account = new BUS_Account(username,password,DateTime.Parse(dateCreated),DateTime.Parse(lastLoginDate),role,email,numberphone,name);
            Form form = new DoiMatKhauForm(ref account);
            form.ShowDialog();
            AccountInfoForm_Load(sender, e);
        }
        private void accountGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(Account.account.getRole() == "admin") {
                changePwBtn.Visible = true;
                xoaBtn.Visible = true;
                updateBtn.Visible = true;
                currentIndex = e.RowIndex;
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e) {
            string username = accountGridView.Rows[currentIndex].Cells[0].Value.ToString();
            string password = accountGridView.Rows[currentIndex].Cells[1].Value.ToString();
            string role = accountGridView.Rows[currentIndex].Cells[2].Value.ToString();
            string numberphone = accountGridView.Rows[currentIndex].Cells[3].Value.ToString();
            string email = accountGridView.Rows[currentIndex].Cells[4].Value.ToString();
            string name = accountGridView.Rows[currentIndex].Cells[5].Value.ToString();
            string lastLoginDate= accountGridView.Rows[currentIndex].Cells[6].Value.ToString();
            string dateCreated = accountGridView.Rows[currentIndex].Cells[7].Value.ToString();
            account = new BUS_Account(username,password,DateTime.Parse(dateCreated),DateTime.Parse(lastLoginDate),role,email,numberphone,name);
            Form confirmForm = new ConfirmForm();
            confirmForm.ShowDialog();
            if(Account.confirmPassword == true)
                account.remove();
            Account.confirmPassword = false;
            AccountInfoForm_Load(sender, e);
        }

        public void updateGridView()
        {
            account = new BUS_Account("", "",DateTime.Now,DateTime.Now,"","","","") ;
            dt = account.showAccounts();
            dt.Columns[0].ColumnName = "Tên đăng nhập";
            dt.Columns[1].ColumnName = "Mật khẩu";
            dt.Columns[2].ColumnName = "Quyền";
            dt.Columns[3].ColumnName = "Email";
            dt.Columns[4].ColumnName = "Số điện thoại";
            dt.Columns[5].ColumnName = "Tên người dùng";
            dt.Columns[6].ColumnName = "Sử dụng gần đây";
            dt.Columns[7].ColumnName = "Ngày tạo";

            accountGridView.DataSource = dt;
            accountGridView.ClearSelection();
            //Set information of Account 
            accountLabel.Text = Account.account.getUsername();
            passwordLabel.Text = Account.account.getPassword();
            nameLabel.Text = Account.account.getName();
            numberPhoneLabel.Text = Account.account.getNumberphone();
            emailLabel.Text = Account.account.getEmail();   
            roleLabel.Text = Account.account.getRole(); 
            if(Account.account.getRole()  != "admin") {
                registerBtn.Visible = false;
                accountGridView.Visible = false;    
                updateBtn.Visible = false;
            }
        }

        private void AccountInfoForm_Load(object sender, EventArgs e) {
            updateGridView();
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            string username = accountGridView.Rows[currentIndex].Cells[0].Value.ToString();
            string password = accountGridView.Rows[currentIndex].Cells[1].Value.ToString();
            string role = accountGridView.Rows[currentIndex].Cells[2].Value.ToString();
            string numberphone = accountGridView.Rows[currentIndex].Cells[3].Value.ToString();
            string email = accountGridView.Rows[currentIndex].Cells[4].Value.ToString();
            string name = accountGridView.Rows[currentIndex].Cells[5].Value.ToString();
            string lastLoginDate= accountGridView.Rows[currentIndex].Cells[6].Value.ToString();
            string dateCreated = accountGridView.Rows[currentIndex].Cells[7].Value.ToString();
            account = new BUS_Account(username,password,DateTime.Parse(dateCreated),DateTime.Parse(lastLoginDate),role,email,numberphone,name);
            Form form = new RegisterAccountForm(account);
            form.ShowDialog();
            AccountInfoForm_Load(sender, e);
        }
    }
}
