
using System;

using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class AgentCommissionGenerator : ICommissionGenerator
    {
        private readonly Agent agent;

        public AgentCommissionGenerator(Agent agent)
        {
            this.agent = agent;
        }
        public void GenerateCommission()
        {
            Console.WriteLine($"Commission generated for {agent.AgentId}");
        }
    }
}
