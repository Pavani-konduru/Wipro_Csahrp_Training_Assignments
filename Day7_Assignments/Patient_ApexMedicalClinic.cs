using System;
namespace ApexMedicalClinic
{
    class Patient
    {
        public int PatientId {  get; set; }
        public string PatientName { get; set; }
        public string PGender { get; set; }
        public int PatientAge { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long PatientPhone { get; set;}
        public double Weight {  get; set; }
        public bool HasInsurance {  get; set; }

        public Patient(int pId, String Pname )
        {
            PatientId = pId;
            PatientName = Pname;
        }
        public void PatientDetails()
        {

            Console.WriteLine($"Patient Id : {PatientId}");
            Console.WriteLine($"Patient Name : {PatientName}"); 
            Console.WriteLine($"Patient Gender : {PGender}");
            Console.WriteLine($"Patient Age : {PatientAge}");
            Console.WriteLine($"Patient D.O.B : {DateOfBirth}");
            Console.WriteLine($"Patient Mobile Number : {PatientPhone}");
            Console.WriteLine($"Patient Weight (in kgs) : {Weight}");
            Console.WriteLine($"Is Patient Has Any Insurance  : {HasInsurance}");
        }
    }
    class Clinic
    {       
        public static void Main(string[] args)
        {
            Patient p = new Patient(1,"Rosy");
            p.PatientAge = 20;
            p.PGender = "Female";
            p.DateOfBirth = new DateTime(21 / 03 / 2004);
            p.PatientPhone = 9876543211;
            p.Weight = 55;
            p.HasInsurance = true;
            Console.WriteLine("____Patient Details____");
            p.PatientDetails();
        }
       
    }
}