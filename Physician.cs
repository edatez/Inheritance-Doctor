using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Doctor
{
    class Physician:Doctor
    {
        public Physician(string name, string hospital) //constructor
        {
            this.Name = name;
            this.Hospital = hospital;
        }
        public void ViralIssues()
        {
            Console.WriteLine("The physican looks after patients with viral issues. ");
        }
    }
}
