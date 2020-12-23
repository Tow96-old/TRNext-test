using System;
using System.Windows.Forms;
using TRNext.Classes;

namespace TRNext
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
        }

        #region Properties
        private Business business = new Business();
        private Person interviewee;
        #endregion

        private void createNewInterviewee()
        {
            var rand = new Random();
            var names = new Names();
            interviewee = new Person(names.generateName(), rand.Next(18, 55));

            // Fills the data
            textBox2.Text = interviewee.Name;
            textBox3.Text = interviewee.Age.ToString();
            textBox4.Text = interviewee.Strength.Value.ToString();
            textBox5.Text = interviewee.Intelligence.Value.ToString();
            textBox6.Text = interviewee.Charisma.Value.ToString();
        }

        /** Start button
         * Registers the manager and starts the interviews
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //If the boxes aren't filled, throws error
            if (
                textBox1.Text.Trim() == "" ||  
                numericUpDown1.Value < 1   ||
                numericUpDown2.Value < 1
                )
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            // Gets the values
            string name = textBox1.Text.Trim();
            int age = Convert.ToInt32(numericUpDown1.Value);
            int buttons = Convert.ToInt32(numericUpDown2.Value);

            // Creates the manager, dresses it, and adds it to the Business
            Person newManager = new Person(name, age);
            newManager.DressUp(buttons);
            business.addManager(newManager);

            // Disables the welcome box and enables the interview box
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

            // Creates a new person to interview
            createNewInterviewee();
        }

        /** Next interviewee button
         * Creates a new person to interview
         */
        private void button2_Click(object sender, EventArgs e)
        {
            createNewInterviewee();
        }

        /** Hire as engineer
         * Takes the person, hires it, and creates a new person to interview
         */
        private void button3_Click(object sender, EventArgs e)
        {
            Person newEngineer = business.hireEngineer(interviewee);
            // If the List is full, sends an error
            if( newEngineer == null )
            {
                MessageBox.Show("Ya hay muchos ingenieros contradados");
                return;
            }

            // Adds the engineer to the list
            checkedListBox1.Items.Add(newEngineer.Name);

            // Calls a new interviewee
            createNewInterviewee();
        }

        /** Hire as Operator
         * Takes the person, hires it, and creates a new person to interview
         */
        private void button4_Click(object sender, EventArgs e)
        {
            Person newOperator = business.hireOperator(interviewee);
            // If the List is full, sends an error
            if (newOperator == null)
            {
                MessageBox.Show("Ya hay muchos ingenieros contradados");
                return;
            }

            // Adds the engineer to the list
            checkedListBox2.Items.Add(newOperator.Name);

            // Calls a new interviewee
            createNewInterviewee();

        }
    }
}
