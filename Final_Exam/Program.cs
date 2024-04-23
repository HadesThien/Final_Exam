using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhapForm());
            while(DangNhapForm.isLogin != MainForm.isLogout) {
                if(DangNhapForm.isLogin == true ) 
                    Application.Run(new MainForm());
                if(MainForm.isLogout == true ) 
                    Application.Run(new DangNhapForm());
                
            }
        }
    }
}
