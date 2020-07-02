
using System;

using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class UpgradeMembership : IMembershipProcessor
    {
        private readonly IEmailProvider emailProvider;

        public UpgradeMembership(IEmailProvider emailProvider)
        {
            this.emailProvider = emailProvider;
        }
        public void ProcessMembership(User user)
        {
            user.HasMembership = true;
            Console.WriteLine($"Membership upgraded for the user:{user.FirstName}, {user.LastName}");
            emailProvider.Send(user.EMail, " Membership upgrade", "Your membership upgraded successfully.");
        }
    }
}
