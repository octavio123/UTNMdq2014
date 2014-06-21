using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTNMdq2014.Login
{
    public static class PasswordHashFactory
    {
        private static ICryptoService service;

        static PasswordHashFactory()
        {
            service = new PBKDF2();
        }

        public static PasswordHash HashPasswordWithSalt(string password, string salt)
        {
            string hash = service.Compute(password, salt);
            return new PasswordHash(hash, salt);
        }

        public static PasswordHash HashPassword(string password)
        {
            string hash = service.Compute(password);
            string salt = service.Salt;
            return new PasswordHash(hash, salt);
        }

        public static bool MatchPassword(PasswordHash a, PasswordHash b)
        {
            return a.Equals(b);
        }
    }
}
