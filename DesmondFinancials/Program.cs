using System;
using System.Collections.Generic;
namespace DesmondFinancials
{

    public delegate IList<decimal> InterestDel();
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("James", "Stuart", "0045504239", "Driver",  50, 60000M, 0.6, 5);
            Customer customer2 = new Customer("Samuel", "Olufemi", "4356937898", "Writer", 35, 60400M, 0.8, 3);
            Customer customer3 = new Customer("Samuel", "Bankole", "7755479799", "Teacher", 40, 50000M, 0.4, 4);
            Customer customer4 = new Customer("Mary", "Olugbemi", "0069404239", "Programmer", 44, 1000000M, 0.8, 7);
             Customer customer5 = new Customer("Sammy", "Olugbemi", "0069404239", "Doctor", 29, 1000000M, 0.8, 7);
              Customer customer6 = new Customer("Jane", "Stephens", "0069404239", "Journalist", 46, 1000000M, 0.8, 7);
            IList<Customer> customers = new List<Customer>(){customer1, customer2, customer3, customer4, customer5, customer6};
            Interest interest = new Interest(customers);
            InterestDel simpleinterestDel = interest.SimpleInterest;
            InterestDel compoundInterestDel = interest.CompoundInterest;
            IList<decimal> simpleInterests = simpleinterestDel();
            IList<decimal> compoundInterests = compoundInterestDel();

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{customers[i]}\nSimple Interest: {simpleInterests[i]:C}\nCompound Interest: {compoundInterests[i]:C}\n");
            }
        }
    }
}
