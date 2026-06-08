using Cocoalite.Helpers;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;
using System.Data;

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

        public bool ChangePassword(
    int userId,
    string oldPassword,
    string newPassword)
        {
            return context.ChangePassword(
                userId,
                oldPassword,
                newPassword
            );
        }

        public DataTable GetAllQcUsers()
        {
            return context.GetAllQcUsers();
        }

        public void AddQcUser(
            string fullName,
            string username,
            string password)
        {
            context.AddQcUser(
                fullName,
                username,
                password
            );
        }

        public void DeleteQcUser(int userId)
        {
            context.DeleteQcUser(userId);
        }
    }
}