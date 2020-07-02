
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public interface IOrderProcessorFactory
    {
        IOrderProcessor CreateOrderProcessor(Payment payment);
    }
}
