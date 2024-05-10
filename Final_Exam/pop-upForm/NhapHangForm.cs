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
using Final_Exam.pop_upForm;

namespace Final_Exam {
    public partial class NhapHangForm : Form {
        private BUS_Document doc;
        private BUS_Buy buy;
        private string id;
        private KhoForm form;
        private bool? flag;
        private int num;
        public NhapHangForm(KhoForm form) {
            InitializeComponent();
            this.form = form;
            delBtn.Visible = false;
            doc = new BUS_Document(0, "", "", DateTime.Now, DateTime.Now, 0);
            handoutIdTextBox.Text = doc.getId();
        }

        public NhapHangForm(KhoForm form, string id, bool flag, int num) {
            InitializeComponent();
            this.form = form;
            this.id = id;
            this.flag = flag;
            this.num = num;
            doc = new BUS_Document(0, id, "", DateTime.Now, DateTime.Now, 0);
            DataTable dt = doc.findDocument();
            if (flag)
            {
                label3.Visible = false;
                label10.Visible = false;
                tenSanPhamTextBox.Visible = false;
                label5.Visible = false;
                giaTienTextBox.Visible = false;
                saveBtn.Text = "Nhập";
                delBtn.Visible = false;
                System.Drawing.Point temp = label4.Location;
                label4.Location = label3.Location;
                soLuongTextBox.Location = tenSanPhamTextBox.Location;
                cancelBtn.Location = temp;
                saveBtn.Location = new System.Drawing.Point(saveBtn.Location.X, cancelBtn.Location.Y);
                tenSanPhamTextBox.Texts = dt.Rows[0][0].ToString();
                giaTienTextBox.Texts = dt.Rows[0][1].ToString();
            }
            else
            {
                label4.Visible = false;
                soLuongTextBox.Visible = false;
                delBtn.Visible = true;

                System.Drawing.Point oldLabel5Pos = label5.Location;

                label5.Location = label4.Location;
                giaTienTextBox.Location = soLuongTextBox.Location;

                label10.Location = new System.Drawing.Point(label10.Location.X, giaTienTextBox.Location.Y + 4);

                cancelBtn.Location = oldLabel5Pos;

                delBtn.Location = new System.Drawing.Point(delBtn.Location.X, cancelBtn.Location.Y);
                saveBtn.Location = new System.Drawing.Point(saveBtn.Location.X, cancelBtn.Location.Y);

                System.Drawing.Point temp = delBtn.Location;
                delBtn.Location = saveBtn.Location;
                saveBtn.Location = temp;
                saveBtn.Text = "Sửa";

                tenSanPhamTextBox.Texts = dt.Rows[0][0].ToString();
                giaTienTextBox.Texts = dt.Rows[0][1].ToString();
                soLuongTextBox.Texts = num.ToString();
            }
            handoutIdTextBox.Text = id;
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
                doc = new BUS_Document(int.Parse(soLuongTextBox.Texts), handoutIdTextBox.Text, tenSanPhamTextBox.Texts, DateTime.Now, DateTime.Now, int.Parse(giaTienTextBox.Texts));
                doc.addQuery();
            }
            if (flag == true)
            {
                if (soLuongTextBox.Texts.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }
                doc = new BUS_Document(num + int.Parse(soLuongTextBox.Texts), id, tenSanPhamTextBox.Texts, DateTime.Now, DateTime.Now, int.Parse(giaTienTextBox.Texts));
                doc.updateQuery();
            }
            else
            {
                if (tenSanPhamTextBox.Texts.Equals("") || giaTienTextBox.Texts.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }
                doc = new BUS_Document(int.Parse(soLuongTextBox.Texts), id, tenSanPhamTextBox.Texts, DateTime.Now, DateTime.Now, int.Parse(giaTienTextBox.Texts));
                doc.updateQuery();
            }
            form.updateGridView();
            this.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            ConfirmForm confirmForm = new ConfirmForm();
            confirmForm.ShowDialog();
            if (Account.confirmPassword == true)
            {
                doc = new BUS_Document(0, id, "", DateTime.Now, DateTime.Now, 0);
                buy = new BUS_Buy(DateTime.Now, 0, 0, "", DateTime.Now, "", "", "", id);
                buy.deleteFromADocument();
                doc.deleteQuery();
            }
            Account.confirmPassword = false;
            form.updateGridView();
            this.Close();
        }

        private void soLuongTextBox__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
