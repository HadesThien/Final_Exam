using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BUS_VN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BUS;
using System.Windows.Forms.VisualStyles;
using System.Reflection.Emit;
using System.Data.Odbc;

namespace NQH_Application{
    public partial class ghiDanhForm : Form {
        //Properties

        private QuanLySinhVienForm svForm;
        private string id;
        private string aId;

        //Constructor 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
                (
                    int nLeftRect,     // x-coordinate of upper-left corner
                    int nTopRect,      // y-coordinate of upper-left corner
                    int nRightRect,    // x-coordinate of lower-right corner
                    int nBottomRect,   // y-coordinate of lower-right corner
                    int nWidthEllipse, // width of ellipse
                    int nHeightEllipse // height of ellipse
                );

        public ghiDanhForm(QuanLySinhVienForm svForm) {
            InitializeComponent();
        }
        public ghiDanhForm(QuanLySinhVienForm form, string aId) {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

   
        private void defaultForm()
        {
        }

        private int findStringExactCity(string str)
        {
            for (int i = 0; i < cityComboBox.Items.Count; i++)
            {
                string s = ((DataRowView)cityComboBox.Items[i])["full_name"].ToString();

                if (s.Equals(str))
                {
                    return i;
                }
            }
            return -1;
        }
        private int findStringExactDistrict(string str)
        {
            for (int i = 0; i < districtComboBox.Items.Count; i++)
            {
                string s = ((DataRowView)districtComboBox.Items[i])["full_name"].ToString();

                if (s.Equals(str))
                {
                    return i;
                }
            }
            return -1;
        }
        private int findStringExactWard(string str)
        {
            for (int i = 0; i < wardComboBox.Items.Count; i++)
            {
                string s = ((DataRowView)wardComboBox.Items[i])["full_name"].ToString();

                if (s.Equals(str))
                {
                    return i;
                }
            }
            return -1;
        }

        private void defaultForm1()
        {
            defaultForm();
        }

        private void GhiDanhForm_Load(object sender, EventArgs e) {
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            classListBox.Visible = !classListBox.Visible;
        }

        private void cityComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wardComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void disctrictComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void classListBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            string selectedItem = classListBox.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked) {
                if (classTextBox.Texts.Equals(""))
                {
                    classTextBox.Texts += selectedItem;
                }
                if (!classTextBox.Texts.Contains(selectedItem)) {
                    classTextBox.Texts += ", " + selectedItem;
                }
            }
            else 
            {
                int index = classTextBox.Texts.IndexOf(selectedItem);
                if (index + selectedItem.Length < classTextBox.Texts.Length && classTextBox.Texts[index + selectedItem.Length] == ',')
                {
                    classTextBox.Texts = classTextBox.Texts.Replace(selectedItem + ", ", "");
                }
                else if (index - 1 > 0 && classTextBox.Texts[index - 1] == ' ')
                {
                    classTextBox.Texts = classTextBox.Texts.Replace(", " + selectedItem, "");
                }
                else
                {
                    classTextBox.Texts = classTextBox.Texts.Replace(selectedItem, "");
                }

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
        }

        private void tinhTrangComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void classListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numberPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
            if (numberPhoneTextBox != null && numberPhoneTextBox.Texts.Length >= 11 && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
