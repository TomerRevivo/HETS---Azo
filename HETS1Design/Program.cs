using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;


namespace HETS1Design
{
    //We exclude this automatically generated code.
    [ExcludeFromCodeCoverage]
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
            Application.Run(new MainScreen());
        }
    }
}
