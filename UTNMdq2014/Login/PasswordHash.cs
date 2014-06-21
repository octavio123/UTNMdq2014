using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using UTNMdq2014.Helpers;

namespace UTNMdq2014.Login
{
    public class PasswordHash : IEquatable<PasswordHash>
    {
        private string hash;
        private string salt; // Originalmente readonly, removido para serializacion :\

        public string Hash { get { return hash; } set { hash = value; } } // Originalmente sin set
        public string Salt { get { return salt; } set { salt = value; } }

        public PasswordHash() {}

        public PasswordHash(string hash, string salt)
        {
            Asegurar.NoEsNulo(hash, "hash", "La hash no puede ser nula.");
            Asegurar.NoEsNulo(salt, "salt", "La sal no puede ser nula.");

            this.hash = hash;
            this.salt = salt;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PasswordHash);
        }

        public bool Equals(PasswordHash a)
        {
            if (a == null) return false;
            return ( Salt == a.Salt && Hash == a.Hash );
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Hash;
        }
    }
}
