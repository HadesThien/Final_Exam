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

namespace Final_Exam {
    public partial class GhiDanhForm : Form {
        //Properties 
        List<string> selectedItems = new List<string>();
        string classString = "";

        //Constructor 
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

        public GhiDanhForm() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void classListBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectedItems.Clear();
            foreach (var item in classListBox.SelectedItems) {
                selectedItems.Add(item.ToString());
            }
            classString += selectedItems[0] + " ";
            classTextBox.Texts = classString;
            Console.WriteLine(classTextBox.Texts);
            Console.WriteLine(classTextBox.Text);
        }

        private void GhiDanhForm_Load(object sender, EventArgs e) {
            
        }

        private void buttonSelect_Click(object sender, EventArgs e) {
            classListBox.Visible = !classListBox.Visible;
        }
    }
}
