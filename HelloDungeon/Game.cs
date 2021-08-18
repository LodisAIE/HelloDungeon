﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //Health exercise

            //Initialize default health values
            int healthRegen = 50;
            int health = 100 / 2;
            //Increase health by regen amount
            health = health + healthRegen;
            health += healthRegen;
            //Display health to user
            Console.WriteLine(health);

            //Name exercise
            string name = "Empty";
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            string characterName = "";
            int currentArea = 1;
            float power = 10.0f;
            string characterJob = "";
            bool gameOver = false;
            //Test commit

            /// Create the start screen for your text adventure game.
            /// Use variables to store data for the game.
            /// These variables can include, but aren't limited to:
            /// a string to store a character name, a int to store
            /// the current area, an float to power,
            /// a string to store a character's job,
            /// and a bool to store whether or not the game is over.
            /// Afterwards, create the starting screen. It can be a 
            /// welcome message, a way for the player to initialize
            /// base stats, or anything else to comes to mind.
            ///

            //Job selection menu
            Console.WriteLine("Pick a job!");
            Console.WriteLine("1.Wizard");
            Console.WriteLine("2.Knight");
            Console.Write("> ");

            //Get input from player
            string input = Console.ReadLine();

            //If player selected the first option...
            if (input == "1" || input == "Wizard")
            {
                //...give the player the stats for a wizard
                characterJob = "Wizard";
                health = 150;
                power = 15;
            }
            //Otherwise if the player selected the second option...
            else if (input == "2" || input == "Knight")
            {
                //...give the player the stats for a knight
                characterJob = "Knight";
                health = 300;
                power = 400;
            }
            //If neither are true...
            else
            {
                //...display error message
                Console.WriteLine("Invalid Input");
            }

            //Display character stats
            Console.WriteLine("Your Character Stats\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Job: " + characterJob);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Power: " + power);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You've been approached by a traveler!!" +
                "\n They offer you a potion. Do you accept?" +
                "\n 1.Yes \n 2.No");

            input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("It was posion!! Ya dead shuuuunnnnn");
            }
            else if (input == "2")
            {
                Console.WriteLine("You're worried about the weird beverage, so you ask the traveler to try it first.");

            }
        }
    }
}
