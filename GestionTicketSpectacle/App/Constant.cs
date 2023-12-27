namespace GestionTicketSpectacle.App
{
    public static class Constant
    {
        public const string GoogleSheetID = "1eXWrL1M4ZFpYYGjFN5vcifT7TfUCTt3zIwTrYf8knv0";
        public const string GoogleSheetApiKey = "AIzaSyBt2jSL-S9NFt4QoikvDveRSv6Jez75qb4";
        public const string GoogleSheetName = "Data";

        public const string MessageBoxIncorrectLogin= "Error please check your username/password";
        public const string MessageBoxErrorTitle = "Error";
        public const string MessageBoxErrorOpeningConnection = "Error opening database connection: ";
        public const string MessageBoxErrorClosingConnection = "Error closing database connection: ";
        
        public const string ConsoleUserNotFound= "Error checking user existence: ";
       
        public const string ExceptionUnsuportedEvent = "Error : This event type doesn't exist";
        public const string ExceptionEventWithoutIcon = "Error : an event must have an icon";

        public const string BDD_KelvinConnectionString= "Data Source = MSI; Initial Catalog = TpGestionTicketSpectacle; User ID = test2; Password = root";
        public const string BDD_RomainConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TpGestionTicketSpectacle;Integrated Security=True;User ID=Exarilo;";

        public const string DefaultConnexionUsername = "admin";
        public const string DefaultConnexionPassword = "admin";
    }
}
