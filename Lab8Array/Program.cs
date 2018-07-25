using System;
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
            classmates[9] = "Frank Lloyde-Wright";
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
            string[] talents = new string[] { "chewing bublegum", "taking names", "chashing checks", "hopscotch", "armed robery", "playing hooky","throwing rocks at trains","absolutely nothing","running", "looting"};

            Console.WriteLine("As the new teacher in school it is wise to learn up on who you'll be teaching.");
            Console.WriteLine("Which student do you want to learn about? Enter a number 1-20");
            
            int userInput = int.Parse(Console.ReadLine());
            int i = userInput - 1;
            
            Console.WriteLine("This is " + classmates[i]);
            Console.WriteLine("Would you like to know more about their hometown or talents?");
            var userChoice = Console.ReadLine();

            if (userChoice == "hometown")
            {
                Console.WriteLine(classmates[i] + " is from " + hometown[i]);
                Console.WriteLine("Would you like to know about their talents? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine(classmates[i] + " is good at " + talents[i]);
                    Console.ReadKey();
                    return;
                }
            }
            else if (userChoice == "talents")
            {
                Console.WriteLine(classmates[i] + "is good at " + talents[i]);
                Console.WriteLine("Would you like to know about their hometown? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine(classmates[i] + " is from " + hometown[i]);
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("That is not a valid answer");
            }
            
            
            
       
            Console.ReadKey();

            


        }
    }
}
