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


        //Contructors 
        public AccountInfoForm() {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e) {
            Form form = new RegisterAccountForm();
            form.ShowDialog();
        }

        private void changePwBtn_Click(object sender, EventArgs e) {
            Form form = new RegisterAccountForm();
            form.ShowDialog();
        }
        private void accountGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            changePwBtn.Visible = true;
            xoaBtn.Visible = true;
        }

        private void xoaBtn_Click(object sender, EventArgs e) {
            Form confirmForm = new ConfirmForm();
            confirmForm.ShowDialog();
        }

        private void AccountInfoForm_Load(object sender, EventArgs e) {
            account = new BUS_Account("", "",DateTime.Now,DateTime.Now,"","","","") ;
            accountGridView.DataSource = account.showAccounts();
            accountGridView.ClearSelection();
            
         }
    }
}
