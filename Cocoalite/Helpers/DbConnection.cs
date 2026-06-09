using Npgsql;
using System;
using System.Configuration;

namespace Cocoalite.Helpers
{
    public class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection()
        {
            string? envConn = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            if (!string.IsNullOrWhiteSpace(envConn))
            {
                _connectionString = envConn;
                return;
            }

            var configEntry = ConfigurationManager.ConnectionStrings["DbConnectionString"];

            if (configEntry != null && !string.IsNullOrWhiteSpace(configEntry.ConnectionString))
            {
                _connectionString = configEntry.ConnectionString;
                return;
            }

            throw new InvalidOperationException(
                "Connection string tidak ditemukan. " +
                "Tambahkan 'DbConnectionString' di App.config atau set environment variable 'DB_CONNECTION_STRING'.");
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}