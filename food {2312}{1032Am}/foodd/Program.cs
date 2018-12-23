using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using foodd.Properties;
using System.Windows.Forms;
using foodd.Forms_F;

namespace foodd
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
            Application.Run(new Management());
        }
    }
}
