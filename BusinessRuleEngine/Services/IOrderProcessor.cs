
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{

    public interface IOrderProcessor
    {
        /// <summary>
        ///  Processing the order line item,The Order line item would be Book, video, Membership or any physical product items
        /// </summary>
        /// <param name="orderLineItem"></param>
        void ProcessOrder(OrderLineItem orderLineItem);
    }
}
