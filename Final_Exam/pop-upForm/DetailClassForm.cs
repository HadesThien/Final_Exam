using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQH_Application.pop_upForm {
    public partial class DetailClassForm : Form {
        //Properties
        string teacherId;
        string classId;
        string className;
        DataTable dt;
        ClassForm form;


        //Constructor
        public DetailClassForm(string className, ClassForm form) {
            InitializeComponent();
        }

        private void ChiTietLopHocForm_Load(object sender, EventArgs e) {


        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e) {
        }
    }
}
