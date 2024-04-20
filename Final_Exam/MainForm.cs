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
    public partial class MainForm : Form {
        bool sideBarExpand = true;
        private Form currentFormChild;
        public MainForm() {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm) {
            //if(currentFormChild != null) {
            //    currentFormChild.Close();
            //}
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(childForm);
            bodyPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e) {
            OpenChildForm(new DashboardForm());
        }

        private void rjButton9_Click(object sender, EventArgs e) {

        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void hiddenBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hocVienBtn_Click(object sender, EventArgs e) {
            OpenChildForm(new QuanLySinhVienForm());
        }

        private void lopHocBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LophocForm());
        }

        private void minimizeBtn_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        private void khoDeBtn_Click(object sender, EventArgs e) {
            OpenChildForm(new KhoForm());
        }

        private void congNoBtn_Click(object sender, EventArgs e) {
            OpenChildForm(new CongNoForm());
        }

        private void dashboardBtn_Click(object sender, EventArgs e) {
            OpenChildForm(new DashboardForm());
        }

        private void sideBarTimer_Tick(object sender, EventArgs e) {
            if (sideBarExpand) {
                sidebar.Width -= 10;
                bodyPanel.Width += 10;
                bodyPanel.Left -= 10;
                if(bodyPanel.Width == bodyPanel.MaximumSize.Width) {
                    OpenChildForm(currentFormChild);
                }
                if(sidebar.Width == sidebar.MinimumSize.Width) {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else {
                sidebar.Width += 10;
                bodyPanel.Width -= 10;
                bodyPanel.Left += 10;
                if(bodyPanel.Width == bodyPanel.MinimumSize.Width) {
                    OpenChildForm(currentFormChild);
                }
                if(sidebar.Width == sidebar.MaximumSize.Width) {
                    sideBarExpand=true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e) {
            sideBarTimer.Start();
        }

        private void menuBtn_MouseHover(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
        }

        private void menuBtn_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
        }
    }
}
