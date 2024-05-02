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
    public partial class CongNoForm : Form {
        //Properties 
        BUS_Payment payment;
        DataTable dt;

        //Constructor
        public CongNoForm() {
            InitializeComponent();
        }
        private void CongNoForm_Load(object sender, EventArgs e) {
            payment = new BUS_Payment("", DateTime.Now, DateTime.Now, "", "", 0, 0, "");
            dt = payment.selectQuery();
            paymentGridView.DataSource = dt;
        }

        private void tatcaBtn_Click(object sender, EventArgs e) {

        }

        private void registeredBtn_Click(object sender, EventArgs e) {

        }

        private void paidBtn_Click(object sender, EventArgs e) {

        }

        private void searchBtn_Click(object sender, EventArgs e) {
            searchTextBox.Visible = true;
        }

        private void createBtn_Click(object sender, EventArgs e) {
            Form form = new TaoCongNoForm();
            form.ShowDialog();
        }

        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            xoaBtn.Visible = true;
        }

        private void xoaBtn_Click(object sender, EventArgs e) {
            Form confirmForm = new ConfirmForm();
            confirmForm.ShowDialog();
        }
    }
}
