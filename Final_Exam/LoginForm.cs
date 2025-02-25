using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BUS;
using DTO;


namespace NQH_Application{
    public partial class LoginForm : Form {
        //Field 
        DTO_Account account;
        DTO_Employee user;
        BUS_Account busAccount;
        BUS_Employee busUser;

        private DataTable tableAccount; 
        public static bool isLogin = false;

        //Configurations
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
                (
                    int nLeftRect,     // x-coordinate of upper-left corner
                    int nTopRect,      // y-coordinate of upper-left corner
                    int nRightRect,    // x-coordinate of lower-right corner
                    int nBottomRect,   // y-coordinate of lower-right corner
                    int nWidthEllipse, // width of ellipse
                    int nHeightEllipse // height of ellipse
                );

        //Constructor 
        public LoginForm() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            passwordTextBox.PasswordChar = true;
            account = new DTO_Account("","",DateTime.Now,"");
            busAccount = new BUS_Account(account);
            busUser = new BUS_Employee(user);
            tableAccount = busAccount.showAccounts();
        }

        // Events Actions called by Button of form
        //This function is used to log out of account
        private void exitBtn_Click(object sender, EventArgs e) {
            MainForm.isLogout = false;
            this.Close();
        }

        //This function is used to hide application login form 
        private void hiddenBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        // This function is used to check exist of account and role of account
        public void checkAccount(string account, string password) {
            foreach(DataRow row in tableAccount.Rows) {
                //Looking for each row if it's exactly an account loging in to this system 
                if (account == row[0].ToString() && password == row[1].ToString()) 
                    isLogin = true; // This account is available

                //If this account logged in 
                if (isLogin) {
                    //Set information of user
                    this.account = new DTO_Account(account, password, DateTime.Parse(row[2].ToString()), row[3].ToString());
                    string employeeId = row[4].ToString();
                    user = new DTO_Employee(employeeId); 
                    this.busUser = new BUS_Employee(user);
                    DataTable dataThisUser = busUser.showEmployee();
                    DataRow datarow = dataThisUser.Rows[0];
                    string id = datarow[0].ToString();
                    string fullname = datarow[1].ToString();
                    float salaryCoefficient= float.Parse(datarow[2].ToString());
                    int dayOffLeft = int.Parse(datarow[3].ToString());
                    DateTime dateOfBirth = DateTime.Parse(datarow[4].ToString());
                    string phoneNumber = datarow[5].ToString();
                    string email =datarow[6].ToString();
                    DateTime hireDate = DateTime.Parse(datarow[7].ToString());
                    user = new DTO_Employee(id, fullname, salaryCoefficient, dayOffLeft, dateOfBirth, phoneNumber, email, hireDate);
                    busUser = new BUS_Employee(user);
                    Account.setUser(busUser);

                    //Set information of user's account 
                    DateTime dateCreated = DateTime.Parse(row[2].ToString());
                    string role = row[3].ToString();
                    Account.setAccount(new BUS_Account(this.account));
                    Account.getAccount().updateAccount();
                    break; 
                }
            }
        }
        

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                loginBtn_Click(sender, e);
            }
        }

        //This function is used to log in when button is clicked
        private void loginBtn_Click(object sender, EventArgs e) {
            string account = usernameTextBox.Texts;
            string password = passwordTextBox.Texts;
            checkAccount(account, password); // Check account 
            
            if (isLogin) {
                //Log in if account exists
                MainForm.isLogout = false;
                this.Close();
            }
            else {
                // alert happens when account does not exist
                alert.Visible = true;
            }
            return;
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                loginBtn_Click(sender, e);
            }
        }
    }
}
