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

namespace NQH_Application{
    public partial class CreateClassForm : Form {

        private ClassForm form;
        private string id;
        private string className;

        private string subject;
        private string shift;
        private int grade;
        private string teacherInfo;

        public CreateClassForm(ClassForm form) {
            InitializeComponent();
            this.form = form;
        }

        public CreateClassForm(string name, ClassForm form) {
            InitializeComponent();
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

        }

        private void createForm()
        {
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
            if (String.IsNullOrEmpty(className))
            {
            }
            else
            {
            }
            this.Close();
        }
    }
}
