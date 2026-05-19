using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalSystem
{
    class Program
    {
        static List<Patient> patients = new List<Patient>();
        static List<Doctor> doctors = new List<Doctor>();

        static int nextPatientId = 3;

        static void Main(string[] args)
        {
            Data();

            while (true)
            {
                Console.WriteLine("\n===== HOSPITAL SYSTEM =====");
                Console.WriteLine("1. Xəstə əlavə et");
                Console.WriteLine("2. Xəstələri göstər");
                Console.WriteLine("3. Xəstəni ID ilə tap");
                Console.WriteLine("4. Xəstə sil");
                Console.WriteLine("5. Xəstə yenilə");
                Console.WriteLine("6. Həkimləri göstər");
                Console.WriteLine("0. Çıxış");

                Console.Write("Seçim: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddPatient(); break;
                    case "2": ShowPatients(); break;
                    case "3": FindPatientById(); break;
                    case "4": DeletePatient(); break;
                    case "5": UpdatePatient(); break;
                    case "6": ShowDoctors(); break;
                    case "0": return;
                }
            }
        }

        // ================= DATA =================

        static void Data()
        {
            patients.Add(new Patient(1,"Murad","Əliyev",22,"Kişi","Qrip","A+"));
            patients.Add(new Patient(2,"Leyla","Qasımova",30,"Qadın","Migren","B+"));

            doctors.Add(new Doctor("Elvin","Məmmədov",45,"Kişi","Kardioloq"));
            doctors.Add(new Doctor("Aysel","Hüseynova",38,"Qadın","Nevroloq"));
        }

        // ================= ADD =================

        static void AddPatient()
        {
            Console.Write("Ad: ");
            string name = Console.ReadLine();

            Console.Write("Soyad: ");
            string surname = Console.ReadLine();

            Console.Write("Yaş: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Cins: ");
            string gender = Console.ReadLine();

            Console.Write("Xəstəlik: ");
            string disease = Console.ReadLine();

            Console.Write("Qan qrupu: ");
            string bloodType = Console.ReadLine();

            Patient p = new Patient(
                nextPatientId++,
                name,
                surname,
                age,
                gender,
                disease,
                bloodType
            );

            patients.Add(p);

            Console.WriteLine("Xəstə əlavə edildi.");
        }

        // ================= SHOW =================

        static void ShowPatients()
        {
            Console.WriteLine("\n=== Xəstələr ===");

            foreach (var p in patients)
                p.ShowPatient();
        }

        // ================= FIND =================

        static void FindPatientById()
        {
            Console.Write("ID daxil et: ");
            int id = int.Parse(Console.ReadLine());

            var patient = patients.FirstOrDefault(p => p.Id == id);

            if (patient != null)
                patient.ShowPatient();
            else
                Console.WriteLine("Xəstə tapılmadı.");
        }

        // ================= DELETE =================

        static void DeletePatient()
        {
            Console.Write("Silinəcək ID: ");
            int id = int.Parse(Console.ReadLine());

            var patient = patients.FirstOrDefault(p => p.Id == id);

            if (patient != null)
            {
                patients.Remove(patient);
                Console.WriteLine("Xəstə silindi.");
            }
            else
                Console.WriteLine("Tapılmadı.");
        }

        // ================= UPDATE =================

        static void UpdatePatient()
        {
            Console.Write("Yenilənəcək ID: ");
            int id = int.Parse(Console.ReadLine());

            var patient = patients.FirstOrDefault(p => p.Id == id);

            if (patient != null)
            {
                Console.Write("Yeni xəstəlik: ");
                patient.Disease = Console.ReadLine();

                Console.Write("Yeni qan qrupu: ");
                patient.BloodType = Console.ReadLine();

                Console.WriteLine("Məlumat yeniləndi.");
            }
            else
                Console.WriteLine("Xəstə tapılmadı.");
        }

        // ================= DOCTORS =================

        static void ShowDoctors()
        {
            Console.WriteLine("\n=== Həkimlər ===");

            foreach (var d in doctors)
                d.ShowDoctor();
        }
    }
}