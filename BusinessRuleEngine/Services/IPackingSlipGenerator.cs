
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public interface IPackingSlipGenerator
    {
        void Generate(OrderLineItem order);
    }
}
