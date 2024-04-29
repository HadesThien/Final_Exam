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
            string newPassword = passwordTextbox.Texts;
            account.changePassword(newPassword);
            this.Close();
        }
    }
}
