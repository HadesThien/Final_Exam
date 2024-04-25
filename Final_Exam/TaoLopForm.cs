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
            
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void khoiHocTextBox_KeyPress(object sender, KeyPressEventArgs e) {
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

        private void monHocTextBox_Leave(object sender, EventArgs e) {
            tenLopTextBox.Texts += monHocTextBox.Texts + " ";
        }

        private void giaTienTextBox_Leave(object sender, EventArgs e) {
            if (giaTienTextBox.Texts.Length < 5) alert.Visible = true;
        }

        private void khoiHocTextBox_Leave(object sender, EventArgs e) {
            tenLopTextBox.Texts += khoiHocTextBox.Texts + ".";
        }

        private void caHocTextBox_Leave(object sender, EventArgs e) {
            tenLopTextBox.Texts += caHocTextBox.Texts;
        }

    }
}
