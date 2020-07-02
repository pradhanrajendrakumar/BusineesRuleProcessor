
using System;

using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.Services
{
    public class RoyaltyDepartmentPackingSlip : IPackingSlipGenerator
    {
        private readonly IPackingSlipGenerator packingSlipGenerator;

        public RoyaltyDepartmentPackingSlip(IPackingSlipGenerator packingSlipGenerator)
        {
            this.packingSlipGenerator = packingSlipGenerator;
        }
        public void Generate(OrderLineItem order)
        {
            packingSlipGenerator.Generate(order);
            Console.WriteLine("Slip generated for Royalty department");
        }
    }
}
