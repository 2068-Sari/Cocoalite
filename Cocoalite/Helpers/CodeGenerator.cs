using System;
using System.Threading;

namespace Cocoalite.Helpers
{
    public static class CodeGenerator
    {
        private static readonly ThreadLocal<Random> _random =
            new ThreadLocal<Random>(() => new Random());

        private static Random Rng => _random.Value!;

        private static string ShortDate()
        {
            return DateTime.Now.ToString("MMdd");
        }

        public static string GenerateReceivingCode()
        {
            return $"RCV-{ShortDate()}-{Rng.Next(0, 1000):D3}";
        }

        public static string GenerateBatchCode()
        {
            return $"BTH-{ShortDate()}-{Rng.Next(0, 1000):D3}";
        }

        public static string GenerateShipmentCode()
        {
            return $"SHP-{ShortDate()}-{Rng.Next(0, 1000):D3}";
        }
    }
}