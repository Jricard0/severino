using System;
using System.Net.Mail;
namespace Severino.Helpers.Mail
{
	public interface IMail
	{
		Task<bool> Send(MailAddress receiver, string subject, string body, bool isBodyHTML);
	}
}

