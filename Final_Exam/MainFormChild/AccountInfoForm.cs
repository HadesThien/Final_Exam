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
        public AccountInfoForm() {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e) {
            Form form = new RegisterAccountForm();
            form.ShowDialog();
        }
    }
}
