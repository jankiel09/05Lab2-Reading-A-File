namespace _05Lab1
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
         // Application.Run(new FormLab1());
           // Application.Run(new FrmRegistration());

             Application.Run(new FrmOpenFile());
             Application.Run(new FrmStudentRecord());
        }
    }
}