using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Doctor
{
    class Dermatologist:Doctor
    {
        public Dermatologist(string name, string hospital) : base (name, hospital)
        { 
        }

        public void SkinIssues()
        {
            Console.WriteLine("Looks after skin");
        }


        public override void PersonalizedCases()
        {
            Console.WriteLine("The looks after skin allergies");
        }
    }
}
         


        

