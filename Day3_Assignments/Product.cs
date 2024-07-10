using System;
namespace Product
{
    class program7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Prduct Id : ");
            int pId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Prduct Name : ");
            String pName = (Console.ReadLine());

            Console.WriteLine("Enter the Unit Price: ");
            double unitPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Quantity : ");
            int qty = int.Parse(Console.ReadLine());

            double totalAmount = unitPrice;
            Console.WriteLine("Total Amount : " + totalAmount);

            if (totalAmount > 1000 & totalAmount<3000)
            {
                double tenPerDis = unitPrice - (unitPrice * 0.1);
                Console.WriteLine("After Applying 10% Discount : " + tenPerDis);
            }

            else if (totalAmount > 3000 & totalAmount<5000)
            {
                double fifteenPerDis = unitPrice - (unitPrice * 0.15);
                Console.WriteLine("After Applying 15% Discount : " + fifteenPerDis);
            }
            else if (totalAmount > 5000)
            {
                double twentyPerDis = unitPrice - (unitPrice * 0.2);
                Console.WriteLine("After Applying 20% Discount : " + twentyPerDis);
            }
        }
    }
}