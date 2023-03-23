using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string n = "";
        public static double s = 0;


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void athleteInfoButton_Click(object sender, EventArgs e)
        {
            
            //add person name and salary from textboxes and store

            if (athleteNameTextBox.Text != "" && double.TryParse(salaryTextBox.Text, out s))
            {
                //collect inputs
               
                n = athleteNameTextBox.Text;

                //create object
                Athlete athlete = new Athlete(n, s);

                //pull up form 2 
                Professional form2 = new Professional();
                form2.Show();
                MessageBox.Show("Athlete Successfully Added!");
            }
            else
            {
                MessageBox.Show("Enter valid athlete info");
                
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
