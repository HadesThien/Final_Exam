using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Excel = Microsoft.Office.Interop.Excel;

namespace Final_Exam {
    public partial class QuanLySinhVienForm : Form{
        private BUS_Student student;
        public QuanLySinhVienForm() {
            InitializeComponent();
        }

        public void updateGridView(DataTable data)
        {
            DataTable dt = data;
            dt.Columns[0].ColumnName = "Mã học sinh";
            dt.Columns[1].ColumnName = "Tên học sinh";
            dt.Columns[2].ColumnName = "Số điện thoại";
            dt.Columns[3].ColumnName = "Ngày sinh";
            dt.Columns[4].ColumnName = "Giới tính";
            dt.Columns[5].ColumnName = "Ngày tạo";
            studentGridView.DataSource = dt;
            foreach (DataGridViewColumn col in studentGridView.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            searchTextBox.Visible = true;
        }

        private void tatcaBtn_Click(object sender, EventArgs e) {
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            updateGridView(student.basicSelectQuery());
        }

        private void danghocBtn_Click(object sender, EventArgs e) {
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            updateGridView(student.basicSelectQueryOfficial());
        }

        private void hocthuBtn_Click(object sender, EventArgs e) {
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            updateGridView(student.basicSelectQueryTrial());
        }

        private void createBtn_Click(object sender, EventArgs e) {
            Form GhiDanhForm = new ghiDanhForm(this);
            GhiDanhForm.ShowDialog();
        }

        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            adjustBtn.Visible = true;
            int index = e.RowIndex;
            if(index == 0) {

            }
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if(colIndex==0 && rowIndex != -1) { Form chiTietSinhVien = new ChiTietSinhVienForm(studentGridView.Rows[rowIndex].Cells[0].Value.ToString()); chiTietSinhVien.ShowDialog(); }

        }

        private void QuanLySinhVienForm_Load(object sender, EventArgs e) {
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            updateGridView(student.basicSelectQuery());
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
        private void copyAlltoClipboard() {
            studentGridView.SelectAll();
            DataObject dataObj = studentGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void printBtn_Click(object sender, EventArgs e) {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void thoihocBtn_Click(object sender, EventArgs e)
        {
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            updateGridView(student.basicSelectQueryDropout());
        }

        private void adjustBtn_Click(object sender, EventArgs e)
        {
            int row = studentGridView.CurrentCell.RowIndex;
            Form GhiDanhForm = new ghiDanhForm(this, studentGridView.Rows[row].Cells[0].Value.ToString());
            GhiDanhForm.ShowDialog();
        }
    }

}
