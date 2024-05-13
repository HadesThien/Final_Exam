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
using System.Reflection.Emit;
using System.Data.Odbc;

namespace Final_Exam {
    public partial class ghiDanhForm : Form {
        //Properties

        private BUS_Address address;
        private BUS_Student student;
        private BUS_Class bus_class;
        private BUS_Register register;
        private QuanLySinhVienForm svForm;
        private string id;
        private string aId;

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
            classListBox.Enabled = false;
            this.svForm = svForm;
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            idLabel.Text = student.getId();
            id = student.getId();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }
        public ghiDanhForm(QuanLySinhVienForm form, string aId) {
            InitializeComponent();
            this.aId = aId;
            this.svForm = form;
            saveBtn.Text = "Cập nhật";
            label14.Text = "Mã học sinh cập nhật:";
            idLabel.Text = aId;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

   
        private void defaultForm()
        {
            address = new BUS_Address("", "", "");
            DataTable dt = address.selectCities();
            cityComboBox.DataSource = dt;
            cityComboBox.ValueMember = "full_name";
        }

        private int findStringExactCity(string str)
        {
            for (int i = 0; i < cityComboBox.Items.Count; i++)
            {
                string s = ((DataRowView)cityComboBox.Items[i])["full_name"].ToString();

                if (s.Equals(str))
                {
                    return i;
                }
            }
            return -1;
        }
        private int findStringExactDistrict(string str)
        {
            for (int i = 0; i < districtComboBox.Items.Count; i++)
            {
                string s = ((DataRowView)districtComboBox.Items[i])["full_name"].ToString();

                if (s.Equals(str))
                {
                    return i;
                }
            }
            return -1;
        }
        private int findStringExactWard(string str)
        {
            for (int i = 0; i < wardComboBox.Items.Count; i++)
            {
                string s = ((DataRowView)wardComboBox.Items[i])["full_name"].ToString();

                if (s.Equals(str))
                {
                    return i;
                }
            }
            return -1;
        }

        private void defaultForm1()
        {
            defaultForm();
            student = new BUS_Student(this.aId, "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            DataTable dt = student.findStudentDetailed();         
            nameTextBox.Texts = dt.Rows[0][1].ToString();
            genderComboBox.Texts = dt.Rows[0][2].ToString();
            dobTimePicker.Text = dt.Rows[0][3].ToString().Split(' ')[0];
            numberPhoneTextBox.Texts = dt.Rows[0][4].ToString();
            diaChiTextBox.Texts = dt.Rows[0][6].ToString();
            cityComboBox.SelectedIndex = findStringExactCity(dt.Rows[0][9].ToString());
            districtComboBox.SelectedIndex = findStringExactDistrict(dt.Rows[0][8].ToString());
            wardComboBox.SelectedIndex = findStringExactWard(dt.Rows[0][7].ToString());
            tinhTrangComboBox.Texts = dt.Rows[0][11].ToString();
            ghiChuTextBox.Text = dt.Rows[0][12].ToString();
            truongHocTextBox.Texts = dt.Rows[0][5].ToString();
            register = new BUS_Register(aId, "", DateTime.Now);
            tinhTrangComboBox.Enabled = false;
            if (tinhTrangComboBox.Texts.Equals("Nhập học") || tinhTrangComboBox.Texts.Equals("Học thử"))
            {
                classListBox.Enabled = true;
            } else
            {
                classListBox.Enabled = false;
            }
            List<string> classList = new List<string>();
            DataTable c = register.getClassesOfAStudent();

            foreach (DataRow row in c.Rows)
            {
                bus_class = new BUS_Class(row[0].ToString(), "", "", 0, 0, 0, 0, DateTime.Now, "", "");
                classList.Add(bus_class.getClassName());
            }

            classTextBox.Texts = "";
            for (int i = 0; i < classList.Count; i++)
            {
                if (i == classList.Count - 1)
                {
                    classTextBox.Texts += classList[i];
                }
                else
                {
                    classTextBox.Texts += classList[i] + ", ";
                }
            }

            if (classListBox.Enabled)
            {
                for (int i = 0; i < classListBox.Items.Count; i++)
                {
                    if (classList.Contains(classListBox.Items[i]))
                    {
                        classListBox.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
        }

        private void GhiDanhForm_Load(object sender, EventArgs e) {
            bus_class = new BUS_Class("", "", "", 0, 0, 0, 0, DateTime.Now, "Đang mở", "");
            foreach (DataRow row in bus_class.getNames().Rows)
            {
                classListBox.Items.Add(row[0].ToString());
            }
            if (string.IsNullOrEmpty(aId))
            {
                defaultForm();
            }
            else
            {
                defaultForm1();
            }
            if (tinhTrangComboBox.Texts == "Đang học") {
                classListBox.Enabled = true;
                classTextBox.Visible = true;
                buttonSelect.Visible = true;
            }
            else{
                classTextBox.Visible = false;
                buttonSelect.Visible = false;
            }
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
                return;
            }
            if (string.IsNullOrEmpty(id))
            {
                register = new BUS_Register(aId, "", DateTime.Now);
                DataTable c = register.getClassesOfAStudent();

                student = new BUS_Student(aId, nameTextBox.Texts, genderComboBox.Texts, dobTimePicker.Value, numberPhoneTextBox.Texts, truongHocTextBox.Texts, diaChiTextBox.Texts, wardComboBox.Texts, districtComboBox.Texts, cityComboBox.Texts, DateTime.Now, tinhTrangComboBox.Texts, ghiChuTextBox.Text);
                student.updateQuery();

                register.deleteAStudentFromAllClasses();
                Console.WriteLine("UPDATE");
            }
            else
            {
                string status = tinhTrangComboBox.Texts;
                if (status == "Nhập học") status = "Đang học";
                else if (status == "Tham khảo thông tin") status = "Thôi học";
                else status = "Học thử";
                student = new BUS_Student(id, nameTextBox.Texts, genderComboBox.Texts, dobTimePicker.Value, numberPhoneTextBox.Texts, truongHocTextBox.Texts, diaChiTextBox.Texts, wardComboBox.Texts, districtComboBox.Texts, cityComboBox.Texts, DateTime.Now, status, ghiChuTextBox.Text);
                student.addQuery();
            }
            List<string> subjects = new List<string>();
            List<string> shifts = new List<string>();
            List<int> grades = new List<int>();
            Console.WriteLine(classes.Length);
            Console.WriteLine(classTextBox.Texts);
            if (classes.Length > 1)
            {
                foreach (string s in classes)
                {
                    string[] list = s.Split(' ');
                    subjects.Add(list[0]);
                    string[] list1 = list[1].Split('.');
                    shifts.Add(list1[1]);
                    grades.Add(int.Parse(list1[0]));
                }
            }
            // Tình trạng trong ghi danh Form là để cho người dùng hiểu
            // Thực tế có 3 tình trạng chính là Nếu học sinh nhập học thì tình trạng  là "Đang học" 
            // Nếu Ô tình trạng là mặc định là "Mặc định" thì tình trạng là "Thôi học" tức chỉ những học sinh không có học tại trung tâm
            // Nếu tình trạng là học thử thì vẫn là như vậy nhưng không có nút chuyển tình trạng thành học thử.
            List<string> ids = new List<string>();
            for (int i = 0; i < subjects.Count; i++)
            {
                bus_class = new BUS_Class("", subjects[i], shifts[i], grades[i], 0, 0, 0, DateTime.Now,"Đang mở", "");
                ids.Add(bus_class.getClassId());
            }

            if (string.IsNullOrEmpty(this.id))
            {
                foreach (string s in ids)
                {
                    Console.WriteLine(s + " " + aId);
                    register = new BUS_Register(aId, s, DateTime.Now);
                    register.addQuery();
                }
            } 
            else
            {
                foreach (string s in ids)
                {
                    Console.WriteLine(s + " " + id);
                    register = new BUS_Register(id, s, DateTime.Now);
                    register.addQuery();
                }
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
                classTextBox.Enabled = true;
                classListBox.Enabled = true;
                buttonSelect.Enabled = true;
            }
            else {
                classTextBox.Visible = false;
                classListBox.Visible = false;
                buttonSelect.Visible =false;
            }
        }

        private void classListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numberPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
            if (numberPhoneTextBox != null && numberPhoneTextBox.Texts.Length >= 11 && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
