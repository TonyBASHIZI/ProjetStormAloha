namespace ProjetStormAloha.Classes.Config
{
    public abstract class Constant
    {
        public abstract class Database
        {
            public static string InitialDirectory = AppConfig.InitialDirectory;
            public static string Path = AppConfig.GetConnectionString;
            public static string Backup = AppConfig.BackupDirectory;
        }

        public abstract class Table
        {
            public static string Client = "client";
            public static string Carte = "carte";
            public static string Compte = "compte";
            public static string Agent = "agent";
            public static string Pos = "pos";
        }
    }
}
