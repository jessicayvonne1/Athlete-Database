using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Athlete //defines an athlete object base class
    {

        //define the fields
        private string _name;
        private double _salary;
        //constructor 
        public Athlete()
        {
            _name = "";
            _salary = 0;
        }

        //define properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        //parameterized constructor
        public Athlete(string n, double s)
        {
            _name = n; _salary = s;

        }

        //define a method to display athlete details
        public virtual string display()
        {
            return "Athlete's Name: " + this.Name + "\n Athlete's Salary: " + this.Salary;
        }
    }
}
