using AgeAPP.Classes;

namespace AgeAPP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var dataService = new FiresharpData();
            FMain.Data_service = dataService;


            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += (sender, args) =>
            {
                GlobalCrashHandler.Handle(args.Exception, dataService);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                if (args.ExceptionObject is Exception ex)
                    GlobalCrashHandler.Handle(ex, dataService);
            };

            Application.Run(new FMain());
        }
    }
}