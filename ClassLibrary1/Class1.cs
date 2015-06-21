using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a topic for the quiz: Sports, Superheros or Trivia.");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "Sports")
          message = "You have chosen Sports!";
            else if (userValue == "Superhero")
           message = "You have chosen Superhero!";
            else if (userValue == "Trivia")
         message = "You have chosen Trivia!";
              
            else
            message = "Sorry, I did not understand your answer";
                Console.ReadLine();

                Console.WriteLine(message);
                Console.ReadLine();
            }


        }
    }

