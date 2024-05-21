namespace SingleResponsibility
{
    internal class ConfigurationManager
    {
        public string GetSetting(string key)
        {
            // I ett verkligt scenario skulle detta läsa från en konfigurationsfil, t.ex. appsettings.json eller web.config
            // Här används en enkel inbäddad ordbok för demonstration
            var settings = new Dictionary<string, string>
            {
                { "ApplicationName", "MyApplication" },
                { "Version", "1.0.0" },
                { "ConnectionString", "Server=reidarserver;Database=PapperABDb;User Id=reidar;Password=@dmin123;" }
            };

            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            else
            {
                throw new Exception($"Setting with key '{key}' not found.");
            }
        }
    }
}
