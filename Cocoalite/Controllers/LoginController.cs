using Cocoalite.Helpers;
using Cocoalite.Interfaces;
using Cocoalite.Models.Context;
using Cocoalite.Models.Entity;
using System;
using System.Data;

namespace Cocoalite.Controllers
{
    internal class LoginController
    {
        private const int PasswordMinLength = 6;
        private const int PasswordMaxLength = 20;
        private const int RecoveryCodeMinLength = 4;
        private const int RecoveryCodeMaxLength = 30;

        private readonly ILoginContext _context;

        public LoginController()
        {
            _context = new LoginContext();
        }

        public LoginController(ILoginContext context)
        {
            _context = context;
        }

        public bool Login(string username, string password)
        {
            AppUser? user = _context.GetUserByLogin(username, password);

            if (user == null)
                return false;

            LoginSession.SetUser(user);
            return true;
        }

        public bool ChangePassword(
            int userId,
            string oldPassword,
            string newPassword)
        {
            if (userId <= 0)
                throw new ArgumentException("ID user tidak valid.");

            if (string.IsNullOrWhiteSpace(oldPassword))
                throw new ArgumentException("Password lama tidak boleh kosong.");

            ValidasiPanjangPassword(newPassword);

            return _context.ChangePassword(userId, oldPassword, newPassword);
        }

        public bool ResetPasswordBySecurityAnswer(
            string username,
            string securityAnswer,
            string newPassword,
            string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username tidak boleh kosong.");

            if (string.IsNullOrWhiteSpace(securityAnswer))
                throw new ArgumentException("Jawaban keamanan tidak boleh kosong.");

            ValidasiPanjangPassword(newPassword);

            if (newPassword != confirmPassword)
                throw new ArgumentException("Konfirmasi password tidak sama.");

            return _context.ResetPasswordBySecurityAnswer(username, securityAnswer, newPassword);
        }

        public void SetRecoveryCode(int userId, string recoveryCode)
        {
            if (userId <= 0)
                throw new ArgumentException("ID user tidak valid.");

            ValidasiRecoveryCode(recoveryCode);

            _context.SetRecoveryCode(userId, recoveryCode);
        }

        public DataTable GetAllQcUsers()
        {
            return _context.GetAllQcUsers();
        }

        public void AddQcUser(
            string fullName,
            string username,
            string password,
            string recoveryCode)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Nama lengkap tidak boleh kosong.");

            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username tidak boleh kosong.");

            ValidasiPanjangPassword(password);
            ValidasiRecoveryCode(recoveryCode);

            _context.AddQcUser(fullName, username, password, recoveryCode);
        }

        public void DeleteQcUser(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("ID user tidak valid.");

            _context.DeleteQcUser(userId);
        }

     
        private void ValidasiPanjangPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password tidak boleh kosong.");

            if (password.Length < PasswordMinLength || password.Length > PasswordMaxLength)
                throw new ArgumentException(
                    $"Password harus terdiri dari {PasswordMinLength} sampai {PasswordMaxLength} karakter.");
        }

        private void ValidasiRecoveryCode(string recoveryCode)
        {
            if (string.IsNullOrWhiteSpace(recoveryCode))
                throw new ArgumentException("Kode pemulihan tidak boleh kosong.");

            if (recoveryCode.Length < RecoveryCodeMinLength || recoveryCode.Length > RecoveryCodeMaxLength)
                throw new ArgumentException(
                    $"Kode pemulihan harus terdiri dari {RecoveryCodeMinLength} sampai {RecoveryCodeMaxLength} karakter.");
        }
    }
}