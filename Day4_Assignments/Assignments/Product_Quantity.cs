using System;
namespace Day4_product
{
    class Product
    {
        public static void Main(string[] args)
        {
            //Intialize the total amount
            double totalAmount = 0;

            //read the quantities and prices for the five products from the user
            for(int i = 1; i <=5 ; i++) 
            { 
            
            Console.WriteLine($"Enter the price of the product  {i} :");
            double price = double.Parse( Console.ReadLine() );

            Console.WriteLine($"Enter the quantity of the product  {i} :");
            int quantity = int.Parse( Console.ReadLine() );

                double amount = price * quantity;
                 totalAmount += amount;
            }
            Console.WriteLine($"The total amount for all products is : {totalAmount}");
        }
}}