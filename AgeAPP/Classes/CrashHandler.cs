using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Classes
{
    public static class GlobalCrashHandler
    {
        private static bool _handling;

        public static async Task HandleAsync(Exception ex, FiresharpData dataService)
        {
            if (_handling) return;
            _handling = true;

            try
            {
                if (dataService != null)
                {
                    await dataService.Post_crashLog_on_dataBase(new CrashLog
                    {
                        Username = dataService.LocalAccount?.Username ?? "unidentified",
                        Message = ex.Message,
                        StackTrace = ex.ToString(),
                        Version = Application.ProductVersion,
                        Date = DateTime.UtcNow.ToString("dd-MM-yyyy HH:mm:ss")
                    });
                }

                MessageBox.Show(
                    "Ops... ocorreu um erro inesperado.\n\n" +
                    "O erro foi enviado automaticamente para análise.\n" +
                    "O aplicativo será fechado.",
                    "Erro inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch
            {
                // silêncio absoluto
            }
            finally
            {
                _handling = false;

                // pequena espera para garantir envio
                await Task.Delay(1000);

                Environment.Exit(1);
            }
        }
    }
}
