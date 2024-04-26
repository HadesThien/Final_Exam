
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Final_Exam {
    public partial class QuanLySinhVienForm : Form{
        private BUS_Student student;
        public QuanLySinhVienForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        public void updateGridView()
        {
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "");
            DataTable dt = student.selectQuery();
            dt.Columns[0].ColumnName = "Mã học sinh";
            dt.Columns[1].ColumnName = "Tên học sinh";
            dt.Columns[2].ColumnName = "Số điện thoại";
            dt.Columns[3].ColumnName = "Lớp học";
            dt.Columns[4].ColumnName = "Ngày sinh";
            dt.Columns[5].ColumnName = "Giới tính";
            dt.Columns[6].ColumnName = "Ngày tạo";
            studentGridView.DataSource = dt;
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            searchTextBox.Visible = true;
        }

        private void tatcaBtn_Click(object sender, EventArgs e) {
            updateGridView();
        }

        private void danghocBtn_Click(object sender, EventArgs e) {

        }

        private void hocthuBtn_Click(object sender, EventArgs e) {

        }

        private void createBtn_Click(object sender, EventArgs e) {
            Form GhiDanhForm = new GhiDanhForm();
            GhiDanhForm.ShowDialog();
        }

        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            changeStatusBtn.Visible = true;
            int index = e.RowIndex;
            DataGridViewRow row = studentGridView.Rows[index];
            if(index == 0) {

            }
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int colIndex = e.ColumnIndex;
            if(colIndex==0) { Form chiTietSinhVien = new ChiTietSinhVienForm(); chiTietSinhVien.ShowDialog(); }

        }

        private void QuanLySinhVienForm_Load(object sender, EventArgs e) {

        }

        private void studentGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                // Kiểm tra nếu không phải hàng đầu tiên và không phải là cột tiêu đề
                if (e.ColumnIndex >= 0 && studentGridView.Columns[e.ColumnIndex].HeaderText != "") {
                    // Kiểm tra nếu ô đầu tiên trong hàng
                    if (e.ColumnIndex == 0) {
                        e.CellStyle.Font = new Font(studentGridView.Font, FontStyle.Bold | FontStyle.Underline);
                        e.CellStyle.ForeColor = Color.MediumSeaGreen;
                    }
                }
            }
        }
    }

}
