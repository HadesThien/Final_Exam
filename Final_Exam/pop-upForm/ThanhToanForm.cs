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

namespace Final_Exam {
    public partial class ThanhToanForm : Form
    {
        private BUS_Student student;
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
            this.flag = flag;
        }

        private void updateStudentListBox()
        {
            student = new BUS_Student("", "", "", DateTime.Now, "", "", "", "", "", "", DateTime.Now, "", "");
            studentListBox.Items.Clear();
            foreach (DataRow drv in student.getIdAndName().Rows)
            {
                studentListBox.Items.Add(drv[0].ToString());
            }
        }

        private void gridViewInit()
        {
            thanhToanTable = new DataTable();
            thanhToanTable.Columns.Add("Tên thanh toán");
            thanhToanTable.Columns.Add("Loại");
            thanhToanTable.Columns.Add("Giá");
            thanhToanTable.Columns.Add("Kỳ");
            roundedGridView1.DataSource = thanhToanTable;
            roundedGridView1.Columns[0].ReadOnly = true;
            roundedGridView1.Columns[1].ReadOnly = true;
            roundedGridView1.Columns[2].ReadOnly = true;
            roundedGridView1.Columns[3].ReadOnly = true;
            DataGridViewNumericUpDownColumn dgv_nud = new DataGridViewNumericUpDownColumn();
            dgv_nud.Name = "Số buổi / số lượng";
            dgv_nud.Minimum = 1;
            dgv_nud.Maximum = 12;
            roundedGridView1.Columns.Add(dgv_nud);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string id = (studentLabel.Text).Split(new string[] {" - "}, StringSplitOptions.None)[0];
            for (int i = 0; i < thanhToanTable.Rows.Count; i++)
            {
                if (thanhToanTable.Rows[i][1].ToString().Equals("Lớp"))
                {
                    decimal val = Convert.ToDecimal(roundedGridView1.Rows[i].Cells[4].Value);
                    int n = Convert.ToInt32(val);
                    tempCheckout += (int)(int.Parse(thanhToanTable.Rows[i][2].ToString()) * (n / 12.0f));
                    BUS_Payment payment = new BUS_Payment("", DateTime.Now, DateTime.Now, "", "", 0.0f, 0, "", "");
                    string[] arr = thanhToanTable.Rows[i][0].ToString().Split(new string[] { " " }, StringSplitOptions.None);
                    string subject = arr[0];
                    string shift = arr[1].Split(new string[] { "." }, StringSplitOptions.None)[1];
                    int grade = int.Parse(arr[1].Split(new string[] { "." }, StringSplitOptions.None)[0]);
                    BUS_Class bus_class = new BUS_Class("", subject, shift, grade, 0, 0, 0, DateTime.Now, "", "");
                    Console.WriteLine(payment.getId() + " " + n + " " + id + " " + bus_class.getClassId());
                    payment = new BUS_Payment(payment.getId(), DateTime.Now, DateTime.Now, "Đăng ký", noteTextBox.Text, 0.0f, n, id, bus_class.getClassId());
                    if (!string.IsNullOrEmpty(payment.existsPaymentOfAPeriod()))
                    {
                        MessageBox.Show($"Đã tồn tại công nợ đã thanh toán của môn {thanhToanTable.Rows[i][0].ToString()} của kỳ {DateTime.Now.ToString("MM/yyyy")}");
                    }
                    else if (!string.IsNullOrEmpty(payment.existsPaymentOfAPeriod1()))
                    {
                        MessageBox.Show($"Đã tồn tại công nợ đăng ký của môn {thanhToanTable.Rows[i][0].ToString()} của kỳ {DateTime.Now.ToString("MM/yyyy")}");

                    }
                    else
                    {
                        payment.addQuery();
                    }
                }
            }
            studentListBox.SelectedIndex = 0;
            form.updateGridView();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem == null)
            {
                return;
            }
            string s = studentListBox.SelectedItem.ToString();
            searchStudentTextBox.Text = s;
            studentLabel.Text = s;
            string studentId = s.Split(new string[] { " - " }, StringSplitOptions.None)[0];

