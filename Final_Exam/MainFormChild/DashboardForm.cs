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

namespace Final_Exam {
    public partial class DashboardForm : Form {
        BUS_Student student;
        BUS_Payment payment;
        DataTable dt;
        public DashboardForm() {
            InitializeComponent();
        }


        private void DashboardForm_Load(object sender, EventArgs e) {
            student = new BUS_Student("","","",DateTime.Now,"","","","","","",DateTime.Now,"","");
            dt = student.select5NewStudent();
            studentGridView.DataSource = dt;
            dt = student.select5BirthDayStudent();
            studentHaveBirthDayInMonthGridView.DataSource = dt;
            payment = new BUS_Payment("",DateTime.Now,DateTime.Now, "","",0,0,"","");
            dt = payment.get5newPayment();
            newPaymentGridView.DataSource = dt;
            amountStudentinMonth.Text = student.numOfNewStudents();
            studentsHaveBirhtdayinMonth.Text = student.numOfStudentsBirthday();
            revenueInMonth.Text = payment.paidRevenue();
            debtInMonth.Text = payment.registeredRevenue();
            dt = payment.get5Debt();
            debtGridView.DataSource = dt;

        }

        private void dashboardLabel_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e) {

        }
    }

}
