using Cocoalite.Helpers;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;

namespace Cocoalite.Controllers
{
    internal class LoginController
    {
        private readonly LoginContext context = new LoginContext();

        public bool Login(string username, string password)
        {
            AppUser? user = context.GetUserByLogin(username, password);

            if (user == null)
            {
                return false;
            }

            LoginSession.SetUser(user);
            return true;
        }
    }
}