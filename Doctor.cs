using System;

namespace HospitalSystem
{
    public class Doctor : Person
    {
        public string Specialization { get; set; }

        public Doctor(
            string name,
            string surname,
            int age,
            string gender,
            string specialization
        ) : base(name, surname, age, gender)
        {
            Specialization = specialization;
        }

        public void ShowDoctor()
        {
            ShowBasicInfo();
            Console.WriteLine($"İxtisas: {Specialization}");
            Console.WriteLine("----------------------");
        }
    }
}