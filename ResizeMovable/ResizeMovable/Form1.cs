using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResizeMovable
{
    public partial class Form1 : Form
    {
        private const int cGrip = 16;
        private MakeMovable _move;
        public Form1()
        {
            InitializeComponent();
            _move = new MakeMovable(this);
            _move.SetMovable(panel_Header,lbTitle);
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void btxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToScreen(pos);
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
    }
}
