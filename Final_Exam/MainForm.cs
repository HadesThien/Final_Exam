using ResizeMovable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam {
    public partial class MainForm : Form {
        //Properties
        private MakeMovable move;
        public static bool isLogout = false;
        bool sideBarExpand = true;
        private Form currentFormChild;
        List<Button> btns = new List<Button>();
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

        //Constructor
        public MainForm() {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            move = new MakeMovable(this);
            move.SetMovable(crossbar);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            btns.Add(dashboardBtn);
            btns.Add(studentBtn);
            btns.Add(classBtn);
            btns.Add(storeBtn);
            btns.Add(paidBtn);
            btns.Add(paymentBtn);
            btns.Add(accountBtn);
            dashboardBtn.BackColor = Color.FromArgb(17, 21, 83);
            dashboardBtn.ForeColor = Color.GhostWhite;
        }
        //Setting size Form 

        //Methods
        private void OpenChildForm(Form childForm) {
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(childForm);
            bodyPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Form_Load()
        private void MainForm_Load(object sender, EventArgs e) {
            OpenChildForm(new DashboardForm());
        }

        //Three buttons corner
        private void exitBtn_Click(object sender, EventArgs e) {
            DangNhapForm.isLogin = false;
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            }
            else {
                int w = this.Width;
                int h = this.Height;
                this.WindowState = FormWindowState.Maximized;
                Region = null;
                w = this.Width - w;
                h =this.Height - h;
                bodyPanel.MaximumSize= new Size(bodyPanel.Width+ w,bodyPanel.Height+ h);
                sidebar.MaximumSize = new Size(sidebar.Width+ w,sidebar.Height+ h);
            }
        }
        private void hiddenBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        //------------------------

        private void changeBtn(Button btn) {
            foreach(Button b in btns) {
                if(b == btn) {
                    b.BackColor = Color.FromArgb(17, 21, 83);
                    b.ForeColor = Color.GhostWhite;
                }else {
                    b.BackColor = Color.FromArgb(24, 49, 96);
                    b.ForeColor = Color.White;
                }
            }
        }
        //Buttons at sidebar
        private void hocVienBtn_Click(object sender, EventArgs e) {
            changeBtn(studentBtn);
            OpenChildForm(new QuanLySinhVienForm());
        }

        private void lopHocBtn_Click(object sender, EventArgs e)
        {
            changeBtn(classBtn);
            OpenChildForm(new LophocForm());
        }


        private void khoDeBtn_Click(object sender, EventArgs e) {
            changeBtn(storeBtn);
            OpenChildForm(new KhoForm());
        }

        private void congNoBtn_Click(object sender, EventArgs e) {
            changeBtn(paymentBtn);
            OpenChildForm(new CongNoForm());
        }

        private void dashboardBtn_Click(object sender, EventArgs e) {
            changeBtn(dashboardBtn);
            OpenChildForm(new DashboardForm());
        }
        private void paidBtn_Click(object sender, EventArgs e) {
            changeBtn(paidBtn);
            OpenChildForm(new ThanhToanForm(true));
        }

        //-----------------------------------


        // Menu Button at cross Bar
        private void sideBarTimer_Tick(object sender, EventArgs e) {
            if (sideBarExpand) {
                sidebar.Width -= 10;
                bodyPanel.Width += 10;
                bodyPanel.Left -= 10;
                if(sidebar.Width <= 62) {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                    OpenChildForm(currentFormChild);
                }
            }
            else {
                sidebar.Width += 10;
                bodyPanel.Width -= 10;
                bodyPanel.Left += 10;
                if(sidebar.Width >=242) {
                        sideBarExpand = true;
                        sideBarTimer.Stop();
                        OpenChildForm(currentFormChild);
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
        private void logoutBtn_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Bạn muốn đăng xuất ?","Đăng xuất", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) { 
                isLogout = true;
                DangNhapForm.isLogin = false;
                this.Close();
            }
        }

        private void accountBtn_Click(object sender, EventArgs e) {
            Form form = new AccountInfoForm();
            OpenChildForm(form);
        }

        private void sidebar_Paint(object sender, PaintEventArgs e) {

        }

        private void studentPanel_Paint(object sender, PaintEventArgs e) {

        }

        //----------------Ends with all feature of menu Btn----------------
    }
}
