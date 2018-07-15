using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace kaktus_dobijecka
{
    public static class GV
    {
        public static int OK = 1;
    }

    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
