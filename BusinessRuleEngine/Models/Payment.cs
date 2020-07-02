namespace BusinessRuleEngine.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public Agent AgentDetail { get; set; }

        public ProductType ProductType { get; set; }
    }
}
