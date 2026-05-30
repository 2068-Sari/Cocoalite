namespace Cocoalite.Helpers
{
    internal static class LoginSession
    {
        public static int UserId { get; set; }
        public static string FullName { get; set; } = "";
        public static string Username { get; set; } = "";
        public static string Role { get; set; } = "";

        public static void Clear()
        {
            UserId = 0;
            FullName = "";
            Username = "";
            Role = "";
        }
    }
}