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
using NQH_Application.pop_upForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NQH_Application{
    public partial class ChiTietSinhVienForm : Form {

        private QuanLySinhVienForm form;
        private string id;
        private DataTable dt;

        public ChiTietSinhVienForm(QuanLySinhVienForm form, string id) {
            InitializeComponent();
        }


        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void update()
        {
        }

        private void ChiTietSinhVienForm_Load(object sender, EventArgs e)
        {
        }

        private void removeBtn_Click(object sender, EventArgs e) {
        }

        private void classBtn_Click(object sender, EventArgs e) {
        }

        private void hocPhiBtn_Click(object sender, EventArgs e)
        {
        }

        private void tinhTrangComboBox_OnSelectedIndexChanged(object sender, EventArgs e) {
        }

        private void paymentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
