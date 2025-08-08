using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace BugTracker
{
    public static class Program
    {
        static ApplicationContext MainContext = new ApplicationContext();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            ApplicationConfiguration.Initialize();

            MainContext.MainForm = new Login();
            Application.Run(MainContext);
        }

        public static void SetMainForm(Form MainForm)
        {
            MainContext.MainForm = MainForm;
        }

        public static void ShowMainForm()
        {
            MainContext.MainForm.Show();
        }

    }
}