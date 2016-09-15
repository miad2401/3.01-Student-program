/*De'shon Mcneil
Computer Programming II Class
Period 4
Copyright CigFex Software Solutions 2016 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Program
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        player[] bballPlayer;// Calls the player class and create a variable with all of the methods in that class
        int counter = 0;// Sets the counter to 0

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                bballPlayer[counter].lastName = txtLast.Text;// Get the last name from the text box
                bballPlayer[counter].firstName = txtFirst.Text;// Get the First name from the text box
                bballPlayer[counter].height = Convert.ToInt32(txtHeight.Text);// Get the Height from the text box
                bballPlayer[counter].position = Convert.ToInt32(txtPosition.Text);//Get the position from the text box
                bballPlayer[counter].Year = txtYear.Text;//Get the year from the text box

                lstRoster.Items.Add(bballPlayer[counter].lastName + "                " + bballPlayer[counter].firstName + "      " + bballPlayer[counter].height + "       " + bballPlayer[counter].position + "       " + bballPlayer[counter].Year + "\r\n");// Add a entry to the listbox with all the proper parts
                counter++;//Move the counter up the counter

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter either FR, SO, JR, or SR for the Year");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("You already entered the max number of players");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a number for height or postion!");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int howMany = Convert.ToInt32(txtPlayers.Text);// Sets the variable for the number of players to what is in the box.
                bballPlayer = new player[howMany]; //calls the object with the player class atached and the gets the number of players from the textbox
                for (int i = 0; i < howMany; i++)// for the number of players that is entered another loop in invoked
                {
                    bballPlayer[i] = new player();
                }
            }
            catch
            {
                MessageBox.Show("Enter a whole number only.");// if there is a problem, have an answer for the most likely problem
            }
            lstRoster.Items.Add("Last Name  First Name  Height  Position  Year \r\n");//if it works then add the numbers to the listbox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstRoster.Items.Clear();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstRoster.Items.Clear();
        }
    }
    class player //Create a class for the player, to hold all of the properties for the player (Name, height, etc.)
    {

        public string firstName //Variable For the first name
        {
            get; set;
        }

        public string lastName //Variable for the last name
        {
            get; set;
        }

        public int height //Variable For the height
        {
            get;
            set;
        }

        public int position //Variable for the postition
        {
            get; set;
        }

        private string year; //Declares the variable for the year

        public string Year //Sets a value for the year, based on certain conditions
        {
            get
            {
                return year;
            }
            set
            {
                if (value == "FR" || value == "SO" || value == "JR" || value == "SR")
                {
                    year = value; // Get the value that is chosen, and sets the year to that value.
                }
                else
                {
                    throw new ArgumentException();
                }
            }

        }



    }

}
