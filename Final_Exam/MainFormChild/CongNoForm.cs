using BUS;
using NQH_Application.pop_upForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQH_Application{
    public partial class CongNoForm : Form {
        //Properties 
        DataTable dt;

        //Constructor
        public CongNoForm() {
            InitializeComponent();
        }
        private void CongNoForm_Load(object sender, EventArgs e) {
            updateGridView();
        }

        public void updateGridView()
        {
        }

        private void tatcaBtn_Click(object sender, EventArgs e) {
            updateGridView();
        }

        private void registeredBtn_Click(object sender, EventArgs e) {
        }

        private void paidBtn_Click(object sender, EventArgs e) {
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            searchTextBox.Visible = true;
        }

        private void createBtn_Click(object sender, EventArgs e) {
            Form form = new ThanhToanForm(this);
            form.ShowDialog();
        }

        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            xoaBtn.Visible = true;
        }

        private void xoaBtn_Click(object sender, EventArgs e) {
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void paymentGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (paymentGridView.Columns[e.ColumnIndex].Name == "Tình trạng") {
                string statusValue = paymentGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (statusValue == "Đăng ký") e.CellStyle.ForeColor = Color.Red;
                else e.CellStyle.ForeColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void paymentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool areSelectedRegistered()
        {
            foreach (DataGridViewRow row in  paymentGridView.SelectedRows)
            {
                if (row.Cells[5].Value.ToString() == "Thanh toán")
                {
                    return false;
                }
            }
            return true;
        }

        private void paymentGridView_SelectionChanged(object sender, EventArgs e)
        {
            if ((paymentGridView.SelectedRows.Count > 0 && Account.getAccount().getRole() == "admin") || (paymentGridView.SelectedRows.Count > 0 && areSelectedRegistered() == true))
            {
                xoaBtn.Visible = true; 
            }
            else
            {
                xoaBtn.Visible = false;
            }
        }

        private void CongNoForm_Shown(object sender, EventArgs e)
        {
            xoaBtn.Visible = false;
        }

        private void thanhToanBtn_Click(object sender, EventArgs e)
        {

        }

        private void paymentGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

     }
}
