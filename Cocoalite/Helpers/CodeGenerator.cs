using System;
using System.Threading;

namespace Cocoalite.Helpers
{
    public static class CodeGenerator
    {
        private static readonly ThreadLocal<Random> _random =
            new ThreadLocal<Random>(() => new Random());

        private static Random Rng => _random.Value!;

        public static string GenerateReceivingCode()
        {
            return "RCV-" + Rng.Next(1, 1000).ToString("D3");
        }

        public static string GenerateBatchCode()
        {
            return "BTH-" + Rng.Next(1, 1000).ToString("D3");
        }

        public static string GenerateShipmentCode()
        {
            return "SHP-" + Rng.Next(1000, 99999).ToString();
        }
    }
}