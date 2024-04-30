using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BUS;


namespace Final_Exam {
    public partial class DangNhapForm : Form {
        //Properties 
        BUS_Account bus_Account;
        DataTable tableAccount; 
        public static bool isLogin = false;

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

        public DangNhapForm() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            matKhauTextBox.PasswordChar = true;
            bus_Account = new BUS_Account("", "", DateTime.Now, DateTime.Now, "", "", "", "");
            tableAccount = bus_Account.showAccounts();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            MainForm.isLogout = false;
            this.Close();
        }

        private void hiddenBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        public void kiemTraTaiKhoan(string account, string password) {
            foreach(DataRow row in tableAccount.Rows) {
                if (account == row[0].ToString() && password == row[1].ToString()) isLogin = true;
                if (isLogin) {
                    DateTime lastLoginDate = DateTime.Now;
                    DateTime dateCreated = DateTime.Parse(row[7].ToString());
                    string role = row[2].ToString();
                    string email = row[3].ToString();
                    string numberphone = row[4].ToString();
                    string name = row[5].ToString();
                    Account.account = new BUS_Account(account, password,dateCreated,lastLoginDate,role,email,numberphone,name);
                    Account.account.updateAccount();
                    break; 
                }
            }
        }
        
        private void dangNhapBtn_Click(object sender, EventArgs e) {
            string account = taiKhoanTextBox.Texts;
            string password = matKhauTextBox.Texts;
            kiemTraTaiKhoan(account, password);
            if (isLogin) {
                MainForm.isLogout = false;
                this.Close();
            }
            else {
                alert.Visible = true;
            }
            return;
        }

        private void matKhauTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)Keys.Enter) {
                e.Handled = true;
                dangNhapBtn_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void DangNhapForm_Load(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}
