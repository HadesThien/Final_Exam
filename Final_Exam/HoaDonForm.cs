using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam
{
    public partial class HoaDonForm : Form
    {
        private DataGridView dgv;
        private string studentName;
        private string phoneNumber;
        private string tempCheckout;
        private string checkout;

        public HoaDonForm(DataGridView dgv, string studentName, string phoneNumber, string tempCheckout, string checkout)
        {
            InitializeComponent();
            this.dgv = dgv;
            this.studentName = studentName;
            this.phoneNumber = phoneNumber;
            this.tempCheckout = tempCheckout;
            this.checkout = checkout;
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên thanh toán");
            dt.Columns.Add("Loại");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Kỳ");
            dt.Columns.Add("Số buổi / số lượng");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, Convert.ToDecimal(row.Cells[5].Value));
            }


            HoaDon hoaDon = new HoaDon();
            (hoaDon.ReportDefinition.ReportObjects["name"] as TextObject).Text = studentName;
            (hoaDon.ReportDefinition.ReportObjects["sdt"] as TextObject).Text = phoneNumber;
            (hoaDon.ReportDefinition.ReportObjects["tempCheckout"] as TextObject).Text = tempCheckout;
            (hoaDon.ReportDefinition.ReportObjects["checkout"] as TextObject).Text = checkout;
            hoaDon.SetDataSource(dt);
            crystalReportViewer1.ReportSource = hoaDon;
            hoaDon.PrintToPrinter(1, false, 0, 0);
        }
    }
}
