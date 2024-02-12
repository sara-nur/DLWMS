using DLWMS.WindForms.Intro;
using DLWMS.WindForms.P5___Prijava;
using DLWMS.WindForms.Predmeti;
using DLWMS.WindForms.Studenti;

namespace DLWMS.WindForms
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

            var startnaForma = new frmGlavna();

            Application.Run(startnaForma);
        }
    }
}
