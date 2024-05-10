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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Exam {
    public partial class TaoLopForm : Form {

        private BUS_Class bus_class;
        private LophocForm form;
        private string id;
        private string className;

        private string subject;
        private string shift;
        private int grade;
        private string teacherInfo;

        public TaoLopForm(LophocForm form) {
            InitializeComponent();
            bus_class = new BUS_Class("", "", "", 0, 0, 0, 0, DateTime.Now, "", "");
            id = bus_class.getId();
            this.form = form;
        }

        public TaoLopForm(string name, LophocForm form) {
            InitializeComponent();
            bus_class = new BUS_Class("", "", "", 0, 0, 0, 0, DateTime.Now, "", "");
            this.className = name;
            this.form = form;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void gradeComboBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') {
                e.Handled = true;
            }
        }

        private void soBuoiTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
                e.Handled = true;
        }

        private void soHocSinhTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
                e.Handled = true;
        }

        private void giaTienTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
                e.Handled = true;
            if (e.KeyChar == '.') 
                e.Handled = true;
        }

        private void subjectComboBox_Leave(object sender, EventArgs e) {
            tenLopTextBox.Texts += subjectComboBox.Texts + " ";
        }

        private void giaTienTextBox_Leave(object sender, EventArgs e) {
            if (giaTienTextBox.Texts.Length < 5) alert.Visible = true;
        }

        private void tenLopTextBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            tenLopTextBox.Texts = subjectComboBox.SelectedItem.ToString() + " " + gradeComboBox.Texts + "." + shiftComboBox.Texts;
        }

        private int findExactStringIndex(string s)
        {
            for (int i = 0; i < shiftComboBox.Items.Count; i++)
            {
                if (s.Equals(shiftComboBox.Items[i].ToString())) return i;
            }
            return -1;
        }

        private void updateForm()
        {
            createForm();
            string[] s = className.Split(new string[] { " " }, StringSplitOptions.None);
            string[] s1 = s[1].Split(new string[] { "." }, StringSplitOptions.None);
            bus_class = new BUS_Class("", s[0], s1[1], int.Parse(s1[0]), 0, 0, 0, DateTime.Now, "", "");
            maLopTextBox.Texts = bus_class.getClassId();
            subjectComboBox.Texts = s[0];
            subject = s[0];
            gradeComboBox.Texts = s1[0];
            grade = int.Parse(s1[0]);
            shiftComboBox.SelectedIndex = findExactStringIndex(s1[1]);
            shift = shiftComboBox.Texts;
            bus_class = new BUS_Class(bus_class.getClassId(), s[0], s1[1], int.Parse(s1[0]), 0, 0, 0, DateTime.Now, "", "");
            teacherComboBox.Texts = bus_class.getTeacher();
            giaTienTextBox.Texts = bus_class.getOtherInfo().Rows[0][0].ToString();
            statusComboBox.Texts = bus_class.getOtherInfo().Rows[0][1].ToString();
            soBuoiTextBox.Texts = bus_class.getOtherInfo().Rows[0][2].ToString();
            soHocSinhTextBox.Texts = bus_class.getOtherInfo().Rows[0][3].ToString();

            teacherInfo = teacherComboBox.Texts;
        }

        private void createForm()
        {
            bus_class = new BUS_Class("", "", "", 0, 0, 0, 0, DateTime.Now, "", "");

            subjectComboBox.Items.Add("Toán");
            subjectComboBox.Items.Add("Văn");
            subjectComboBox.Items.Add("Anh");
            subjectComboBox.Items.Add("KHTN");

            for (int i = 1; i < 5; i++)
            {
                shiftComboBox.Items.Add(i);
            }

            for (int i = 6; i < 10; i++)
            {
                gradeComboBox.Items.Add(i);
            }

            maLopTextBox.Texts = id;

            BUS_Teacher teacher = new BUS_Teacher("", "", "", DateTime.Now, "", "");
            teacherComboBox.DataSource = teacher.getTeachers();
            teacherComboBox.ValueMember = "teacher";

            statusComboBox.Items.Add("Đang mở");
            statusComboBox.Items.Add("Đã đóng");
        }

        private void TaoLopForm_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(className))
            {
                updateForm();
            }
            else
            {
                createForm();
            }
        }

        private void gradeComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            tenLopTextBox.Texts = subjectComboBox.Texts + " " + gradeComboBox.SelectedItem.ToString() + "." + shiftComboBox.Texts;
        }

        private void shiftComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            tenLopTextBox.Texts = subjectComboBox.Texts + " " + gradeComboBox.Texts + "." + shiftComboBox.SelectedItem.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (gradeComboBox.Texts.Equals("") || shiftComboBox.Texts.Equals("") || soBuoiTextBox.Texts.Equals("") || soHocSinhTextBox.Texts.Equals("") || giaTienTextBox.Texts.Equals("") || statusComboBox.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin lớp học");
                return;
            }
            string s = teacherComboBox.Texts.Split(new string[] { " - " }, StringSplitOptions.None)[2];
            string teacherId = teacherComboBox.Texts.Split(new string[] { " - " }, StringSplitOptions.None)[0];
            if (!s.Equals(subjectComboBox.Texts))
            {
                MessageBox.Show("Giáo viên không thể dạy lớp này, vui lòng chọn giáo viên khác");
                return;
            }
            if (String.IsNullOrEmpty(className))
            {
                bus_class = new BUS_Class(id, subjectComboBox.Texts, shiftComboBox.Texts, int.Parse(gradeComboBox.Texts), int.Parse(giaTienTextBox.Texts), int.Parse(soBuoiTextBox.Texts), int.Parse(soHocSinhTextBox.Texts), DateTime.Now, statusComboBox.Texts, teacherId);
                if (bus_class.existsThisClass())
                {
                    MessageBox.Show("Đã tồn tại lớp học này");
                    return;
                }
                if (bus_class.teacherTeachesOnThisShift())
                {
                    MessageBox.Show("Giáo viên đã dạy vào ca này");
                    return;
                }
            }
            else
            {
                id = maLopTextBox.Texts;
                bus_class = new BUS_Class(id, subjectComboBox.Texts, shiftComboBox.Texts, int.Parse(gradeComboBox.Texts), int.Parse(giaTienTextBox.Texts), int.Parse(soBuoiTextBox.Texts), int.Parse(soHocSinhTextBox.Texts), DateTime.Now, statusComboBox.Texts, teacherId);
                Console.WriteLine(subject + " " + grade.ToString() + "." + shift);
                Console.WriteLine(subjectComboBox.Texts + " " + gradeComboBox.Texts + "." + shiftComboBox.Texts);
                Console.WriteLine(bus_class.existsThisClass());
                if (bus_class.existsThisClass() && !(subjectComboBox.Texts.Equals(subject) && shiftComboBox.Texts.Equals(shift) && int.Parse(gradeComboBox.Texts) == grade))
                {
                    MessageBox.Show("Đã tồn tại lớp học này");
                    return;
                }
                Console.WriteLine(teacherInfo);
                Console.WriteLine(teacherComboBox.Texts);
                Console.WriteLine();
                if (bus_class.teacherTeachesOnThisShift() && !teacherInfo.Equals(teacherComboBox.Texts))
                {
                    MessageBox.Show("Giáo viên đã dạy vào ca này");
                    return;
                }
            }
            if (String.IsNullOrEmpty(className))
                bus_class.addQuery();
            else
                bus_class.updateQuery();
            form.updateGridView("");
            this.Close();
        }
    }
}
