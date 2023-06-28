using System;
namespace Severino.Helpers.Password
{
	public interface IPassword
	{
		string GenerateSalt(int workFactor = 11);
		bool Compare(string rawPassword, string hashPassword);
		string GenerateHash(string password, string salt = "");
	}
}

