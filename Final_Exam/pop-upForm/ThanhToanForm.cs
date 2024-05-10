using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BUS;
using System.Drawing.Text;
using System.Diagnostics;
using DataGridViewNumericUpDownElements;
using System.DirectoryServices.ActiveDirectory;

namespace Final_Exam {
    public partial class ThanhToanForm : Form
    {
        //Properties
        private List<string> danhSachHocSinh = new List<string>();
        private List<string> danhSachLopHoc = new List<string>();

        private BUS_Student student;
        private DataTable thanhToanTable;

        private List<string> subjects;
        private List<string> shifts;
        private List<int> grades;

        private int tempCheckout = 0;
        private int checkout = 0;
        //Constructor
        public ThanhToanForm()
        {
            InitializeComponent();
            updateStudentListBox();
            label12.Visible = false;
            documentCheckedListBox.Visible = false;
        }

        public ThanhToanForm(bool flag)
        {
            InitializeComponent();
            cancelBtn.Location = saveBtn.Location;
            saveBtn.Visible = false;
            studentListBox.Visible = true;
            cancelBtn.Visible = false;
        }

        private void updateStudentListBox()
        {
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            studentListBox.Items.Clear();
            foreach (DataRow drv in student.getIdAndName().Rows)
            {
                studentListBox.Items.Add(drv[0].ToString());
            }
        }

        private List<string> FindRelatedStudents(string searchText)
        {
            List<string> relatedStudents = new List<string>();
            foreach (string student in danhSachHocSinh)
            {
                if (student.Contains(searchText))
                {
                    relatedStudents.Add(student);
                }
            }
            return relatedStudents;
        }


        private void searchClassTextBox__TextChanged(object sender, EventArgs e)
        {
        }

        private List<string> FindRelatedClasses(string searchText)
        {
            List<string> relatedClasses = new List<string>();
            foreach (string Class in danhSachLopHoc)
            {
                relatedClasses.Add(Class);
            }
            return relatedClasses;
        }

        private void searchStudentTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchStudentTextBox.Text;
            List<string> relatedStudents = FindRelatedStudents(searchText);
            foreach (string student in relatedStudents)
            {
            }

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = studentListBox.SelectedItem.ToString();
            searchStudentTextBox.Text = s;
            studentLabel.Text = s;
            string studentId = s.Split(new string[] { " - " }, StringSplitOptions.None)[0];

            for (int i = 0; i < classCheckedListBox.Items.Count; i++)
            {
                classCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            for (int i = 0; i < documentCheckedListBox.Items.Count; i++)
            {
                documentCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            BUS_Register register = new BUS_Register(studentId, "", DateTime.Now);
            DataTable dt = register.getClassNameFromAStudent();

            classCheckedListBox.DataSource = dt;
            classCheckedListBox.DisplayMember = "class";
        }

        private void searchStudentTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string s = searchStudentTextBox.Text;
                if (!string.IsNullOrEmpty(s))
                {
                    updateStudentListBox();
                    List<string> students = new List<string>();
                    for (int i = 0; i < studentListBox.Items.Count; i++)
                    {
                        if (studentListBox.Items[i].ToString().IndexOf(s, 0, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            students.Add(studentListBox.Items[i].ToString());
                        }
                    }
                    studentListBox.Items.Clear();
                    for (int i = 0; i < students.Count; i++)
                    {
                        studentListBox.Items.Add(students[i]);
                    }
                }
                else
                {
                    updateStudentListBox();
                }
            }
        }

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {
            BUS_Document document = new BUS_Document(0, "", "", DateTime.Now, DateTime.Now, 0);
            documentCheckedListBox.DataSource = document.getNames();
            updateStudentListBox();
            thanhToanTable = new DataTable();
            documentCheckedListBox.DisplayMember = "name";
            thanhToanTable.Columns.Add("Tên thanh toán");
            thanhToanTable.Columns.Add("Loại");
            thanhToanTable.Columns.Add("Giá");
            thanhToanTable.Columns.Add("Kỳ");
            roundedGridView1.DataSource = thanhToanTable;
            roundedGridView1.Columns[0].ReadOnly = true;
            roundedGridView1.Columns[1].ReadOnly = true;
            roundedGridView1.Columns[2].ReadOnly = true;
            roundedGridView1.Columns[3].ReadOnly = true;
            DataGridViewNumericUpDownColumn dgv_nud = new DataGridViewNumericUpDownColumn();
            dgv_nud.Name = "Số buổi / số lượng";
            dgv_nud.Minimum = 1;
            dgv_nud.Maximum = 12;
            roundedGridView1.Columns.Add(dgv_nud);
        }

        private void updateGridView()
        {
        }

