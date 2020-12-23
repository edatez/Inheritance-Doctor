using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Doctor
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Hospital { get; set; }

        public int Rank { get; }

        public Doctor(string name, string hospital) //constructor
        {
            this.Name = name;
            this.Hospital = hospital;
        }

        public void CheckUp()
        {
            Console.WriteLine("The doctor performs checkup");
        }
        public virtual void PersonalizedCases()
        {
            Console.WriteLine("The looks after special cases");
        }

    }
}
