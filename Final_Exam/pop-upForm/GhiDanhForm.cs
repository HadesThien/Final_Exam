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

namespace Final_Exam {
    public partial class ghiDanhForm : Form {
        //Properties 
        List<string> selectedItems = new List<string>();
        string classString = "";

        private BUS_Address address;

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

        public ghiDanhForm() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

   
        private void defaultForm()
        {
            districtComboBox.Enabled = false;
            wardComboBox.Enabled = false;

            address = new BUS_Address("", "", "");
            DataTable dt = address.selectCities();
            cityComboBox.DataSource = dt;
            cityComboBox.ValueMember = "full_name";
        }

        private void GhiDanhForm_Load(object sender, EventArgs e) {
            defaultForm();
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            classListBox.Visible = !classListBox.Visible;
        }

        private void cityComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cityComboBox.SelectedItem;
            string valueOfItem = drv["full_name"].ToString();

            address = new BUS_Address(valueOfItem, "", "");

            DataTable dt = address.selectDistricts();
            districtComboBox.DataSource = dt;
            districtComboBox.ValueMember = "full_name";

            districtComboBox.Enabled = true;
        }

        private void wardComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void disctrictComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)districtComboBox.SelectedItem;
            string valueOfItem = drv["full_name"].ToString();

            address = new BUS_Address("", valueOfItem, "");

            DataTable dt = address.selectWards();
            wardComboBox.DataSource = dt;
            wardComboBox.ValueMember = "full_name";

            wardComboBox.Enabled = true;
        }
        private void UpdateTextBoxValue() {
            StringBuilder selectedValues = new StringBuilder();
            for (int i = 0; i < classListBox.CheckedItems.Count; i++) {
                selectedValues.Append(classListBox.CheckedItems[i].ToString() + " ");
                Console.WriteLine(classListBox.CheckedItems[i].ToString());
            }
            classTextBox.Texts = selectedValues.ToString().Trim(); 
        }

        private void classListBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            // Lấy ra giá trị của mục được chọn
            string selectedItem = classListBox.Items[e.Index].ToString();

            // Nếu mục đó được chọn
            if (e.NewValue == CheckState.Checked) {
                // Thêm giá trị của mục vào TextBox (đảm bảo không trùng lặp)
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
            bool flag = nameTextBox.Texts.Equals("") || diaChiTextBox.Texts.Equals("") || truongHocTextBox.Texts.Equals("") || genderComboBox.Texts.Equals("") || tinhTrangComboBox.Texts.Equals("") || numberPhoneTextBox.Texts.Equals("");
            if (flag)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin học sinh");
                return;
            }
        }
    }
}
