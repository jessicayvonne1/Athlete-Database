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
    public partial class Professional : Form
    {
        public Professional()
        {
            InitializeComponent();
        }

        private void nameOutputLAbel_Click(object sender, EventArgs e)
        {

        }

        private void Professional_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'professionalDBDataSet.HiredTable' table. You can move, or remove it, as needed.
            this.hiredTableTableAdapter.Fill(this.professionalDBDataSet.HiredTable);
            nameOutputLAbel.Text = Form1.n;
            salaryOutputLabel.Text = Form1.s.ToString();
        }

        private void hiringInfoButton_Click(object sender, EventArgs e)
        {
            
            //add person name and salary from textboxes and store

            if (hiredProffessionalNameTextBox.Text != "" && categoryComboBox.Text == "Lawyer")
            {
                //collect inputs

               // n = hiredProffessionalNameTextBox.Text;

                //create object
               Lawyer lawyer = new Lawyer();
               

                //pull up form 2 
               // Professional form2 = new Professional();
               // form2.Show();
                lawyer.Name = hiredProffessionalNameTextBox.Text;
                lawyer.Category = "Lawyer";
               
                lawyer.Percentage = .1;
                lawyer.Salary = Form1.s * lawyer.Percentage;

                MessageBox.Show(lawyer.display());
                //step 3 proff object added to database
                hiredTableTableAdapter.insertProfessional(lawyer.Name, lawyer.Category, lawyer.Salary);
                this.hiredTableTableAdapter.Fill(this.professionalDBDataSet.HiredTable);
            }
            else if (hiredProffessionalNameTextBox.Text != "" && categoryComboBox.Text == "Agent")
            {

                //create object
                Agent agent = new Agent();
                agent.Name = hiredProffessionalNameTextBox.Text;
                agent.Category = "Agent";

                agent.Percentage = .07;
                agent.Salary = Form1.s * agent.Percentage;

                MessageBox.Show(agent.display());
                //step 3 proff object added to database
                this.hiredTableTableAdapter.insertProfessional(agent.Name, agent.Category, agent.Salary);
                this.hiredTableTableAdapter.Fill(this.professionalDBDataSet.HiredTable);

            }
            else if(hiredProffessionalNameTextBox.Text != "" && categoryComboBox.Text == "Trainer")
            {
                //create object
                Trainer trainer = new Trainer();
                trainer.Name = hiredProffessionalNameTextBox.Text;
                trainer.Category = "Trainer";

                trainer.Percentage = .05;
                trainer.Salary = Form1.s * trainer.Percentage;

                MessageBox.Show(trainer.display());
                //step 3 proff object added to database
                this.hiredTableTableAdapter.insertProfessional(trainer.Name, trainer.Category, trainer.Salary);
                this.hiredTableTableAdapter.Fill(this.professionalDBDataSet.HiredTable);


            }
            else if(hiredProffessionalNameTextBox.Text != "" && categoryComboBox.Text == "Personal Assistant")
            {
                //create object
                PersonalAssistant pA = new PersonalAssistant();
                pA.Name = hiredProffessionalNameTextBox.Text;
                pA.Category = "Personal Assistant";

                pA.Percentage = .03;
                pA.Salary = Form1.s * pA.Percentage;

                MessageBox.Show(pA.display());
                //step 3 proff object added to database
                this.hiredTableTableAdapter.insertProfessional(pA.Name, pA.Category, pA.Salary);
                this.hiredTableTableAdapter.Fill(this.professionalDBDataSet.HiredTable);
            }
            else
            {
                MessageBox.Show("Enter valid professionals info");

            }



        }

        private void hiredTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hiredTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.professionalDBDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sumOfSalary;
            double remainingSalary;
            
           
            //display athlete's expense 
            sumOfSalary = (double)this.hiredTableTableAdapter.sumSalary();
            //display remaining salary
            remainingSalary = Form1.s - sumOfSalary;

            //display count of each type of professional
            int count = (int)this.hiredTableTableAdapter.countProfessionalsHired();

            MessageBox.Show("Athlete's Total Salary: $" + salaryOutputLabel.Text + "\n Sum of All Charges From Professionals: "
                + sumOfSalary.ToString("C") + "\n Athlete's Remaining Salary: " + remainingSalary.ToString("C")
                + "\n Number Of Professionals Hired: " + count);
        }
    }
}

