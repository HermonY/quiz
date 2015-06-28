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
            //data source is arrays - normally get this data from database
            string[] questions = new string[] { "Who are the 2014/2015 champions of Europe?", "Who are the 2014/2015 FA Cup champions?", "Which team did Steven Gerrard leave to join LA Galaxy?", "What is the full name of Arsenal's record goal scorer?", "What number shirt did Dennis Bergkamp wear for Arsenal?" };
            string[] answers = new string[] { "Barcelona", "Arsenal", "Liverpool", "Thierry Henry", "10" };
            ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.Cyan };
            //int[] whiteList = new int[] { 1, 0 };

            //run questions
            for (var i = 0; i < questions.Length; i++)
            {
                // if (!whiteList.Contains(i))
                //continue;
                var question = questions[i];
                var answer = answers[i];
                var color = colors[i];
                Console.ForegroundColor = color;
                Console.WriteLine(question);
                var userVal = Console.ReadLine();
                //use a case insensitive string comparison
                if (userVal.Equals(answer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("correct!");
                }
                else
                {
                    Console.WriteLine("fail!");
                    //decrement counter to rety same question
                    i--;

                    if (i == questions.Length - 1)
                        Console.ReadLine();
                }

    
                };


                //if last question, readline to stop program closing
               // if (i == questions.Length - 1)
                 //   break;
                    Console.WriteLine("Well done, you have completed Stage 1. Would you like to continue?");
                var userin = Console.ReadLine();
                if (userin.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                    // Console.ReadLine(userVal);
                    //if ( userVal == "yes")
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Stage 2");
                
                string[] questionsstage2 = new string[] { "Who is the superior footballer, Aimen or Hermon?"};
                string[] answersstage2 = new string[] { "hermon"};
                ConsoleColor[] colorsstage2 = new ConsoleColor[] { ConsoleColor.DarkYellow};
                //int[] whiteList = new int[] { 1, 0 };

                //run questions
                for (var y = 0; y < questionsstage2.Length; y++)
                {
                    // if (!whiteList.Contains(i))
                    //continue;
                    var questionstage2 = questionsstage2[y];
                    var answerstage2 = answersstage2[y];
                    var colorstage2 = colorsstage2[y];
                    //var colorstage2 = colorsstage2[y];
                    Console.ForegroundColor = colorstage2;
                    Console.WriteLine(questionstage2);
                    var userans = Console.ReadLine();
                    //use a case insensitive string comparison
                    if (userans.Equals(answerstage2, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("correct!");
                    }
                    else
                    {
                        Console.WriteLine("fail!");
                        //decrement counter to rety same question
                        y--;
                    };


                }
                #region oldstuff
                /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please select a topic for the quiz: Sports, Superheros or Trivia.");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "Sports")
            {
                message = "You have chosen Sports!";
             Console.ForegroundColor = ConsoleColor.Red;
                
            }
                
                else if (userValue == "Superhero")
                {
                    message = "You have chosen Superhero!";
                }

                else if (userValue == "Trivia")
                {
                    message = "You have chosen Trivia!";
                }
                else
                {
                    message = "Sorry, I did not understand your answer";
                }

                Console.WriteLine(message);
                Console.ReadLine();
        
            }
            */
                #endregion

            }


        }
    }




