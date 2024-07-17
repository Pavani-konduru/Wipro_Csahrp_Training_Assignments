using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Student
    {
        private int _sid;
        private string _sname;

        public void ReadStudentDetails()
        {
            Console.WriteLine("Enter Studnet id");
            _sid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Student Name: ");
            _sname = Console.ReadLine();
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine("Student Details: Id : {0}, Name : {1}" , _sid, _sname);
        }

    }
    internal class Class_Object
    {
        public static void Main(string[] args)
        { 
            Student studentObj = new Student();
            studentObj.ReadStudentDetails();
            studentObj.PrintStudentDetails();

            Console.WriteLine();

        }

}
}
