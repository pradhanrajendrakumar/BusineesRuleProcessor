
using System;

using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class PackingSlipGenerator : IPackingSlipGenerator
    {
        public void Generate(OrderLineItem order)
        {
            Console.WriteLine($"Generate packing slip for the order {order.Id}, Address {order.Address.AddressLine1}");
        }
    }
}
