using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQH_Application.pop_upForm {
    public partial class ConfirmForm : Form {
        string confirm = "123";
        public ConfirmForm() {
            InitializeComponent();
            passwordTextBox.PasswordChar = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            if (passwordTextBox.Texts == confirm) {
                Account.access();
                this.Close();
            }
            else alert.Visible = true;
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                saveBtn_Click(sender, e);   
            }
        }
    }
}
