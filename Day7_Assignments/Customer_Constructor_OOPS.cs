using System;
using System.Xml.Serialization;
namespace OOPs
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public String CustomerCity { get; set; }
  
        public Customer()
        {
            CustomerId = CustomerId;
            CustomerName = " ";
            CustomerCity = " ";          
        }
        public Customer(int cid)
        {
            CustomerId = cid;
        }

        public Customer(int cid, string cname)
        {
            CustomerId = cid;
            CustomerName = cname;
        }
        public Customer(int cid, string cname, string ccity)
        {
            CustomerId = cid;
            CustomerName = cname;
            CustomerCity = ccity;
        }
        public void ShowDetails(int  cid, string cname, string ccity)
        {
            Console.WriteLine("Customer Details :: Id:{0}, Name:{1}, City:{2}",cid, cname, ccity);

        }
    }
    class Customer_Constructor_OOPS
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer(10256);
            Customer c3 = new Customer(10256, "Scott");
            Customer c4 = new Customer(10256, "Scott", "hyd");

           // Console.WriteLine("Customer Details :: Id: {0}, Name : {1}, City : {2} ", c4.CustomerId, c4.CustomerName, c4.CustomerCity);
          

            c1.ShowDetails(c1.CustomerId,c1.CustomerName,c1.CustomerCity);
            c2.ShowDetails(c2.CustomerId, c2.CustomerName, c2.CustomerCity);
            c3.ShowDetails(c3.CustomerId, c3.CustomerName, c3.CustomerCity);
            c4.ShowDetails(c4.CustomerId, c4.CustomerName, c4.CustomerCity);

            Console.WriteLine();




        }
        }
    }
