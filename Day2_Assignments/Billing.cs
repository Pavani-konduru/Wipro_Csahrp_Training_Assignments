namespace Billing
{
    public class Billing
    { 
        public static void Main(string[] args)
        {
            double pizzaPrice = 300;
            double puffPrice = 50;
            double pepsiPrice = 130;
            double gstRate = 0.09;
            double cessRate = 0.09;

            Console.WriteLine("Enter Number of Pizzas: ");
            int numOfPizzas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Puffss: ");
            int numOfPuffs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Pepsis: ");
            int numOfPepsis = Convert.ToInt32(Console.ReadLine());

            double totalPizzaCost = numOfPizzas * pizzaPrice;
            double totalPuffCost = numOfPuffs * puffPrice;
            double totalPepsiCost = numOfPepsis * pepsiPrice;
            double totalCostBeforeTax = totalPizzaCost + totalPuffCost + totalPepsiCost;
            double gstAmount = gstRate * totalCostBeforeTax;
            double cessAmount = cessRate * totalCostBeforeTax;
            double totalCost = totalCostBeforeTax + gstAmount + cessAmount;

            Console.WriteLine("Total cost of pizzas is : Rs. " + totalPizzaCost);
            Console.WriteLine("Total cost of puffs is : Rs. " + totalPuffCost);
            Console.WriteLine("Total cost of pepsis is : Rs. " + totalPepsiCost);
            Console.WriteLine("Total Before tax : Rs. " + totalCostBeforeTax);
            Console.WriteLine("GST price : Rs. " + gstAmount);
            Console.WriteLine("CESS price : Rs. " + cessAmount);
            Console.WriteLine("Total : Rs. " + totalCost);
        }
    }
}