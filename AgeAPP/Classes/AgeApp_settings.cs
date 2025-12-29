namespace AgeAPP.Classes
{
    public class AgeApp_settings
    {
        public string Lastest_appVersion = Main_classes.Local_app_Version;
        public int Kfactor { get; set; } = 20;

        public class Settings
        {
            public int Kfactor { get; set; }
            public string Version { get; set; }
        }

        public async void Get_settings()
        {
            var settings = new Settings();
            settings = await FMain.Data_service.Get_appSettings();

            Kfactor = settings.Kfactor;
            Lastest_appVersion = settings.Version;
        }
    }
}
