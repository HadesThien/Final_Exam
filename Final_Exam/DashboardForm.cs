using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam {
    public partial class DashboardForm : Form {
        public DashboardForm() {
            InitializeComponent();
        }

        private void settingPanelView() {
            panel2.Location = new Point(3,panel1.Height + panel1.Location.Y +150);
        }

        private void DashboardForm_Load(object sender, EventArgs e) {
            settingPanelView();
        }
    }

}
