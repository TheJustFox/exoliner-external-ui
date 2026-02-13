using ExolinerExternalUI.Classes;
using System;
using System.Windows.Forms;

namespace ExolinerExternalUI {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            FileManager.Init();
            FileManager.LoadSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            FileManager.SaveSettings();
        }
    }
}
