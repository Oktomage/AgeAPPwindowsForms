namespace AgeAPP.Classes
{
    public class AgeApp_settings
    {
        public string Lastest_appVersion = Main_classes.Local_app_Version;
        public int Kfactor { get; set; } = 10;
        public int maxRatingDelta { get; set; } = 10;

        public Dictionary<string, float> MatchSize_multipliers { get; set; } = new Dictionary<string, float>
        {
            { "1v1", 0.0f },
            { "2v2", 0.0f },
            { "3v3", 0.0f },
            { "4v4", 0.0f },
            { "FFA", 0.0f }
        };

        public int maxInactiveDays { get; set; } = 30;

        public class Settings
        {
            public int Kfactor { get; set; }
            public int maxRatingDelta { get; set; }
            public Dictionary<string, float> MatchSize_multipliers { get; set; }
            public string Version { get; set; }
            public int maxInactiveDays { get; set; }
        }

        public async Task Get_settings()
        {
            var settings = await FMain.Data_service.Get_appSettings();

            if (settings == null)
                return;

            Kfactor = settings.Kfactor;
            maxRatingDelta = settings.maxRatingDelta;
            Lastest_appVersion = settings.Version;
            maxInactiveDays = settings.maxInactiveDays;

            if (settings.MatchSize_multipliers != null)
                MatchSize_multipliers = settings.MatchSize_multipliers;
        }
    }
}