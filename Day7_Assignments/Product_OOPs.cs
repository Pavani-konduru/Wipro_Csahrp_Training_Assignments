using System;
namespace Product_OOPs
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public Product(int pId)
        {
            pId = ProductId;
        }
        
    }
    class program
    {
        public static void Main(string[] args)
        {
            Product p = new Product(0);
            p.ProductId = 123;

            p.ProductName = "Mobile";
            p.UnitPrice = 20000;
            p.Quantity = 2;

            Console.WriteLine("_______________Product Details_______________");
            Console.WriteLine();
            Console.WriteLine("Product Id : " + p.ProductId);
            Console.WriteLine("Product Name : " + p.ProductName);
            Console.WriteLine("Product Unit Price :" + p.UnitPrice);
            Console.WriteLine("Quantity : " + p.Quantity);

            Console.WriteLine();

        }
    }
}