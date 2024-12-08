using FilmsManage.GUI;
using FilmsManage.GUI.DataUserControl;
using FilmsManage.GUI.Forms;

namespace FilmsManage
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new MainForm());
=======
            Application.Run(new BanVe());
>>>>>>> 58616c9d27af640a8ac028e2727c888751943e2d
        }
    }
}