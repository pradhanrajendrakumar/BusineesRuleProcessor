
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class PhysicalProductOrderProcessor : IOrderProcessor
    {
        private readonly IPackingSlipGenerator packingSlipGenerator;
        private readonly ICommissionGenerator commissionGenerator;

        public PhysicalProductOrderProcessor(IPackingSlipGenerator packingSlipGenerator, ICommissionGenerator commissionGenerator)
        {
            this.packingSlipGenerator = packingSlipGenerator;
            this.commissionGenerator = commissionGenerator;
        }
        public void ProcessOrder(OrderLineItem order)
        {
            packingSlipGenerator.Generate(order);
            commissionGenerator.GenerateCommission();
        }
    }
}
