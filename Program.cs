using System;

namespace Inheritance_Doctor
{
    class Program
    {
        static void Main(string[] args)
        {
            var doctor = new Doctor("John Lee", "Evergreen");
            Console.WriteLine($"Doctor {doctor.Name} works at {doctor.Hospital}. He has a rank of {doctor.Rank}");

            var dermatologist = new Dermatologist("Can","Bellevue");
            dermatologist.PersonalizedCases();
            dermatologist.Name = "Can";

            var physican = new Physician("Katie", "Woodenville");
            physican.ViralIssues();
            physican.Name = "Eda";


        }
    }
}
