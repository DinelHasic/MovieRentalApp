using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace MovieRental.Storage.Helper
{
    internal static class HashingPassword
    {
        public static string GetHashedPassword(string password)
        {
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new();

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] passwordHash = mD5CryptoServiceProvider.ComputeHash(passwordBytes);

            string hashedPasword = Encoding.ASCII.GetString(passwordHash);

            return hashedPasword;
        }
    }
}
