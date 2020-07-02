
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class MembershipOrderProcessor : IOrderProcessor
    {
        private readonly IMembershipProcessor membershipProcessor;

        public MembershipOrderProcessor(IMembershipProcessor membershipProcessor)
        {
            this.membershipProcessor = membershipProcessor;
        }
        public void ProcessOrder(OrderLineItem order)
        {
            membershipProcessor.ProcessMembership(order.User);
        }
    }
}
