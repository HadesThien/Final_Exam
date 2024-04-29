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


        //Contructors 
        public AccountInfoForm() {
            InitializeComponent();

        }

        private void registerBtn_Click(object sender, EventArgs e) {
            Form form = new RegisterAccountForm();
            form.ShowDialog();
        }

        private void changePwBtn_Click(object sender, EventArgs e) {
            string username = accountGridView.Rows[currentIndex].Cells["username"].Value.ToString();
            string password = accountGridView.Rows[currentIndex].Cells["password"].Value.ToString();
            string role = accountGridView.Rows[currentIndex].Cells["role"].Value.ToString();
            string numberphone = accountGridView.Rows[currentIndex].Cells["numberPhone"].Value.ToString();
            string email = accountGridView.Rows[currentIndex].Cells["email"].Value.ToString();
            string name = accountGridView.Rows[currentIndex].Cells["name"].Value.ToString();
            string lastLoginDate= accountGridView.Rows[currentIndex].Cells["lastLoginDate"].Value.ToString();
            string dateCreated = accountGridView.Rows[currentIndex].Cells["dateCreated"].Value.ToString();
            account = new BUS_Account(username,password,DateTime.Parse(dateCreated),DateTime.Parse(lastLoginDate),role,email,numberphone,name);
            Form form = new DoiMatKhauForm(ref account);
            form.ShowDialog();
            AccountInfoForm_Load(sender, e);
        }
        private void accountGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(Account.account.getRole() == "admin") {
                changePwBtn.Visible = true;
                xoaBtn.Visible = true;
                currentIndex = e.RowIndex;
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e) {
            string username = accountGridView.Rows[currentIndex].Cells["username"].Value.ToString();
            string password = accountGridView.Rows[currentIndex].Cells["password"].Value.ToString();
            string role = accountGridView.Rows[currentIndex].Cells["role"].Value.ToString();
            string numberphone = accountGridView.Rows[currentIndex].Cells["numberPhone"].Value.ToString();
            string email = accountGridView.Rows[currentIndex].Cells["email"].Value.ToString();
            string name = accountGridView.Rows[currentIndex].Cells["name"].Value.ToString();
            string lastLoginDate= accountGridView.Rows[currentIndex].Cells["lastLoginDate"].Value.ToString();
            string dateCreated = accountGridView.Rows[currentIndex].Cells["dateCreated"].Value.ToString();
            account = new BUS_Account(username,password,DateTime.Parse(dateCreated),DateTime.Parse(lastLoginDate),role,email,numberphone,name);
            Form confirmForm = new ConfirmForm();
            confirmForm.ShowDialog();
            
            account.remove();
            AccountInfoForm_Load(sender, e);
        }

        private void AccountInfoForm_Load(object sender, EventArgs e) {
            account = new BUS_Account("", "",DateTime.Now,DateTime.Now,"","","","") ;
            accountGridView.DataSource = account.showAccounts();
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
            }
         }
    }
}
