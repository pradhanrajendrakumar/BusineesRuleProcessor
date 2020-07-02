
using System;

using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class ActivateMembership : IMembershipProcessor
    {
        private readonly IEmailProvider emailProvider;

        public ActivateMembership(IEmailProvider emailProvider)
        {
            this.emailProvider = emailProvider;
        }
        public void ProcessMembership(User user)
        {
            user.HasMembership = true;
            Console.WriteLine($"Membership activated for the user:{user.FirstName}, {user.LastName}");
            emailProvider.Send(user.EMail, " Membership activated", "Your membership activated successfully.");
        }
    }
}
