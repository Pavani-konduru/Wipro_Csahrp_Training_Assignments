using System;
namespace Program
{
    class StaticMember
    {
        //Maintain the Student details belongs to a particular College
        class Student
        {
            public string _sname;
            public static string _cname;

            public string Name
            {
                get { return  _sname; }
                set { _sname = value; }
            }
            public static string CollegeName
            {
                get { return _cname; }
                set { _cname = value; }
            }
            public void Print()
            {
                Console.WriteLine("Student Name : {0}, College Name: {1}", _sname,_cname);
            }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Student.CollegeName = "Narayana";

                Student obj1 = new Student();
                obj1.Name = "Honey";

                Student obj2 = new Student();
                obj2.Name = "Rosy";

                obj1.Print();
                obj2.Print();

                Console.WriteLine("\n");
                Student.CollegeName = "VITS";
                obj1.Print();
                obj2.Print();

                Console.WriteLine();
                

            }
        }
       
    }
}