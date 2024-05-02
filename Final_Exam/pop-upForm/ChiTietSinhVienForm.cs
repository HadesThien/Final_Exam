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
using Final_Exam.pop_upForm;

namespace Final_Exam {
    public partial class ChiTietSinhVienForm : Form {

        private BUS_Student student;
        private BUS_Register register;
        private BUS_Payment payment;
        private BUS_Buy buy;
        private QuanLySinhVienForm form;
        private string id;
        private DataTable dt;

        public ChiTietSinhVienForm(QuanLySinhVienForm form, string id) {
            InitializeComponent();
            this.id = id;
            this.form = form;
            student = new BUS_Student(id, "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            register = new BUS_Register(id, "", DateTime.Now);
            payment = new BUS_Payment("", DateTime.Now, DateTime.Now, "", "", 0.0f, 0, id);
            buy = new BUS_Buy(DateTime.Now, 0, 0, "", DateTime.Now, "", "", id, "");
            dt = student.selectAllPayment();
            dt.Columns[0].ColumnName = "Mã";
            dt.Columns[1].ColumnName = "Tên thu phí";
            dt.Columns[2].ColumnName = "Kỳ thanh toán";
            dt.Columns[3].ColumnName = "Trạng thái";
            dt.Columns[4].ColumnName = "Ghi chú";
            dt.Columns[5].ColumnName = "Ngày thanh toán";
            paymentGridView.DataSource = dt;
        }


        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
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
            if (tinhTrangLabel.Text == "Thôi học") tinhTrangLabel.ForeColor = Color.Red; else tinhTrangLabel.ForeColor = Color.FromArgb(0, 192, 0);
            ghiChuLabel.Text = dt.Rows[0][12].ToString();
            schoolLabel.Text = dt.Rows[0][5].ToString();
        }

        private void ChiTietSinhVienForm_Load(object sender, EventArgs e)
        {
            if(Account.account.getRole() != "admin") removeBtn.Enabled = false;
            update();
        }
        //Thôi học 
        private void nhapHocBtn_Click(object sender, EventArgs e) {
            setStatus("Đang học", sender, e);
        }
        //Nhập học
        private void thoiHocBtn_Click(object sender, EventArgs e) {
            setStatus("Thôi học",sender,e);
        }
        public void setStatus(string status,object sender, EventArgs e) {
            string studentId = maHocVienLabel.Text;
            student = new BUS_Student(studentId,"","",DateTime.Now,"","","","","","",DateTime.Now,status,"");
            if(MessageBox.Show("Bạn muốn đổi tình trạng của học sinh này ?","Chuyển tình trạng học sinh", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                student.updateStatus();
            ChiTietSinhVienForm_Load(sender,e);
        }

        private void removeBtn_Click(object sender, EventArgs e) {
            Form form = new ConfirmForm();
            form.ShowDialog();
            if (Account.confirmPassword == true)
            {
                register.deleteAStudentFromAllClasses();
                payment.deletePaymentsOfAStudent();
                buy.deleteFromAStudent();
                student.deleteQuery();
            }
            Account.confirmPassword = false;
            this.form.updateGridView(student.basicSelectQuery());
            this.Close();
        }
    }
}
