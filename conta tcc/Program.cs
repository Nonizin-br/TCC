using System.Net.Http;


namespace conta_tcc
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
            HttpClient client = new HttpClient();
            Application.Run(new Welcome(client));
        }

        public static void loadHome()
        {
            Application.Run(new Home());
        }
    }
}