using Cocoalite.Helpers;
using Cocoalite.Interfaces;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;
using System.Data;

namespace Cocoalite.Controllers
{
    internal class LoginController
    {
        private readonly ILoginContext context;

        public LoginController()
        {
            context = new LoginContext();
        }

        public LoginController(ILoginContext context)
        {
            this.context = context;
        }

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

        public bool ResetPasswordBySecurityAnswer(
            string username,
            string securityAnswer,
            string newPassword,
            string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username tidak boleh kosong.");
            }

            if (string.IsNullOrWhiteSpace(securityAnswer))
            {
                throw new ArgumentException("Jawaban keamanan tidak boleh kosong.");
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                throw new ArgumentException("Password baru tidak boleh kosong.");
            }

            if (newPassword.Length < 6 || newPassword.Length > 20)
            {
                throw new ArgumentException("Password harus terdiri dari 6 sampai 20 karakter.");
            }

            if (newPassword != confirmPassword)
            {
                throw new ArgumentException("Konfirmasi password tidak sama.");
            }

            return context.ResetPasswordBySecurityAnswer(
                username,
                securityAnswer,
                newPassword
            );
        }

        public void SetRecoveryCode(int userId, string recoveryCode)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("ID user tidak valid.");
            }

            if (string.IsNullOrWhiteSpace(recoveryCode))
            {
                throw new ArgumentException("Kode pemulihan tidak boleh kosong.");
            }

            if (recoveryCode.Length < 4 || recoveryCode.Length > 30)
            {
                throw new ArgumentException("Kode pemulihan harus terdiri dari 4 sampai 30 karakter.");
            }

            context.SetRecoveryCode(userId, recoveryCode);
        }
        public DataTable GetAllQcUsers()
        {
            return context.GetAllQcUsers();
        }

        public void AddQcUser(
     string fullName,
     string username,
     string password,
     string recoveryCode)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException("Nama lengkap tidak boleh kosong.");
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username tidak boleh kosong.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password tidak boleh kosong.");
            }

            if (password.Length < 6 || password.Length > 20)
            {
                throw new ArgumentException("Password harus terdiri dari 6 sampai 20 karakter.");
            }

            if (string.IsNullOrWhiteSpace(recoveryCode))
            {
                throw new ArgumentException("Kode pemulihan tidak boleh kosong.");
            }

            if (recoveryCode.Length < 4 || recoveryCode.Length > 30)
            {
                throw new ArgumentException("Kode pemulihan harus terdiri dari 4 sampai 30 karakter.");
            }

            context.AddQcUser(
                fullName,
                username,
                password,
                recoveryCode
            );
        }

        public void DeleteQcUser(int userId)
        {
            context.DeleteQcUser(userId);
        }
    }
}