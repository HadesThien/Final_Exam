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
using BUS;
using System.Drawing.Text;
using System.Diagnostics;
using DataGridViewNumericUpDownElements;
using System.DirectoryServices.ActiveDirectory;

namespace NQH_Application{
    public partial class ThanhToanForm : Form
    {
        private DataTable thanhToanTable;

        private int tempCheckout = 0;
        private bool? flag;

        private CongNoForm form;
        //Constructor
        public ThanhToanForm(CongNoForm form)
        {
            InitializeComponent();
            label12.Visible = false;
            documentCheckedListBox.Visible = false;
            studentListBox.Visible = true;
            this.form = form;
        }

        public ThanhToanForm(bool flag)
        {
            InitializeComponent();
            cancelBtn.Location = saveBtn.Location;
            saveBtn.Visible = false;
            studentListBox.Visible = true;
            cancelBtn.Visible = false;
            documentCheckedListBox.Enabled = false;
            this.flag = flag;
        }

        private void updateStudentListBox()
        {
            studentListBox.Items.Clear();
        }

        private void gridViewInit()
        {
            thanhToanTable = new DataTable();
            DataGridViewCheckBoxColumn dgv_cbc = new DataGridViewCheckBoxColumn();
            dgv_cbc.Name = "";
            dgv_cbc.Width = 10;
            paymentGridView.Columns.Add(dgv_cbc);
            thanhToanTable.Columns.Add("Tên thanh toán");
            thanhToanTable.Columns.Add("Loại");
            thanhToanTable.Columns.Add("Giá");
            thanhToanTable.Columns.Add("Kỳ");
            paymentGridView.DataSource = thanhToanTable;
            paymentGridView.Columns[0].ReadOnly = false;
            paymentGridView.Columns[1].ReadOnly = true;
            paymentGridView.Columns[2].ReadOnly = true;
            paymentGridView.Columns[3].ReadOnly = true;
            paymentGridView.Columns[4].ReadOnly = true;
            DataGridViewNumericUpDownColumn dgv_nud = new DataGridViewNumericUpDownColumn();
            dgv_nud.Name = "Số buổi / số lượng";
            dgv_nud.Minimum = 1;
            dgv_nud.Maximum = 12;
            paymentGridView.Columns.Add(dgv_nud);
            foreach (DataGridViewColumn column in paymentGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void searchStudentTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string s = searchStudentTextBox.Text;
                if (!string.IsNullOrEmpty(s))
                {
                    updateStudentListBox();
                    List<string> students = new List<string>();
                    for (int i = 0; i < studentListBox.Items.Count; i++)
                    {
                        if (studentListBox.Items[i].ToString().IndexOf(s, 0, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            students.Add(studentListBox.Items[i].ToString());
                        }
                    }
                    studentListBox.Items.Clear();
                    for (int i = 0; i < students.Count; i++)
                    {
                        studentListBox.Items.Add(students[i]);
                    }
                }
                else
                {
                    updateStudentListBox();
                }
            }
        }

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {
        }

        private void classCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void documentCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public int find(string s)
        {
            for (int i = 0; i < thanhToanTable.Rows.Count; i++)
            {
                if (s.Equals(thanhToanTable.Rows[i][0]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void calculate()
        {
            tempCheckout = 0;
            for (int i = 0; i < paymentGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(paymentGridView.Rows[i].Cells[0].Value) == false)
                {
                    continue;
                }
                decimal val = Convert.ToDecimal(paymentGridView.Rows[i].Cells[5].Value);
                int n = Convert.ToInt32(val);
                if (thanhToanTable.Rows[i][1].Equals("Lớp"))
                {
                    tempCheckout += (int)(int.Parse(thanhToanTable.Rows[i][2].ToString()) * (n / 12.0f));
                }
                else
                {
                    tempCheckout += (int)(int.Parse(thanhToanTable.Rows[i][2].ToString()));
                }
            }
        }

        private void classCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void documentCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
        }

        private void roundedGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ThanhToanForm_Shown(object sender, EventArgs e)
        {
        }

        private void paymentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
