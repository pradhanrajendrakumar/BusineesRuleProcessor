
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class VideoOrderProcessor : IOrderProcessor
    {
        private readonly IPackingSlipGenerator packingSlipGenerator;

        public VideoOrderProcessor(IPackingSlipGenerator packingSlipGenerator)
        {
            this.packingSlipGenerator = packingSlipGenerator;
        }
        public void ProcessOrder(OrderLineItem order)
        {
            packingSlipGenerator.Generate(order);
            if (order.ItemName == "Learning to Ski")
            {
                var item = order.GenerateNewOrderLineItem();
                item.ItemName = "First Aid";
                packingSlipGenerator.Generate(item);
            }
        }
    }


}
