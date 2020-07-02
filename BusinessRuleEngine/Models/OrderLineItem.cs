namespace BusinessRuleEngine.Models
{

    public class OrderLineItem
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Address Address { get; set; }
        public string ItemName { get; set; }
    }
}
