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
        private const int cGrip = 16;

        bool sideBarExpand = true;
        private Form currentFormChild;

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
        }
        //Setting size Form 

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
        //    ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
        //}
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToScreen(pos);
        //        if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
        //Methods
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

        //Form_Load()
        private void MainForm_Load(object sender, EventArgs e) {
            OpenChildForm(new DashboardForm());
        }

        //Three buttons corner
        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
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


        //Buttons at sidebar
        private void hocVienBtn_Click(object sender, EventArgs e) {
            OpenChildForm(new QuanLySinhVienForm());
        }

        private void lopHocBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LophocForm());
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

        private void panel6_Paint(object sender, PaintEventArgs e) {

        }

        private void panel7_Paint(object sender, PaintEventArgs e) {

        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void panel5_Paint(object sender, PaintEventArgs e) {

        }

        private void panel4_Paint(object sender, PaintEventArgs e) {

        }
        //----------------Ends with all feature of menu Btn----------------
    }
}
