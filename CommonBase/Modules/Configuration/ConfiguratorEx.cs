
namespace CommonBase.Modules.Configuration
{
    partial class Configurator
    {
        static partial void ClassConstructed()
        {
            Environment.SetEnvironmentVariable("ConnectionStrings:SqliteDefaultConnection", "Data Source=C:\\Users\\ggehr\\source\\repos\\leoggehrer\\Data\\QTTaxiDriverDb.db");
        }
    }
}