            for (int i = 0; i < classCheckedListBox.Items.Count; i++)
            {
                classCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            for (int i = 0; i < documentCheckedListBox.Items.Count; i++)
            {
                documentCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            BUS_Register register = new BUS_Register(studentId, "", DateTime.Now);
            DataTable dt = register.getClassNameFromAStudent();

            classCheckedListBox.DataSource = dt;
            classCheckedListBox.DisplayMember = "class";
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
            BUS_Document document = new BUS_Document(0, "", "", DateTime.Now, DateTime.Now, 0);
            documentCheckedListBox.DataSource = document.getNames();
            updateStudentListBox();
            documentCheckedListBox.DisplayMember = "name";
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
            for (int i = 0; i < roundedGridView1.Rows.Count; i++)
            {
                decimal val = Convert.ToDecimal(roundedGridView1.Rows[i].Cells[4].Value);
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
            DataRowView drv = (DataRowView)classCheckedListBox.Items[e.Index];
            string s = drv["class"].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                string[] arr = s.Split(new string[] { " " }, StringSplitOptions.None);
                string subject = arr[0];
                string shift = arr[1].Split(new string[] { "." }, StringSplitOptions.None)[1];
                int grade = int.Parse(arr[1].Split(new string[] { "." }, StringSplitOptions.None)[0]);
                BUS_Class bus_class = new BUS_Class("", subject, shift, grade, 0, 0, 0, DateTime.Now, "", "");
                bus_class = new BUS_Class(bus_class.getClassId(), subject, shift, grade, 0, 0, 0, DateTime.Now, "", "");
                thanhToanTable.Rows.Add(s, "Lớp", bus_class.getClass().Rows[0][4], DateTime.Now.ToString("MM/yyyy"));
                int count = roundedGridView1.Rows.Count - 1;
                Console.WriteLine(roundedGridView1.Rows[count].Cells[0].Value);
                roundedGridView1.Rows[count].Cells[4].Value = (decimal)12;
                for (int i = 0; i < roundedGridView1.Rows[count].Cells.Count; i++)
                {
                    Console.WriteLine(roundedGridView1.Rows[count].Cells[i].Value);
                }
                calculate();
            }
            else
            {
                int index = find(s);
                thanhToanTable.Rows.RemoveAt(index);
                calculate();
            }
            tempCheckoutLabel.Text = tempCheckout.ToString();
            checkoutLabel.Text = (tempCheckout - int.Parse(promotionLabel.Text)).ToString();
        }

        private void documentCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            DataRowView drv = (DataRowView)documentCheckedListBox.Items[e.Index];
            string s = drv["name"].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                BUS_Document doc = new BUS_Document(0, "", s, DateTime.Now, DateTime.Now, 0);
                thanhToanTable.Rows.Add(s, "Tài liệu", doc.getDocumentFromName().Rows[0][5], DateTime.Now.ToString("MM/yyyy"));
                int count = roundedGridView1.Rows.Count - 1;
                roundedGridView1.Rows[count].Cells[4].Value = (decimal)1;
                roundedGridView1.Rows[count].Cells[4].ReadOnly = true;
                calculate();
            }
            else
            {
                int index = find(s);
                thanhToanTable.Rows.RemoveAt(index);
                calculate();
            }
            tempCheckoutLabel.Text = tempCheckout.ToString();
            checkoutLabel.Text = (tempCheckout - int.Parse(promotionLabel.Text)).ToString();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            string id = (studentLabel.Text).Split(new string[] {" - "}, StringSplitOptions.None)[0];
            for (int i = 0; i < thanhToanTable.Rows.Count; i++)
            {
                if (thanhToanTable.Rows[i][1].ToString().Equals("Lớp"))
                {
                    decimal val = Convert.ToDecimal(roundedGridView1.Rows[i].Cells[4].Value);
                    int n = Convert.ToInt32(val);
                    BUS_Payment payment = new BUS_Payment("", DateTime.Now, DateTime.Now, "", "", 0.0f, 0, "", "");
                    string[] arr = thanhToanTable.Rows[i][0].ToString().Split(new string[] { " " }, StringSplitOptions.None);
                    string subject = arr[0];
                    string shift = arr[1].Split(new string[] { "." }, StringSplitOptions.None)[1];
                    int grade = int.Parse(arr[1].Split(new string[] { "." }, StringSplitOptions.None)[0]);
                    BUS_Class bus_class = new BUS_Class("", subject, shift, grade, 0, 0, 0, DateTime.Now, "", "");
                    payment = new BUS_Payment(payment.getId(), DateTime.Now, DateTime.Now, "Thanh toán", noteTextBox.Text, 0.0f, n, id, bus_class.getClassId());
                    if (!string.IsNullOrEmpty(payment.existsPaymentOfAPeriod()))
                    {
                        MessageBox.Show($"Đã tồn tại công nợ của môn {thanhToanTable.Rows[i][0].ToString()} của kỳ {DateTime.Now.ToString("MM/yyyy")}");
                    }
                    else if (!string.IsNullOrEmpty(payment.existsPaymentOfAPeriod1()))
                    {
                        payment = new BUS_Payment(payment.existsPaymentOfAPeriod1(), DateTime.Now, DateTime.Now, "Thanh toán", noteTextBox.Text, 0.0f, n, id, bus_class.getClassId());
                        payment.updateQuery();
                    }
                    else
                    {
                        payment.addQuery();
                    }
                }
                else
                {
                    BUS_Document doc = new BUS_Document(0, "", thanhToanTable.Rows[i][0].ToString(), DateTime.Now, DateTime.Now, 0);
                    BUS_Buy buy = new BUS_Buy(DateTime.Now, 0, 0, "Thanh toán", DateTime.Now, "", "", "", "");
                    buy = new BUS_Buy(DateTime.Now, 1, int.Parse(doc.getDocumentFromName().Rows[0][5].ToString()), "Thanh toán", DateTime.Now, noteTextBox.Text, buy.getId(), id, doc.getDocumentFromName().Rows[0][1].ToString());
                    buy.addQuery();
                    doc.updateAfterBuying();
                }
            }
            studentListBox.SelectedIndex = 0;
            if (flag == null)
            {
                form.updateGridView();
                this.Close();
            }
        }

        private void roundedGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calculate();
            tempCheckoutLabel.Text = tempCheckout.ToString();
            checkoutLabel.Text = (tempCheckout - int.Parse(promotionLabel.Text)).ToString();
        }

        private void ThanhToanForm_Shown(object sender, EventArgs e)
        {
            gridViewInit();
        }
    }
}
