using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EX0408
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
            Application.Run(new CateringForm());
        }
    }
}