using SE_project.controllers;

namespace SE_project
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
            //DatabaseManagement.DatabaseCreate();
            TestTypeManagement.Initialize();
            UserManagement.Initialize();
            Application.Run(new LoginRegisterView());
        }
    }
}