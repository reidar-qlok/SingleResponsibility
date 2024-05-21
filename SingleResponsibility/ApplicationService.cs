namespace SingleResponsibility
{
    internal class ApplicationService
    {
        private readonly ConfigurationManager _configManager;

        public ApplicationService()
        {
            _configManager = new ConfigurationManager();
        }

        public void Run()
        {
            try
            {
                string appName = _configManager.GetSetting("ApplicationName");
                string appVersion = _configManager.GetSetting("Version");
                string connectionString = _configManager.GetSetting("ConnectionString");

                Console.WriteLine($"Running {appName} version {appVersion}");
                Console.WriteLine($"Using connection string: {connectionString}");

                // Ytterligare logik för applikationen skulle komma här
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
