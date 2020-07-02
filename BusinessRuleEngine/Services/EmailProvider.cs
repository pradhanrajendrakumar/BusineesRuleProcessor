
using System;

namespace BusinessRuleEngine.Services
{
    public class EmailProvider : IEmailProvider
    {
        public void Send(string emailAddress, string subject, string message)
        {
            Console.WriteLine($"Email deliverd to {emailAddress}, subject line {subject} with message body {message} ");
        }
    }
}
