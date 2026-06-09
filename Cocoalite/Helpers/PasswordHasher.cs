using System;
using System.Security.Cryptography;

namespace Cocoalite.Helpers
{
    public static class PasswordHasher
    {
        private const int Iterations = 100_000;
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const string Version = "v1";

        public static string Hash(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password tidak boleh kosong.", nameof(password));

            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = Pbkdf2(password, salt);

            return $"{Version}:{Iterations}:{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
        }

        public static bool Verify(string password, string storedHash)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(storedHash))
                return false;

            string[] parts = storedHash.Split(':');

            if (parts.Length != 4 || parts[0] != Version)
                return false;

            if (!int.TryParse(parts[1], out int iterations))
                return false;

            byte[] salt = Convert.FromBase64String(parts[2]);
            byte[] expectedHash = Convert.FromBase64String(parts[3]);
            byte[] actualHash = Pbkdf2(password, salt, iterations);

            return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
        }

        private static byte[] Pbkdf2(string password, byte[] salt, int iterations = Iterations)
        {
            using var deriveBytes = new Rfc2898DeriveBytes(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256);

            return deriveBytes.GetBytes(HashSize);
        }
    }
}