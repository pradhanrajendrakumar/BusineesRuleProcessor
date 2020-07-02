namespace BusinessRuleEngine.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EMail { get; set; }
        public bool HasMembership { get; set; }
    }
}
