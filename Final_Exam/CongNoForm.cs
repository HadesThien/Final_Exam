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
    public partial class CongNoForm : Form {

        public CongNoForm() {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void CongNoForm_Load(object sender, EventArgs e) {

        }

        private void tatcaBtn_Click(object sender, EventArgs e) {

        }

        private void registeredBtn_Click(object sender, EventArgs e) {

        }

        private void paidBtn_Click(object sender, EventArgs e) {

        }

        private void searchBtn_Click(object sender, EventArgs e) {
            searchTextBox.Visible = true;
        }

        private void createBtn_Click(object sender, EventArgs e) {
            Form form = new TaoCongNoForm();
            form.ShowDialog();
        }
    }
}
