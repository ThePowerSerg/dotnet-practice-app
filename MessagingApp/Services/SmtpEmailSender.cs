namespace MessagingApp.Services
{
    // Stands in for a real SMTP client (e.g. MailKit, SendGrid). This is the
    // one class allowed to know how email actually gets sent.
    public class SmtpEmailSender : IEmailSender
    {
        public void Send(string toAddress, string body)
        {
            Console.WriteLine($"Emailing {toAddress}: {body}");
        }
    }
}
