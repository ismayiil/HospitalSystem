using System;

namespace HospitalSystem
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string name, string surname, int age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine($"{Name} {Surname} | Yaş: {Age} | Cins: {Gender}");
        }
    }
}