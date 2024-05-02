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

namespace Final_Exam
{
    public partial class LophocForm : Form
    {
        //Properties 
        BUS_Class classes;
        DataTable dt; 

        //Constructor
        public LophocForm()
        {
            InitializeComponent();
        }

        private void LophocForm_Load(object sender, EventArgs e)
        {
            tatcaBtn_Click(sender, e);
            if (Account.account.getRole() != "admin") {
                createBtn.Visible = false;
                updateBtn.Visible = false;
            }
        }


        private void searchBtn_Click(object sender, EventArgs e) {
            searchTextBox.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void filterBtn_Click(object sender, EventArgs e) {

        }

        private void settingBtn_Click(object sender, EventArgs e) {

        }

        private void createBtn_Click(object sender, EventArgs e) {
            Form form = new TaoLopForm();
            form.ShowDialog();
        }

        private void classGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            //Chỉ khi là admin thì nút này mới hiện lên 
            if(Account.account.getRole() == "admin") updateBtn.Visible = true;

        }

        private void classGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                // Kiểm tra nếu không phải hàng đầu tiên và không phải là cột tiêu đề
                if (e.ColumnIndex >= 0 && classGridView.Columns[e.ColumnIndex].HeaderText != "") {
                    // Kiểm tra nếu ô đầu tiên trong hàng
                    if (e.ColumnIndex == 0) {
                        e.CellStyle.Font = new Font(classGridView.Font, FontStyle.Bold | FontStyle.Underline);
                        e.CellStyle.ForeColor = Color.MediumSeaGreen;
                    }
                }
            }
        }

        private void tatcaBtn_Click(object sender, EventArgs e) {
            classes = new BUS_Class("", "", "", 0, 0, 0, 0, DateTime.Now,"", "");
            dt = classes.basicSelectQuery();
            dt.Columns[0].ColumnName = "Tên lớp";
            dt.Columns[1].ColumnName = "Số buổi ";
            dt.Columns[2].ColumnName = "Số học sinh";
            dt.Columns[3].ColumnName = "Học phí";
            dt.Columns[4].ColumnName = "Ngày tạo";
            classGridView.DataSource = dt;
        }

        private void daDongBtn_Click(object sender, EventArgs e) {

        }

        private void dangMoBtn_Click(object sender, EventArgs e) {

        }
    }
}
