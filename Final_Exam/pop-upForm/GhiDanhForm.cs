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
using BUS_VN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BUS;
using System.Windows.Forms.VisualStyles;

namespace Final_Exam {
    public partial class ghiDanhForm : Form {
        //Properties

        private BUS_Address address;
        private BUS_Student student;
        private BUS_Class bus_class;
        private BUS_Register register;
        private QuanLySinhVienForm svForm;
        private string id;

        //Constructor 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
                (
                    int nLeftRect,     // x-coordinate of upper-left corner
                    int nTopRect,      // y-coordinate of upper-left corner
                    int nRightRect,    // x-coordinate of lower-right corner
                    int nBottomRect,   // y-coordinate of lower-right corner
                    int nWidthEllipse, // width of ellipse
                    int nHeightEllipse // height of ellipse
                );

        public ghiDanhForm(QuanLySinhVienForm svForm) {
            InitializeComponent();
            this.svForm = svForm;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

   
        private void defaultForm()
        {
            districtComboBox.Enabled = false;
            wardComboBox.Enabled = false;

            address = new BUS_Address("", "", "");
            DataTable dt = address.selectCities();
            cityComboBox.DataSource = dt;
            cityComboBox.ValueMember = "full_name";
        }

        private void GhiDanhForm_Load(object sender, EventArgs e) {
            defaultForm();
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            bus_class = new BUS_Class("", "", "", 0, 0, 0, 0, DateTime.Now,"Đang mở", "");
            foreach (DataRow row in bus_class.getNames().Rows)
            {
                classListBox.Items.Add(row[0].ToString());
            }
            id = student.getId();
            idLabel.Text = student.getId();
            classTextBox.Visible = false;
            buttonSelect.Visible = false;
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            classListBox.Visible = !classListBox.Visible;
        }

        private void cityComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cityComboBox.SelectedItem;
            string valueOfItem = drv["full_name"].ToString();

            address = new BUS_Address(valueOfItem, "", "");

            DataTable dt = address.selectDistricts();
            districtComboBox.DataSource = dt;
            districtComboBox.ValueMember = "full_name";

            districtComboBox.Enabled = true;
        }

        private void wardComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void disctrictComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)districtComboBox.SelectedItem;
            string valueOfItem = drv["full_name"].ToString();
            address = new BUS_Address("", valueOfItem, "");
            DataTable dt = address.selectWards();
            wardComboBox.DataSource = dt;
            wardComboBox.ValueMember = "full_name";

            wardComboBox.Enabled = true;
        }
        private void UpdateTextBoxValue() {
            StringBuilder selectedValues = new StringBuilder();
            for (int i = 0; i < classListBox.CheckedItems.Count; i++) {
                selectedValues.Append(classListBox.CheckedItems[i].ToString() + " ");
                Console.WriteLine(classListBox.CheckedItems[i].ToString());
            }
            classTextBox.Texts = selectedValues.ToString().Trim(); 
        }

        private void classListBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            string selectedItem = classListBox.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked) {
                if (classTextBox.Texts.Equals(""))
                {
                    classTextBox.Texts += selectedItem;
                }
                if (!classTextBox.Texts.Contains(selectedItem)) {
                    classTextBox.Texts += ", " + selectedItem;
                }
            }
            else 
            {
                int index = classTextBox.Texts.IndexOf(selectedItem);
                if (index + selectedItem.Length < classTextBox.Texts.Length && classTextBox.Texts[index + selectedItem.Length] == ',')
                {
                    classTextBox.Texts = classTextBox.Texts.Replace(selectedItem + ", ", "");
                }
                else if (index - 1 > 0 && classTextBox.Texts[index - 1] == ' ')
                {
                    classTextBox.Texts = classTextBox.Texts.Replace(", " + selectedItem, "");
                }
                else
                {
                    classTextBox.Texts = classTextBox.Texts.Replace(selectedItem, "");
                }

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool flag = nameTextBox.Texts.Equals("") || diaChiTextBox.Texts.Equals("") || truongHocTextBox.Texts.Equals("") || genderComboBox.Texts.Equals("") || tinhTrangComboBox.Texts.Equals("") || numberPhoneTextBox.Texts.Equals("");
            if (flag)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin học sinh");
                return;
            }
            string[] classes = classTextBox.Texts.Split(new string[] { ", " }, StringSplitOptions.None);
            if (classes.Length > 4) {
                MessageBox.Show("Chỉ có thể đăng ký từ 0-4 lớp");
            }
            List<string> subjects = new List<string>();
            List<string> shifts = new List<string>();
            List<int> grades = new List<int>();
            foreach (string s in classes)
            {
                string[] list = s.Split(' ');
                subjects.Add(list[0]);
                string[] list1 = list[1].Split('.');
                shifts.Add(list1[1]);
                grades.Add(int.Parse(list1[0]));
            }
            foreach (string s in subjects)
            {
                Console.WriteLine(s);
            }
            foreach (string s in shifts)
            {
                Console.WriteLine(s);
            }
            foreach (int s in grades)
            {
                Console.WriteLine(s);
            }
            // Tình trạng trong ghi danh Form là để cho người dùng hiểu
            // Thực tế có 3 tình trạng chính là Nếu học sinh nhập học thì tình trạng  là "Đang học" 
            // Nếu Ô tình trạng là mặc định là "Mặc định" thì tình trạng là "Thôi học" tức chỉ những học sinh không có học tại trung tâm
            // Nếu tình trạng là học thử thì vẫn là như vậy nhưng không có nút chuyển tình trạng thành học thử.
            string status = tinhTrangComboBox.Texts;

            if (status == "Mặc định") status = "Thôi học"; else if (status == "Nhập học") status = "Đang học";
            student = new BUS_Student(id, nameTextBox.Texts, genderComboBox.Texts, dobTimePicker.Value, numberPhoneTextBox.Texts, truongHocTextBox.Texts, diaChiTextBox.Texts, wardComboBox.Texts, districtComboBox.Texts, cityComboBox.Texts, DateTime.Now, status, ghiChuTextBox.Text);
            student.addQuery();
            List<string> ids = new List<string>();
            for (int i = 0; i < subjects.Count; i++)
            {
                bus_class = new BUS_Class("", subjects[i], shifts[i], grades[i], 0, 0, 0, DateTime.Now,"Đang mở", "");
                ids.Add(bus_class.getClassId());
            }
            foreach (string s in ids)
            {
                register = new BUS_Register(id, s, DateTime.Now);
                register.addQuery();
            }
            svForm.updateGridView(student.basicSelectQuery());
            this.Close();
        }

        private void tinhTrangComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string valueOfItem = tinhTrangComboBox.SelectedItem.ToString();
            if (valueOfItem.Equals("Nhập học") || valueOfItem.Equals("Học thử")) {
                classTextBox.Visible = true;
                buttonSelect.Visible = true;
            }
            else {
                classTextBox.Visible = false;
                buttonSelect.Visible =false;
            }
        }

        private void classListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
