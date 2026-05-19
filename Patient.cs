using System;

namespace HospitalSystem
{
    public class Patient : Person
    {
        public int Id { get; set; }
        public string Disease { get; set; }
        public string BloodType { get; set; }

        public Patient(
            int id,
            string name,
            string surname,
            int age,
            string gender,
            string disease,
            string bloodType
        ) : base(name, surname, age, gender)
        {
            Id = id;
            Disease = disease;
            BloodType = bloodType;
        }

        public void ShowPatient()
        {
            Console.WriteLine($"ID: {Id}");
            ShowBasicInfo();
            Console.WriteLine($"Xəstəlik: {Disease}");
            Console.WriteLine($"Qan qrupu: {BloodType}");
            Console.WriteLine("----------------------");
        }
    }
}