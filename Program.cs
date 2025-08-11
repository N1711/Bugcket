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

            Form2 f = new Form2();
            Application.Run(f);
        }

    }
}