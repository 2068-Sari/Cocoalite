using Npgsql;

namespace Cocoalite.Helpers
{
    public class DbConnection
    {
        private readonly string connectionString =
            "Host=localhost;Port=2809;Username=postgres;Password=saripane*28;Database=cacaolite_db";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}