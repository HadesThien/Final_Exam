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

namespace Final_Exam
{
    public partial class LophocForm : Form
    {
        //Properties 
        BUS_Class classes;
        DataTable dt;
        private DataTable originalData = new DataTable();

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
            Form form = new TaoLopForm(this);
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

        public void updateGridView(string status)
        {
            classes = new BUS_Class("", "", "", 0, 0, 0, 0, DateTime.Now, status, "");
            if (status.Equals(""))
            {
                dt = classes.basicSelectQuery();
            }
            else
            {
                dt = classes.selectOptionalClass();
            }
            dt.Columns[0].ColumnName = "Tên lớp";
            dt.Columns[1].ColumnName = "Số buổi ";
            dt.Columns[2].ColumnName = "Số học sinh";
            dt.Columns[3].ColumnName = "Học phí";
            dt.Columns[4].ColumnName = "Ngày tạo";
            originalData = dt;
            classGridView.DataSource = dt;
        }

        private void tatcaBtn_Click(object sender, EventArgs e) {
            updateGridView("");
        }

        private void daDongBtn_Click(object sender, EventArgs e) {
            updateGridView("Đã đóng");
        }

        private void dangMoBtn_Click(object sender, EventArgs e) {
            updateGridView("Đang mở");
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            Form form = new TaoLopForm(classGridView.SelectedCells[0].Value.ToString(), this);
            form.ShowDialog();

        }

        private void classGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (colIndex == 0 && rowIndex != -1) {
                Form form = new ChiTietLopHocForm(classGridView.Rows[rowIndex].Cells[0].Value.ToString(), this);
                form.ShowDialog();
            }
        }


        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter) {
                Console.WriteLine("hello");
                string searchValue = searchTextBox.Text;
                if (!string.IsNullOrEmpty(searchValue))
                {
                    updateGridView("");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Tên lớp học");
                    dt.Columns.Add("Số buổi");
                    dt.Columns.Add("Số học sinh");
                    dt.Columns.Add("Học phí");
                    dt.Columns.Add("Ngày tạo");
                    for (int i = 0; i < classGridView.Rows.Count; i++)
                    {
                        string s = classGridView.Rows[i].Cells[0].Value.ToString();
                        if (s.IndexOf(searchValue, 0, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            DataRow dr = dt.NewRow();
                            foreach(DataGridViewCell cell in classGridView.Rows[i].Cells)
                            {
                                dr[cell.ColumnIndex] = cell.Value;
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                    classGridView.DataSource = dt;
                }
                else
                {
                    updateGridView("");
                }
           }
        }


        public void showSearchedClass(string name)
        {
          
        }
    }
}
