namespace RoKa.Application.Interfaces
{
	public interface IEmailService
	{
    	Task SendEmailAsync(string toEmail, string subject, string message, string fromName, string fromEmail);
	}
}
