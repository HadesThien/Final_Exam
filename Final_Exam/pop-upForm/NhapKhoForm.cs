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
    public partial class NhapKhoForm : Form {
        public NhapKhoForm() {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }
    }
}
