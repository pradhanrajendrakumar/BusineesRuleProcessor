namespace BusinessRuleEngine.Models
{

    public class OrderLineItem
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Address Address { get; set; }
        public string ItemName { get; set; }

        public OrderLineItem GenerateNewOrderLineItem()
        {
            return new OrderLineItem
            {
                Id = Id,
                User = User,
                Address = Address,
            };
        }
    }
}
