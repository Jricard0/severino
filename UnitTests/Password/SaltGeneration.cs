using System;
using NUnit.Framework;
using Severino.Helpers.Password;

namespace UnitTests.Password
{
    [TestFixture]
	public class SaltGeneration
	{
        private IPassword _password = new PasswordHelper(BCrypt.Net.HashType.SHA512);

        [Test]
        public void GenerateDefaultSalt_ShouldNotBeNull()
        {
            var salt = _password.GenerateSalt();
            Assert.IsNotNull(salt);
        }

        [Test]
        public void GenerateSaltWithFourteenRounds_ShouldNotBeNull()
        {
            var salt = _password.GenerateSalt(workFactor: 14);
            Assert.IsNotNull(salt);
        }

        [Test]
        public void GeneratePassword_ShouldNotBeNull()
        {
            var password = _password.GenerateHash("text");
            Assert.IsNotNull(password);
        }

        [Test]
        public void GeneratePasswordWithSalt_ShouldNotBeNull()
        {
            var salt = _password.GenerateSalt();
            Assert.IsNotNull(salt);

            var password = _password.GenerateHash("text", salt);
            Assert.IsNotNull(password);
        }
    }
}

