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
    public partial class ThanhToanForm : Form {
        //Properties
        private List<string> danhSachHocSinh= new List<string>(); 
        private List<string> danhSachLopHoc = new List<string>();
        //Constructor
        public ThanhToanForm() {
            InitializeComponent();
        }


        private List<string> FindRelatedStudents(string searchText) {
            List<string> relatedStudents = new List<string>();
            foreach(string student in danhSachHocSinh) {
                if(student.Contains(searchText)) {
                    relatedStudents.Add(student);
                }
            }
            return relatedStudents;
        }


        private void searchClassTextBox__TextChanged(object sender, EventArgs e) {
            string searchText = searchClassTextBox.Text;
            List<string> relatedClasses = FindRelatedClasses(searchText);
            classCheckedListBox.Items.Clear();
            foreach(string Class in relatedClasses) {
                classCheckedListBox.Items.Add(Class);
            }
            classCheckedListBox.Visible = true;
        }
        private List<string> FindRelatedClasses(string searchText) {
            List<string> relatedClasses = new List<string>();
            foreach(string Class in danhSachLopHoc) {
                relatedClasses.Add(Class);
            }
            return relatedClasses;
        }

        private void searchStudentTextBox_TextChanged(object sender, EventArgs e) {
            string searchText = searchStudentTextBox.Text;
            List<string> relatedStudents = FindRelatedStudents(searchText);
            studentCheckedListBox.Items.Clear();
            foreach(string student in relatedStudents) {
                studentCheckedListBox.Items.Add(student);
            }
            studentCheckedListBox.Visible = true;

        }
    }
}
