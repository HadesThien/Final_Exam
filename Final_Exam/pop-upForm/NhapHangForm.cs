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

namespace NQH_Application{
    public partial class NhapHangForm : Form {
        private string id;
        private KhoForm form;
        private bool? flag;
        private int num;
        public NhapHangForm(KhoForm form) {
            InitializeComponent();
        }

        public NhapHangForm(KhoForm form, string id, bool flag, int num) {
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

        private void NhapHangForm_Load(object sender, EventArgs e)
        {
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (flag == null)
            {
                if (tenSanPhamTextBox.Texts.Equals("") || soLuongTextBox.Texts.Equals("") || giaTienTextBox.Texts.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }
            }
            if (flag == true)
            {
                if (soLuongTextBox.Texts.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }
            }
            else
            {
                if (tenSanPhamTextBox.Texts.Equals("") || giaTienTextBox.Texts.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }
            }
            form.updateGridView();
            this.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            ConfirmForm confirmForm = new ConfirmForm();
            confirmForm.ShowDialog();
            if (Account.isPermited() == true)
            {
            }
            Account.denyAccess();
            form.updateGridView();
            this.Close();
        }

        private void soLuongTextBox__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
