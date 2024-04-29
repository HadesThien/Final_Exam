using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Final_Exam {
    public partial class ChiTietSinhVienForm : Form {

        private BUS_Student student;
        private string id;
        private DataTable dt;

        public ChiTietSinhVienForm(string id) {
            InitializeComponent();
            this.id = id;
            student = new BUS_Student(id, "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            dt = student.selectAllPayment();
            dt.Columns[0].ColumnName = "Mã";
            dt.Columns[1].ColumnName = "Tên thu phí";
            dt.Columns[2].ColumnName = "Kỳ thanh toán";
            dt.Columns[3].ColumnName = "Trạng thái";
            dt.Columns[4].ColumnName = "Ghi chú";
            dt.Columns[5].ColumnName = "Ngày thanh toán";
            paymentGridView.DataSource = dt;
        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void update()
        {
            student = new BUS_Student(this.id, "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            dt = student.findStudentDetailed();         
            maHocVienLabel.Text = dt.Rows[0][0].ToString();
            hoTenLabel.Text = dt.Rows[0][1].ToString();
            gioiTinhLabel.Text = dt.Rows[0][2].ToString();
            ngaySinhLabel.Text = dt.Rows[0][3].ToString().Split(' ')[0];
            soDienThoaiLabel.Text = dt.Rows[0][4].ToString();
            addressLabel.Text = dt.Rows[0][6].ToString() + ", " + dt.Rows[0][7].ToString() + ", " + dt.Rows[0][8].ToString() + ", " + dt.Rows[0][9].ToString();
            ngayTaoLabel.Text = dt.Rows[0][10].ToString().Split(' ')[0];
            tinhTrangLabel.Text = dt.Rows[0][11].ToString();
            ghiChuLabel.Text = dt.Rows[0][12].ToString();
            schoolLabel.Text = dt.Rows[0][5].ToString();
        }

        private void ChiTietSinhVienForm_Load(object sender, EventArgs e)
        {
            update();
        }
        //Thôi học 
        private void nhapHocBtn_Click(object sender, EventArgs e) {

        }
        //Nhập học
        private void thoiHocBtn_Click(object sender, EventArgs e) {

        }
    }
}
