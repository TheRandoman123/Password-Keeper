using System;
using System.Windows.Forms;

namespace Password_Keeper
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
            Application.Run(new profile_name_sign_in_label());
        }
    }
}
