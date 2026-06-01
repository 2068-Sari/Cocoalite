using Cocoalite.Models;

namespace Cocoalite.Helpers
{
    internal static class LoginSession
    {
        public static AppUser? CurrentUser { get; private set; }
        public static void SetUser(AppUser user)
        {
            CurrentUser = user;
        }

        public static void Clear()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static bool IsAdmin()
        {
            return CurrentUser != null && CurrentUser.Role == "admin";
        }

        public static bool IsQualityController()
        {
            return CurrentUser != null && CurrentUser.Role == "qc";
        }
    }
}