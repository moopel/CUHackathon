using CuHackathon.C_Classes;
using CuHackathon.Forms;

namespace CuHackathon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PythonMedian.RunPythonFunc();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new EntryForm());
        }
    }
}