using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WYMIS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main_Yuangong_Form());
            //Application.Run(new Bumen_Form());
            Application.Run(new Login_Form());
            //if(Login_Form.LoginState == 1)
            //{
            //    Application.Run(new Main_Form());
            //}
        }
    }
}
