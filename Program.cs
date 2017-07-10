using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. In Main method, create a list of value tuples that will hold individual transactions for a hardware business. 
            // Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
            
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            // 2. Add 5, or more, transactions to the list.

            transactions.Add(("hammers", .25, 10));
            transactions.Add(("nails", .10, 50));
            transactions.Add(("screwdrivers", 2.00, 15));
            transactions.Add(("duct tape", 2.50, 25));
            transactions.Add(("paint brushes", 1.25, 40));

            Console.WriteLine("List of Transactions:");
            foreach ((string product, double amount, int quantity) t in transactions){
                Console.WriteLine(t);
            }

            // 3. Iterate over the list of tuples and calculate how many total products you sold today, 
            // and what your total revenue was.

            int productsSold = 0;
            double productRevenue = 0;
            foreach ((string product, double amount, int quantity) t in transactions){
                productsSold += t.quantity;
                productRevenue += (t.amount * t.quantity);
            }

            Console.WriteLine("Total Products Sold:");
            Console.WriteLine(productsSold);
            Console.WriteLine("Total Revenue:");
            Console.WriteLine($"{productRevenue:C}");
        }
    }
}



