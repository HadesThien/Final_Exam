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

namespace Final_Exam {
    public partial class KhoForm : Form {

        private BUS_Document doc;       

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
            doc = new BUS_Document(0, "", "", DateTime.Now, DateTime.Now, 0);
            DataTable dt = doc.selectQuery();
            documentGridView.DataSource = dt;

            dt.Columns[0].ColumnName = "Mã đề cương";
            dt.Columns[1].ColumnName = "Tên đề cương";
            dt.Columns[2].ColumnName = "Số lượng";
            dt.Columns[3].ColumnName = "Giá";
            dt.Columns[4].ColumnName = "Ngày cập nhật";
            dt.Columns[5].ColumnName = "Ngày tạo";

            foreach (DataGridViewColumn col in documentGridView.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

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
    }
}
