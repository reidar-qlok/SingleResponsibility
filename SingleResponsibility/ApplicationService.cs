namespace SingleResponsibility
{
    internal class ApplicationService
    {
        // Deklarerar en privat readonly variabel för att hålla en referens till ConfigurationManager-objektet.
        private readonly ConfigurationManager _configManager;

        // Konstruktor för ApplicationService-klassen
        public ApplicationService()
        {
            // Initialiserar _configManager med en ny instans av ConfigurationManager
            _configManager = new ConfigurationManager();
        }

        // Metod som kör applikationen
        public void Run()
        {
            try
            {
                // Hämtar inställningen för applikationsnamn från konfigurationshanteraren
                string appName = _configManager.GetSetting("ApplicationName");
                // Hämtar inställningen för applikationsversion från konfigurationshanteraren
                string appVersion = _configManager.GetSetting("Version");
                // Hämtar inställningen för anslutningssträng från konfigurationshanteraren
                string connectionString = _configManager.GetSetting("ConnectionString");

                // Skriver ut applikationsnamn och version till konsolen
                Console.WriteLine($"Running {appName} version {appVersion}");
                // Skriver ut anslutningssträngen till konsolen
                Console.WriteLine($"Using connection string: {connectionString}");

                // Ytterligare logik för applikationen skulle komma här
            }
            catch (Exception ex)
            {
                // Fångar eventuella undantag och skriver ut ett felmeddelande till konsolen
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