        public void updateThanhToanTable()
        {
            //thanhToanTable = new DataTable();
            //thanhToanTable.Columns.Add("Tên thanh toán");
            //thanhToanTable.Columns.Add("Loại");
            //thanhToanTable.Columns.Add("Giá");
            //thanhToanTable.Columns.Add("Kỳ");
            //subject = new List<string>();
            //shift = new List<string>();
            //grade = new List<int>();
            //int tempCheckout = 0;
            //int checkout = 0;
            //foreach (var s in classCheckedListBox.CheckedItems)
            //{
            //    DataRowView drv = (DataRowView)s;
            //    string str = drv["class"].ToString();
            //    string[] arr = str.Split(new string[] { " " }, StringSplitOptions.None);
            //    subject.Add(arr[0]);
            //    shift.Add(arr[1].Split(new string[] { "." }, StringSplitOptions.None)[1]);
            //    grade.Add(int.Parse(arr[1].Split(new string[] { "." }, StringSplitOptions.None)[0]));
            //    BUS_Class bus_class = new BUS_Class("", subject[subject.Count - 1], shift[shift.Count - 1], grade[grade.Count - 1], 0, 0, 0, DateTime.Now, "", "");
            //    bus_class = new BUS_Class(bus_class.getClassId(), subject[subject.Count - 1], shift[shift.Count - 1], grade[grade.Count - 1], 0, 0, 0, DateTime.Now, "", "");
            //    thanhToanTable.Rows.Add(str, "Lớp", bus_class.getClass().Rows[0][4], DateTime.Now.ToString("MM/yyyy"));
            //    checkout += int.Parse(bus_class.getClass().Rows[0][4].ToString());
            //    tempCheckout += int.Parse(bus_class.getClass().Rows[0][4].ToString());
            //}
            //foreach (var s in documentCheckedListBox.CheckedItems)
            //{
            //    DataRowView drv = (DataRowView)s;
            //    string str = drv["name"].ToString();
            //    BUS_Document doc = new BUS_Document(0, "", str, DateTime.Now, DateTime.Now, 0);
            //    thanhToanTable.Rows.Add(str, "Tài liệu", doc.getDocumentFromName().Rows[0][5], DateTime.Now.ToString("MM/yyyy"));
            //    checkout += int.Parse(doc.getDocumentFromName().Rows[0][5].ToString());
            //    tempCheckout += int.Parse(doc.getDocumentFromName().Rows[0][5].ToString());
            //}

            //checkout = tempCheckout - int.Parse(promotionLabel.Text);
            //tempCheckoutLabel.Text = tempCheckout.ToString();
            //checkoutLabel.Text = checkout.ToString();
        }

        private void classCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void documentCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public int find(string s)
        {
            for (int i = 0; i < thanhToanTable.Rows.Count; i++)
            {
                if (s.Equals(thanhToanTable.Rows[i][0]))
                {
                    return i;
                }
            }
            return -1;
        }

        private void classCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //this.BeginInvoke(new Action(() =>
            //{
            //    updateThanhToanTable();
            //    updateGridView();
            //}));
            DataRowView drv = (DataRowView)classCheckedListBox.Items[e.Index];
            string s = drv["class"].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                string[] arr = s.Split(new string[] { " " }, StringSplitOptions.None);
                string subject = arr[0];
                string shift = arr[1].Split(new string[] { "." }, StringSplitOptions.None)[1];
                int grade = int.Parse(arr[1].Split(new string[] { "." }, StringSplitOptions.None)[0]);
                BUS_Class bus_class = new BUS_Class("", subject, shift, grade, 0, 0, 0, DateTime.Now, "", "");
                bus_class = new BUS_Class(bus_class.getClassId(), subject, shift, grade, 0, 0, 0, DateTime.Now, "", "");
                thanhToanTable.Rows.Add(s, "Lớp", bus_class.getClass().Rows[0][4], DateTime.Now.ToString("MM/yyyy"));
                int count = roundedGridView1.Rows.Count - 1;
                roundedGridView1.Rows[count].Cells[0].Value = (decimal)12;
                int n = (int)((decimal)roundedGridView1.Rows[count].Cells[0].Value);
                tempCheckout += (int)(int.Parse(bus_class.getClass().Rows[0][4].ToString()) * (n / 12.0f));
                updateGridView();
            }
            else
            {
                int index = find(s);
                tempCheckout -= int.Parse(thanhToanTable.Rows[index][2].ToString());
                thanhToanTable.Rows.RemoveAt(index);
                updateGridView();
            }
            tempCheckoutLabel.Text = tempCheckout.ToString();
            checkoutLabel.Text = (tempCheckout - int.Parse(promotionLabel.Text)).ToString();
        }

        private void documentCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //this.BeginInvoke(new Action(() =>
            //{
            //    updateThanhToanTable();
            //    updateGridView();
            //}));
            DataRowView drv = (DataRowView)documentCheckedListBox.Items[e.Index];
            string s = drv["name"].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                BUS_Document doc = new BUS_Document(0, "", s, DateTime.Now, DateTime.Now, 0);
                thanhToanTable.Rows.Add(s, "Tài liệu", doc.getDocumentFromName().Rows[0][5], DateTime.Now.ToString("MM/yyyy"));
                int count = roundedGridView1.Rows.Count - 1;
                roundedGridView1.Rows[count].Cells[0].Value = (decimal)1;
                roundedGridView1.Rows[count].Cells[0].ReadOnly = true;
                tempCheckout += int.Parse(doc.getDocumentFromName().Rows[0][5].ToString());
            }
            else
            {
                int index = find(s);
                tempCheckout -= int.Parse(thanhToanTable.Rows[index][2].ToString());
                thanhToanTable.Rows.RemoveAt(index);
                updateGridView();
            }
            tempCheckoutLabel.Text = tempCheckout.ToString();
            checkoutLabel.Text = (tempCheckout - int.Parse(promotionLabel.Text)).ToString();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
