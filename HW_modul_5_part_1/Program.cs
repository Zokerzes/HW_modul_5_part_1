using AdoNetWinformsApp;
using Microsoft.EntityFrameworkCore;

namespace HW_modul_5_part_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var context = new CountryContext();
            context.Database.Migrate();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}