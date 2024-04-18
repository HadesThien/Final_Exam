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
    public partial class LophocForm : Form
    {
        public LophocForm()
        {
            InitializeComponent();
        }

        private void LophocForm_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e) {
            searchTextBox.Visible = true;
        }
    }
}
