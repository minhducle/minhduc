using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace T138384_OwnProgram_LuongTrungKien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmOwnProgram());
        }
    }
}
