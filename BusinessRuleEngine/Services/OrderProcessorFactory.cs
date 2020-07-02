
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class OrderProcessorFactory : IOrderProcessorFactory
    {
        public IOrderProcessor CreateOrderProcessor(Payment payment)
        {
            IOrderProcessor orderProcessor = null;
            switch (payment.ProductType)
            {
                case ProductType.PhysicalProduct:
                    orderProcessor = new PhysicalProductOrderProcessor(
                        new PackingSlipGenerator(),
                        new AgentCommissionGenerator(payment.AgentDetail));
                    break;
                case ProductType.Book:
                    orderProcessor = new PhysicalProductOrderProcessor(
                        new RoyaltyDepartmentPackingSlip(new PackingSlipGenerator()),
                        new AgentCommissionGenerator(payment.AgentDetail));
                    break;
                case ProductType.ActivateMembership:
                    orderProcessor = new MembershipOrderProcessor(new ActivateMembership(new EmailProvider()));
                    break;
                case ProductType.UpgradeMembership:
                    orderProcessor = new MembershipOrderProcessor(new UpgradeMembership(new EmailProvider()));
                    break;
                case ProductType.Video:
                    orderProcessor = new VideoOrderProcessor();
                    break;
                default:
                    break;
            }

            return orderProcessor;
        }
    }
}
