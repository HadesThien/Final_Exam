using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace NQH_Application{
    public partial class KhoForm : Form {


        public KhoForm() {
            InitializeComponent();
        }

        private void dangMoBtn_Click(object sender, EventArgs e) {

        }

        private void daDongBtn_Click(object sender, EventArgs e) {

        }

        private void tatcaBtn_Click(object sender, EventArgs e) {

        }

        private void createBtn_Click(object sender, EventArgs e) {
            Form form= new NhapHangForm(this);
            form.ShowDialog();
        }

        public void updateGridView()
        {

        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KhoForm_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            int row = documentGridView.CurrentCell.RowIndex;
            Form form = new NhapHangForm(this, documentGridView.Rows[row].Cells[0].Value.ToString(), true, int.Parse(documentGridView.Rows[row].Cells[2].Value.ToString()));
            form.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int row = documentGridView.CurrentCell.RowIndex;
            Form form = new NhapHangForm(this, documentGridView.Rows[row].Cells[0].Value.ToString(), false, int.Parse(documentGridView.Rows[row].Cells[2].Value.ToString()));
            form.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Visible = true;
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
