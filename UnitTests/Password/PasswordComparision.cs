using System;
using BCrypt.Net;
using NUnit.Framework;
using Severino.Helpers.Password;

namespace UnitTests.Password
{
	public class PasswordComparision
	{
        private IPassword _password;

        [SetUp]
        public void Setup()
        {
            _password = new PasswordHelper(BCrypt.Net.HashType.SHA512);
        }

        [Test]
        public void CompareHashAndPassword_ShouldBeTrue()
        {
            var validation = _password.Compare("text", "$2a$11$dOpKtKO9.a/2agNRar3hW.BG2TF5b0C27uFjS.c64dWlRRP4rRoZ2");
            Assert.IsTrue(validation);
        }

        [Test]
        public void CompareHashAndPasswordWithoutPassword_ShouldReturnException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _password.Compare(null, "$2a$11$dOpKtKO9.a/2agNRar3hW.BG2TF5b0C27uFjS.c64dWlRRP4rRoZ2"));
            Assert.AreEqual(ex.Message, "Value cannot be null. (Parameter 'rawPassword')");
        }

        [Test]
        public void CompareHashAndPasswordWithoutSalt_ShouldReturnException()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _password.Compare("text", null));
            Assert.AreEqual(ex.Message, "Value cannot be null. (Parameter 'hashPassword')");
        }

        [Test]
        public void CompareHashAndPasswordWithNonValidHashPassword_ShouldReturnException()
        {
            var ex = Assert.Throws<SaltParseException>(() => _password.Compare("text", "abc123"));
            Assert.AreEqual(ex.Message, "Invalid salt version");
        }
    }
}

