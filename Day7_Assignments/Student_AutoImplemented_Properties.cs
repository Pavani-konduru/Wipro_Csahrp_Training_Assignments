using System;
namespace OOPs
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
    class Program_Implementation
    {
        public static void Main(string[] args) 
        {
            Student student1 = new Student();
            Console.WriteLine("Enter the student Id : ");
            student1.StudentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student Name : ");
            student1.StudentName = Console.ReadLine();

            Console.WriteLine("Studnet Name is : " + student1.StudentName);
            Console.WriteLine("Student Id is : " + student1.StudentId);

        }
        
    }
}