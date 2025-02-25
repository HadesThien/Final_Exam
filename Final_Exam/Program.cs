using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NQH_Application{

    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            while(LoginForm.isLogin != MainForm.isLogout) {
                if(LoginForm.isLogin == true ) 
                    Application.Run(new MainForm());
                if(MainForm.isLogout == true ) 
                    Application.Run(new LoginForm());
                
            }
        }
    }
}
