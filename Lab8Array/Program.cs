﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Lab8Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classmates;
            classmates = new string[20];
            classmates[0] = "Billy Bob Thorton";
            classmates[1] = "Lester Neigard";
            classmates[2] = "Peggy Valone";
            classmates[3] = "Steve Wizouski";
            classmates[4] = "Mike Sullivan";
            classmates[5] = "Alvin Collins";
            classmates[6] = "Charlie Humpkins";
            classmates[7] = "Delta Flyer";
            classmates[8] = "Eugine Elward";
            classmates[9] = "Frank Loyde-Wright";
            classmates[10] = "George Peach";
            classmates[11] = "Henrieta Horseman";
            classmates[12] = "Juliete Runfar";
            classmates[13] = "Kelly Achino";
            classmates[14] = "Laura Steofar";
            classmates[15] = "Nancy Pancy";
            classmates[16] = "Ophilia Up";
            classmates[17] = "Quincy Adams";
            classmates[18] = "Umbrella Stick";
            classmates[19] = "Zebadia Amish";
            string[] hometown = new string[] { "Washington DC", "Grand Rapids", "Portland", "Chicago", "Holland", "Fargo", "Jueno", "Talahassee", "Townsville", "Middle Earth", "Asheville", "Zionsville", "Portland", "the other Portland", "Detroit", "Marquette", "the South Side", "the North Pole", "Whoville", "where you're from." };
            string[] talets = new string[] { "chewing bublegun", "taking names", "chashing checks", "hopscotch", "armed robery" };

            Console.WriteLine("As the new teacher in school it is wise to learn up on who you'll be teaching.");
            Console.WriteLine("Which student do you want to learn about? Enter a number 1-20");
            
            int userInput = int.Parse(Console.ReadLine());
            int i = userInput - 1;
            
                Console.WriteLine("This is " + classmates[i]);
                Console.ReadLine();

            


        }
    }
}