using System;
using BCrypt.Net;
using NUnit.Framework;
using Severino.Helpers.Password;

namespace UnitTests.Password
{
	public class HashGeneration
	{
        private IPassword _password = new PasswordHelper(BCrypt.Net.HashType.SHA512);

        [Test]
        public void GeneratePasswordHashWithoutRawValue_ShouldBeException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _password.GenerateHash(null));
            Assert.AreEqual(ex.Message, "Value cannot be null. (Parameter 'password')");
        }

        [Test]
        public void GeneratePasswordHash_ShouldBeNotNull()
        {
            var hash = _password.GenerateHash("my pretty password");
            Assert.IsNotNull(hash);
        }

        [Test]
        public void GeneratePasswordHashWithInvalidSalt_ShouldBeNotNull()
        {
            SaltParseException ex = Assert.Throws<SaltParseException>(() => _password.GenerateHash("master password", "a"));
            Assert.AreEqual(ex.Message, "Invalid salt version");
        }
    }
}

