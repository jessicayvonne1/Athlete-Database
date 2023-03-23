using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Agent : Athlete
    {
        //define specialized property
        private string _category;
        private double _percentTaken;

        public Agent() : base()
        {

            _category = "";
            _percentTaken = 0;
        }

        public Agent(string n, double s, string c, double p) : base(n, s)
        {
            _category = c;
            _percentTaken = p;
        }

        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public double Percentage
        {
            get { return _percentTaken; }
            set { _percentTaken = value; }
        }

        //display method

        public override string display()
        {
            return "Name of Professional: " + this.Name + "\n Category: " + this.Category + "\nPercentage of Salary: " + this.Percentage;
        }
    }
    
    }

