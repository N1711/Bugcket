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
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            //MainContext.MainForm = new Form2();
            //Application.Run(MainContext.MainForm);
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