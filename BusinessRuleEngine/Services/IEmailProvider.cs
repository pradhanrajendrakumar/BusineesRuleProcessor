namespace BusinessRuleEngine.Services
{
    public interface IEmailProvider
    {
        void Send(string emailAddress, string subject, string message);
    }
}
