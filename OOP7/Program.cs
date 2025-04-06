using OOP7.Controllers;

namespace OOP7
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
            using(WelcomeForm welcome = new WelcomeForm())
            {
                welcome.ShowDialog();
            }
            CallController callController = new CallController();
            Application.Run(new MainForm(callController));
        }
    }
}