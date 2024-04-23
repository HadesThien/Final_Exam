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


namespace Final_Exam {
    public partial class DangNhapForm : Form {
        //Properties 
        string account = "admin";
        string password = "123";



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
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void hiddenBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool kiemTraTaiKhoan(string account, string password) {
            if (account == this.account && password == this.password) {
                return true;
            }
            return false;
        }
        
        private void dangNhapBtn_Click(object sender, EventArgs e) {
            string account = taiKhoanTextBox.Texts;
            string password = matKhauTextBox.Texts;
            if (kiemTraTaiKhoan(account, password)) {
                MainForm form = new MainForm();
                form.ShowDialog();
                this.WindowState = FormWindowState.Minimized;
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
    }
}
