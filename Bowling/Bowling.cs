// Author: Jonathan Spalding
// Assignment: Project 10
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 4/9/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Bowling
    {
        // state constants
        const int MAX = 10;
        const int MIN = 0;
        // state other variables and data members
        private int numberOfPlayers = 0;
        private double sum = 0;
        private double quotient;
        // create an array for the user input.
        private string[] names;
        private int[] scores;
        // The default constructor
        // Purpose: It sets all declared variables (data members of the class) to what they need to be.
        // Parameters:
        // Returns: None
        public Bowling(int MAX)
        {
            // set both arrays to the length of 10
            names = new string[MAX];
            scores = new int[MAX];
        }
        // The AddPlayer method
        // Purpose: split the users from the scores, assign them to the appropriate arrays, and the add one more player.
        // Parameters: string userInput
        // Returns: none
        public void AddPlayer(string userInput)
        {
            // userInput is split into two pieces, which are stored in this array of strings
            string[] parsedInput;
            // this line splits the string userInput into the two pieces
            parsedInput = userInput.Split();
            // store the first piece, the name, in a string variable
            names[numberOfPlayers] = parsedInput[0];
            // store the second piece, a score, in an integer variable
            scores[numberOfPlayers] = int.Parse(parsedInput[1]);
            // add another player to the "numberOfPlayers"
            ++numberOfPlayers;
        }
        // The BubbleSort method
        // Purpose: Organizes the scores from highest to lowest
        // Parameters: string userInput
        // Returns: none
        public void BubbleSort()
        {
            // for loop that runs through each player
            for (var i = 0; i < numberOfPlayers - 1; ++i)
            {
                // for loop that compares the first index player with each other player
                for (var j = 0; j < numberOfPlayers - 1; ++j)
                {
                    // if statement that compares the scores of each player
                    if (scores[j] < scores[j + 1])
                    {
                        // variable that stores the value of the variable to be swapped out
                        var num = scores[j];
                        // set current index equal to score score in the index
                        scores[j] = scores[j + 1];
                        // set next index equal to this score
                        scores[j + 1] = num;
                        // string that stores the name so that it can be switched with the score.
                        string str = names[j];
                        // set current index equal to name on next index.
                        names[j] = names[j + 1];
                        // set next index equal to this name
                        names[j + 1] = str;
                    }
                }
            }
        }
        // The GetPlayerName method
        // Purpose: Return the player name.
        // Parameters: None
        // Returns: int names[i]
        public string GetPlayerName(int i)
        {
            return names[i];
        }
        // The GetPlayerScores method
        // Purpose: return Player Score
        // Parameters: None
        // Returns: int scores[i]
        public int GetPlayerScores(int i)
        {
            return scores[i];
        }
        // The GetNumberOfPlayers method
        // Purpose: Return the number of players
        // Parameters: None
        // Returns: int numberOfPlayers
        public int GetNumberOfPlayers()
        {
            return numberOfPlayers;
        }
        // The GetAverageScore method
        // Purpose: To add all the scores together, then divide it by the number of players
        // Parameters: None
        // Returns: double quotient
        public double GetAverageScore()
        {
            // for loop that runs the number of times that there are players.
            for (var i = 0; i < numberOfPlayers; i++)
            {
                // add each user's score together.
                sum = sum + (double)scores[i];
            }
            // divide the total by the number of players to find the average.
            quotient = sum / (double)numberOfPlayers;
            // return the average.
            return quotient;
        }
    }
}
