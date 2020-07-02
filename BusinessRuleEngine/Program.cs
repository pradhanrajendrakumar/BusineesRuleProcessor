using System;

using BusinessRuleEngine.Models;
using BusinessRuleEngine.Services;

namespace BusinessRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment()
            {
                PaymentId = 1001,
                ProductType = ProductType.ActivateMembership,
                AgentDetail = new Agent { AgentId = 100, FirstName = "Pratap", LastName = "B" }
            };

            OrderLineItem orderLineItem = new OrderLineItem
            {
                Id = 1,
                ItemName = "Premium",
                User = new User
                {
                    UserId = 1000,
                    EMail = "pradhan.rajendrakumar048@gmail.com",
                    FirstName = "Rajendra",
                    LastName = "Pradhan",
                    HasMembership = false
                },
                Address = new Address
                {
                    AddressLine1 = "Bengaluru",
                    City = "Bengaluru",
                    Country = "India",
                    Code = 560037.ToString()
                }
            };

            IOrderProcessorFactory orderProcessorFactory = new OrderProcessorFactory();

            IOrderProcessor orderProcessor = orderProcessorFactory.CreateOrderProcessor(payment);
            orderProcessor.ProcessOrder(orderLineItem);

            Console.ReadKey();
        }
    }
}
