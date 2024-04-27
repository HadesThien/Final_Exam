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
    public partial class NhapHangForm : Form {
        public NhapHangForm() {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void soLuongTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
                e.Handled = true;
        }

        private void giaTienTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
                e.Handled = true;
            if (e.KeyChar == '.') 
                e.Handled = true;
        }
    }
}
