using BUS;
using DTO;
using NQH_Application.pop_upForm;
using System;
using System.Data;
using System.Windows.Forms;

namespace NQH_Application{
    public partial class AccountInfoForm : Form {
        //Properties 
        DTO_Account account; 
        BUS_Account busAccount;
        DataTable dt; 
        private int currentIndex;

        private string username;
        private string password;
        private string dateCreated;
        private string role;
        
        //This function is used to set some property of account object whenever event goes on 
        public void setInfoAccoun(object sender, EventArgs e) {
            this.username = accountGridView.Rows[currentIndex].Cells[0].Value.ToString();
            this.password = accountGridView.Rows[currentIndex].Cells[1].Value.ToString();
            this.dateCreated = accountGridView.Rows[currentIndex].Cells[2].Value.ToString();
            this.role = accountGridView.Rows[currentIndex].Cells[3].Value.ToString();
        }

        //Contructors 
        public AccountInfoForm() {
            InitializeComponent();
        }

        //This function is used to open register account form 
        private void registerBtn_Click(object sender, EventArgs e) {
            Form form = new RegisterAccountForm(this);
            form.ShowDialog();
        }

        //This funcion is used to open changing account's password form 
        private void changePwBtn_Click(object sender, EventArgs e) {
            this.account = new DTO_Account(username,password,DateTime.Parse(dateCreated),role);
            this.busAccount = new BUS_Account(account);
            Form form = new ChangePasswordForm(ref busAccount);
            form.ShowDialog();
            AccountInfoForm_Load(sender, e);
        }

        //This function is used to check right of account and set visibility of some components
        private void accountGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (Account.getAccount().getRole() == "Admin") {
                changePwBtn.Visible = true;
                xoaBtn.Visible = true;
                updateBtn.Visible = true;
                currentIndex = e.RowIndex;
            }
        }

        //This fucntion is used to remove account in database 
        private void xoaBtn_Click(object sender, EventArgs e) {
            account = new DTO_Account(username,password,DateTime.Parse(dateCreated),role);
            busAccount = new BUS_Account(account);
            Form confirmForm = new ConfirmForm();
            confirmForm.ShowDialog();
            if(Account.isPermited() == true)
                busAccount.remove();
            Account.denyAccess();
            AccountInfoForm_Load(sender, e);
        }

        //This function is used to be called in some event function because of reloading view when action goes on 
        public void updateGridView()
        {
            account = new DTO_Account("", "",DateTime.Now,"") ;
            busAccount= new BUS_Account(account);
            dt = busAccount.showAccounts();
            dt.Columns[0].ColumnName = "Tên đăng nhập";
            dt.Columns[1].ColumnName = "Mật khẩu";
            dt.Columns[2].ColumnName = "Ngày tạo";
            dt.Columns[3].ColumnName = "Quyền";
            dt.Columns.Remove(dt.Columns[4]);
            accountGridView.DataSource = dt;
            accountGridView.ClearSelection();
            //Set information of Account 
            accountLabel.Text = Account.getAccount().getUsername();
            passwordLabel.Text = Account.getAccount().getPassword();
            roleLabel.Text = Account.getAccount().getRole();
            numberPhoneLabel.Text = Account.getUser().getPhoneNumber();
            emailLabel.Text = Account.getUser().getEmail();
            nameLabel.Text = Account.getUser().getFullname();

            if (Account.getAccount().getRole()  != "Admin") {
                registerBtn.Visible = false;
                accountGridView.Visible = false;    
                updateBtn.Visible = false;
            }
        }
        
        //This function is used to load this form 
        private void AccountInfoForm_Load(object sender, EventArgs e) {
            updateGridView();
        }

        //This function is used to open form for user to confirm updating this account's information
        private void updateBtn_Click(object sender, EventArgs e) {
            account = new DTO_Account(username,password,DateTime.Parse(dateCreated),role);
            busAccount = new BUS_Account(account);
            Form form = new RegisterAccountForm(busAccount, this);
            form.ShowDialog();
            AccountInfoForm_Load(sender, e);
        }

    }
}
