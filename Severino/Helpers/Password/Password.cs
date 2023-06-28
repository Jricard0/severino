using System;
using BCrypt.Net;

namespace Severino.Helpers.Password
{
	public class PasswordHelper : IPassword
	{
        private readonly HashType _hashType;
        private readonly bool _enhanceEntropy;

        public PasswordHelper(HashType hashType, bool enhanceEntropy = true)
        {
            _hashType = hashType;
            _enhanceEntropy = enhanceEntropy;
        }

        public bool Compare(string rawPassword, string hashPassword)
        {
            ArgumentNullException.ThrowIfNull(rawPassword);
            ArgumentNullException.ThrowIfNull(hashPassword);

            return BCrypt.Net.BCrypt.Verify(rawPassword, hashPassword, _enhanceEntropy, _hashType);
        }

        public string GenerateHash(string password, string salt = "")
        {
            ArgumentNullException.ThrowIfNull(password);

            if (string.IsNullOrWhiteSpace(salt))
                salt = GenerateSalt();

            return BCrypt.Net.BCrypt.HashPassword(password, salt, _enhanceEntropy, _hashType);
        }

        public string GenerateSalt(int workFactor = 11)
        {
            return BCrypt.Net.BCrypt.GenerateSalt(workFactor);
        }
    }
}

