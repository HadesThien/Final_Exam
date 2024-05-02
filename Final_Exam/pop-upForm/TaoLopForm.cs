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

        public TaoLopForm() {
            InitializeComponent();
            BUS_Teacher teacher = new BUS_Teacher("", "", "", DateTime.Now, "", "");
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

        private void gradeComboBox_Leave(object sender, EventArgs e) {
            tenLopTextBox.Texts += gradeComboBox.Texts + ".";
        }

        private void shiftComboBox_Leave(object sender, EventArgs e) {
            tenLopTextBox.Texts += shiftComboBox.Texts;
        }
    }
}
