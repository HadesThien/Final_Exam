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
    public partial class ChiTietLopHocForm : Form {
        //Properties
        BUS_Class classes;
        BUS_Teacher teacher;
        string teacherId;
        string classId;
        string className;
        DataTable dt;
        LophocForm form;
        //Constructor
        public ChiTietLopHocForm(string className, LophocForm form) {
            InitializeComponent();
            this.form = form;
            this.className = className;
            string[] parts = className.Split(' ');
            string subject = parts[0];
            parts = parts[1].Split('.');
            string grade = parts[0];
            string shift = parts[1];    
            classes = new BUS_Class("", subject, shift, int.Parse(grade), 0, 0, 0, DateTime.Now, "", "");
            classId = classes.getClassId();
            classes = new BUS_Class(classId, subject, shift, int.Parse(grade), 0, 0, 0, DateTime.Now, "", "");
            dt = classes.getClass();
            int price = int.Parse(dt.Rows[0][4].ToString());
            int n_Session = int.Parse(dt.Rows[0][5].ToString());
            int n_Student = int.Parse(dt.Rows[0][6].ToString());
            DateTime dateCreated = DateTime.Parse(dt.Rows[0][7].ToString());
            string status = dt.Rows[0][9].ToString();
            teacherId = dt.Rows[0][8].ToString();
            classes = new BUS_Class(classId, subject, shift, int.Parse(grade), price, n_Session, n_Student, dateCreated, status, teacherId);
        }

        private void ChiTietLopHocForm_Load(object sender, EventArgs e) {
            subjedtLabel.Text = classes.getSubject();
            classNameLabel.Text = classes.getName();
            shiftLabel.Text = classes.getShift();
            gradeLabel.Text = classes.getGrade().ToString();
            priceLabel.Text = classes.getPrice().ToString();
            numberOfSessionLabel.Text = classes.getNumberOfSession().ToString();
            numberOfStudentLabel.Text = classes.getNumberOfStudent().ToString();
            statusLabel.Text = classes.getStatus();
            teacher = new BUS_Teacher(teacherId,"","",DateTime.Now,"","");
            teacherLabel.Text = teacher.getTeacherName();
            if (statusLabel.Text == "Đang mở") statusLabel.ForeColor = Color.FromArgb(0, 171, 48); else statusLabel.ForeColor = Color.Red;


            //Show gridview 
            dt = classes.getRegisteredStudent();
            dt.Columns[0].ColumnName = "Mã học sinh";
            dt.Columns[1].ColumnName = "Họ và tên";
            dt.Columns[2].ColumnName = "Giới tính";
            dt.Columns[3].ColumnName = "Ngày sinh";
            dt.Columns[4].ColumnName = "Số điện thoại";
            dt.Columns[5].ColumnName = "Chú thích";
            dt.Columns[6].ColumnName = "Ngày tạo";
            classGridView.DataSource = dt;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Bạn có muốn xóa lớp ?", "Xóa lớp học vĩnh viễn", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) {
                Form form = new ConfirmForm();
                form.ShowDialog();
                if(Account.confirmPassword == true) {
                    classes = new BUS_Class(classId, "", "", 0, 0, 0, 0, DateTime.Now, "", "");
                    classes.deleteQuery();
                    Account.confirmPassword = false;
                    ChiTietLopHocForm_Load(sender, e);
                }
            }
            form.updateGridView("");
            this.Close();
        }
    }
}
