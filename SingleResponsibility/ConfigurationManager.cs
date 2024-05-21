namespace SingleResponsibility
{
    // En intern klass som hanterar konfigurationsinställningar
    internal class ConfigurationManager
    {
        // Metod för att hämta en inställning baserat på en nyckel
        public string GetSetting(string key)
        {
            // I ett verkligt scenario skulle detta läsa från en konfigurationsfil, t.ex. appsettings.json eller web.config
            // Här används en enkel inbäddad ordbok för demonstration
            var settings = new Dictionary<string, string>
            {
                { "ApplicationName", "MyApplication" }, // Nyckel och värde för applikationsnamn
                { "Version", "1.0.0" }, // Nyckel och värde för version
                { "ConnectionString", "Server=reidarserver;Database=PapperABDb;User Id=reidar;Password=@dmin123;" } // Nyckel och värde för anslutningssträng
            };

            // Kontrollerar om den angivna nyckeln finns i inställningarna
            if (settings.ContainsKey(key))
            {
                // Returnerar värdet för den angivna nyckeln
                return settings[key];
            }
            else
            {
                // Kastar ett undantag om nyckeln inte hittas
                throw new Exception($"Setting with key '{key}' not found.");
            }
        }
    }
}
