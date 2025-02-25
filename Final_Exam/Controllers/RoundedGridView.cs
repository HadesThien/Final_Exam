using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQH_Application{
    internal class RoundedGridView:DataGridView {
        public int BorderRadius { get; set; } = 10;

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath()) {
                int radius = BorderRadius;
                int width = Width;
                int height = Height;

                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddArc(width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
                path.AddArc(width - (radius * 2), height - (radius * 2), radius * 2, radius * 2, 0, 90);
                path.AddArc(0, height - (radius * 2), radius * 2, radius * 2, 90, 90);
                path.CloseAllFigures();

                Region = new Region(path);
            }
        }
    }
}
