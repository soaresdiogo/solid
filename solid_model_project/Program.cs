using System;
using solid_model_project.Interfaces;
using solid_model_project.Factories;
using solid_model_project.Enums;

namespace solid_model_project
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculatesLoyaltyDiscount loyaltyDiscount =  
                new CalculatesLoyaltyDiscount();

            ICalculatesAccountStatusDiscountFactory accountDiscount = 
                new CalculatesAccountStatusDiscountFactory();

            DiscountManager discountManager = 
                new DiscountManager(loyaltyDiscount, accountDiscount);

            Console.WriteLine("Purchase value 1000 and loyalty 10 years (5%)\n");

            var result1 = 
                discountManager.ApplyDiscount(1000, CustomerAccountStatus.CommomCustomer, 10);
            Console.WriteLine($"Customer {CustomerAccountStatus.CommomCustomer}, the discount value is: {result1}");

            var result2 = 
                discountManager.ApplyDiscount(1000, CustomerAccountStatus.SpecialCustomer, 10);
            Console.WriteLine($"Customer {CustomerAccountStatus.SpecialCustomer}, the discount value is: {result2}");

            var result3 = 
                discountManager.ApplyDiscount(1000, CustomerAccountStatus.VipCustomer, 10);
            Console.WriteLine($"Customer {CustomerAccountStatus.VipCustomer}, the discount value is: {result3}");

            Console.WriteLine("\n\nPurchase price 1000 and loyalty 4 years (4%)\n");

            var result4 = 
                discountManager.ApplyDiscount(1000, CustomerAccountStatus.CommomCustomer, 4);
            Console.WriteLine($"Customer {CustomerAccountStatus.CommomCustomer}, the discount value is: {result4}");

            var result5 = 
                discountManager.ApplyDiscount(1000, CustomerAccountStatus.SpecialCustomer, 4);
            Console.WriteLine($"Customer {CustomerAccountStatus.SpecialCustomer}, the discount value is: {result5}");

            var result6 = 
                discountManager.ApplyDiscount(1000, CustomerAccountStatus.VipCustomer, 4);
            Console.WriteLine($"Customer {CustomerAccountStatus.VipCustomer}, the discount value is: {result6}");
        }
    }
}
