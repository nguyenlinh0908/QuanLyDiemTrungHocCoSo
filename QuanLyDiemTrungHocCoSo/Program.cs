﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemTrungHocCoSo
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
            Application.Run(new utils.USignIn());
            //    Application.Run(new utils.UScore());
            //Application.Run(new DSHocSinhtheolop());
            // Application.Run(new HocSinh());
            //Application.Run(new ThemHSDS());
        }
    }
}
