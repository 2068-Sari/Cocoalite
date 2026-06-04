using Npgsql;

namespace Cocoalite.Helpers
{
    public class DbConnection
    {
        private readonly string connectionString =
            "Host=localhost;Port=5432;Username=postgres;Password=icha2006@;Database=ProjectCacaoLite";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}