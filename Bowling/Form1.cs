using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowling
{
    public partial class Form1 : Form
    {
        Bowling objectRef;
        public Form1()

        {
            const int MAX = 10;
            objectRef = new Bowling(MAX);
            InitializeComponent();
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nProject 10");
        }
        // The exitToolStripMenuItem2_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            // see if the enter key was pressed
            if (e.KeyData == Keys.Enter)
            {
                // if it was, get the data from the text box
                string inputString = inputBox.Text;
                // if there was no string
                if (inputString == "")
                {
                    // call the method for sorting
                    objectRef.BubbleSort();
                    outputBox.Clear();
                    // string that shows title. Environment.NewLine because \n isn't working
                    string title = "The scores for this game, from high to low are" + Environment.NewLine;
                    // for loop that runs as many times as there are players
                    for (int i = 0; i < objectRef.GetNumberOfPlayers(); i++)
                    {
                        // string that displays the user's name, and tabbed out to show their score.
                        string players = title + ($"{objectRef.GetPlayerName(i)}\t{objectRef.GetPlayerScores(i):d}");
                        // if statement for when the score is 300
                        if (objectRef.GetPlayerScores(i) == 300)
                            //put an asterisk
                            players = players + '*';
                        // Add a player to the title string
                        title = players + Environment.NewLine;
                    }
                    // show in the outputBox the title string with all of the scores, with the team average at the end.
                    outputBox.Text = title + ($"The team average is {objectRef.GetAverageScore():f}");
                }
                else
                {
                    // If a string was entered, then clear the box
                    inputBox.Clear();
                    // send the string to the AddPlayer method in the class to split the string.
                    objectRef.AddPlayer(inputString);
                }
            }
        }
    }
}
