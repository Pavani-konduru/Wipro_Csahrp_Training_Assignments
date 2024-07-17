namespace FirstConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int id;
            String name;
            double salary;
            bool isContractEmp;
            string deptNo;
            String emailId;

            Console.WriteLine("Enter the Employee id : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the Basic Salary of Employee : ");
            salary = double.Parse(Console.ReadLine());

            Console.WriteLine("is Contract Employee : ");
            isContractEmp = bool.Parse(Console.ReadLine());


            Console.WriteLine("Enter the Deapartment Number : ");
            deptNo = (Console.ReadLine());

            Console.WriteLine("Enter the Employee EmailId : ");
            emailId = Console.ReadLine();

            double HRA = (salary * 15) / 100;
            double MA = (salary * 10) / 100;
            double TA = (salary * 15) / 100;

            double totalSalary = salary + HRA + MA + TA;

            Console.WriteLine(".....Employee Details......");
            Console.WriteLine("Employee Id : " + id);
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Basic Salary : " + salary);
            Console.WriteLine("Contracted Employee : " + isContractEmp);
            Console.WriteLine("Department Number : " + deptNo);
            Console.WriteLine("Email id : " + emailId);
            Console.WriteLine("House Rent Allowance : " + HRA);
            Console.WriteLine("Medical Allownace : " + MA);
            Console.WriteLine("Travel Allowance : " + TA);
            Console.WriteLine("Total salary : " + totalSalary);
        }
    }
}