using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace BugTracker
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var form2 = new Form2();
            if (form2 != null)
            {
                Application.Run(new BugTracker());
            }
        }

    }
}