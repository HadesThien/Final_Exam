
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam {
    public partial class QuanLySinhVienForm : Form{ 
        public QuanLySinhVienForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void searchBtn_Click(object sender, EventArgs e) {
            searchTextBox.Visible = true;
        }

        private void tatcaBtn_Click(object sender, EventArgs e) {

        }

        private void danghocBtn_Click(object sender, EventArgs e) {

        }

        private void hocthuBtn_Click(object sender, EventArgs e) {

        }

        private void createBtn_Click(object sender, EventArgs e) {
            Form GhiDanhForm = new GhiDanhForm();
            GhiDanhForm.ShowDialog();
        }

        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            changeStatusBtn.Visible = true;
            int index = e.RowIndex;
            DataGridViewRow row = studentGridView.Rows[index];
            if(index == 0) {

            }
        }
    }

}
