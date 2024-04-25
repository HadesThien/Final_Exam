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
        public LophocForm()
        {
            InitializeComponent();
        }

        private void LophocForm_Load(object sender, EventArgs e)
        {

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
            Form form = new TaoLopForm();
            form.ShowDialog();
        }
    }
}
