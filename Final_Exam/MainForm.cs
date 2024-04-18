﻿using System;
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


        private Form currentFormChild;
        public MainForm() {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm) {
            if(currentFormChild != null) {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void rjButton9_Click(object sender, EventArgs e) {

        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void hiddenBtn_Click(object sender, EventArgs e) {
            
        }

        private void hocVienBtn_Click(object sender, EventArgs e) {
            OpenChildForm(new QuanLySinhVienForm());
        }

        private void lopHocBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LophocForm());
        }
    }
}
