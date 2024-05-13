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
            updateGridView();
        }

        public void updateGridView()
        {
            payment = new BUS_Payment("", DateTime.Now, DateTime.Now, "", "", 0, 0, "","");
            dt = payment.selectQuery();
            paymentGridView.DataSource = dt;
            paymentGridView.CellFormatting += paymentGridView_CellFormatting;            
        }

        private void tatcaBtn_Click(object sender, EventArgs e) {
            updateGridView();
        }

        private void registeredBtn_Click(object sender, EventArgs e) {
            payment = new BUS_Payment("", DateTime.Now, DateTime.Now, "", "", 0, 0, "","");
            dt = payment.selectRegisteredQuery();
            paymentGridView.DataSource = dt;
            paymentGridView.CellFormatting += paymentGridView_CellFormatting;            
            
        }

        private void paidBtn_Click(object sender, EventArgs e) {
            payment = new BUS_Payment("", DateTime.Now, DateTime.Now, "", "", 0, 0, "","");
            dt = payment.selectPaidQuery();
            paymentGridView.DataSource = dt;
            paymentGridView.CellFormatting += paymentGridView_CellFormatting;            
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
            Form confirmForm = new ConfirmForm();
            confirmForm.ShowDialog();
            if (Account.confirmPassword == true)
            {
                foreach (DataGridViewRow row in paymentGridView.SelectedRows)
                {
                    payment = new BUS_Payment(row.Cells[0].Value.ToString(), DateTime.Now, DateTime.Now, "", "", 0.0f, 0, "", "");
                    payment.deleteQuery();
                }
            }
            Account.confirmPassword = false;
            updateGridView();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter) {
                string searchValue = searchTextBox.Text;
                if (!string.IsNullOrEmpty(searchValue))
                {
                    updateGridView();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Mã thanh toán");
                    dt.Columns.Add("Tên học sinh");
                    dt.Columns.Add("Tên lớp");
                    dt.Columns.Add("Học phí");
                    dt.Columns.Add("Kỳ");
                    dt.Columns.Add("Tình trạng");
                    dt.Columns.Add("Số buổi học");
                    dt.Columns.Add("Ngày tạo");
                    for (int i = 0; i < paymentGridView.Rows.Count; i++)
                    {
                        string s = paymentGridView.Rows[i].Cells[1].Value.ToString();
                        if (s.IndexOf(searchValue, 0, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            DataRow dr = dt.NewRow();
                            foreach(DataGridViewCell cell in paymentGridView.Rows[i].Cells)
                            {
                                dr[cell.ColumnIndex] = cell.Value;
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                    paymentGridView.DataSource = dt;
                }
                else
                {
                    updateGridView();
                }
           }
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
            if ((paymentGridView.SelectedRows.Count > 0 && Account.account.getRole() == "admin") || (paymentGridView.SelectedRows.Count > 0 && areSelectedRegistered() == true))
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

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
