using System.Diagnostics;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Classes
{
    public static class GlobalCrashHandler
    {
        public static void Handle(Exception ex, FiresharpData dataService)
        {
            try
            {
                // Salvo localmente primeiro
                MainFunctions newMainFunc = new MainFunctions();

                newMainFunc.Save_crash_log_to_file(ex);

                // Mostra mensagem imediatamente (UI thread livre)
                MessageBox.Show(
                    "Ops... ocorreu um erro inesperado.\n\n" +
                    "O erro foi enviado automaticamente para análise.\n" +
                    "O aplicativo será fechado.",
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                // Envia log em background e espera terminar
                Task.Run(async () =>
                {
                    try
                    {
                        if (dataService != null)
                        {
                            await dataService.Post_crashLog_on_dataBase(new CrashLog
                            {
                                Username = dataService.LocalAccount?.Username ?? "unidentified",
                                Message = ex.Message,
                                StackTrace = ex.ToString(),
                                Version = Main_classes.Local_app_Version,
                                Date = DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss")
                            });
                        }
                    }
                    catch { }
                }).GetAwaiter().GetResult();
            }
            catch { }

            Environment.Exit(1);
            Process.GetCurrentProcess().Kill();
        }
    }
}
