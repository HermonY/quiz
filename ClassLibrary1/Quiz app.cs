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
<<<<<<< HEAD
            string[] questions = new string[] { "Who are the 2014/2015 champions of Europe?", "Who are the 2014/2015 FA Cup champions?", "Which team did Steven Gerrard leave to join LA Galaxy?", "What is the full name of Arsenal's record goal scorer?", "What number shirt did Dennis Bergkamp wear for Arsenal?" };
            string[] answers = new string[] { "1", "2", "3", "4", "5" };
            ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.Cyan };
            List<string> useranswers = new List<String>(); 
            int correctCount = 0;
            int incorrectCount = 0;
            //int[] whiteList = new int[] { 1, 0 };
=======
            string[] questions = new string[]{"Who are the 2014/2015 champions of Europe?","Who are the 2014/2015 FA Cup champions?"};
            string[] answers = new string[]{"Barcelona","Arsenal"};
            ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Yellow,ConsoleColor.Magenta};
            int[] whiteList = new int[] {1, 0};
>>>>>>> 5e781c86e0ff468ee25c555ef1c9908fa1a5ceef

            //run questions
            for(var i=0; i<questions.Length; i++){
                if (!whiteList.Contains(i))
                    continue;
                var question = questions[i];
                var answer = answers[i];
                var color = colors[i];
                Console.ForegroundColor = color;
                Console.WriteLine(question);
                var userVal = Console.ReadLine();
                useranswers.Add(userVal);
                //use a case insensitive string comparison
                if(userVal.Equals(answer,StringComparison.InvariantCultureIgnoreCase)){
                    Console.WriteLine("correct!");
<<<<<<< HEAD
                    correctCount++;

                }
                else
                {
                    Console.WriteLine("incorrect!");
                    incorrectCount++;

                    // if (i == questions.Length - 1)
                    // Console.ReadLine();
                };
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you scored " + correctCount + " out of 5");
            // Console.ReadLine();
            if (correctCount == questions.Length)
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Well done, you have completed Stage 1. Would you like to continue?");
            var userin = Console.ReadLine();
            if (userin.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                Console.ForegroundColor = ConsoleColor.White;
            else
                return;
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Stage 2");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            string[] questionsstage2 = new string[] { "Who is the superior footballer, Henderson or Cazorla?" };
            string[] answersstage2 = new string[] { "Cazorla" };
            List<int> correctanswersstage2=new List<int>(); 
            List<int> incorrectanswersstage2=new List<int>(); 
            ConsoleColor[] colorsstage2 = new ConsoleColor[] { ConsoleColor.DarkMagenta };

            for (var y = 0; y < questionsstage2.Length; y++)
            {

                var questionstage2 = questionsstage2[y];
                var answerstage2 = answersstage2[y];
                var colorstage2 = colorsstage2[y];
                int correctCount2 = 0;
                int incorrectCount2 = 0;
                Console.ForegroundColor = colorstage2;
                Console.WriteLine(questionstage2);
                var userans = Console.ReadLine();

                if (userans.Equals(answerstage2, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("correct!");
                    correctCount2++;
                    correctanswersstage2.Add(y);
                    

                }
                else
                {
                    Console.WriteLine("fail!");
                    incorrectCount2++;
                    incorrectanswersstage2.Add(y);

                    y--;
                };

                //REPORT SECTION
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to view your report?");
                var userVal2 = Console.ReadLine();
                if (userVal2.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Your stage 1 score was " + correctCount + " out of " + questions.Length + " and your stage 2 score was " + correctCount2 + " out of " + questionsstage2.Length);
                    

                            for (var i = 0; i < questions.Length; i++)
                    {
                        var reportquestion = questions[i];
                        var reportanswer = answers[i];
                        var reportuseranswer = useranswers[i];
                        Console.WriteLine("Question: " + questions[i]);
                        Console.WriteLine("Correct answer: " + answers[i]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You're answer: " + useranswers[i]);
                        Console.ResetColor();
                    }
                            Console.ReadLine();
                }
                
                else
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }

                
   

            
                
                

            //loop through questions and correct answers then show uservalue for report
             

                #region oldstuff
                /*
=======
                }else{                    
                    Console.WriteLine("fail!");
                    //decrement counter to rety same question
                    i--;
                };
                //if last question, readline to stop program closing
                if(i == questions.Length-1)
                    Console.ReadLine();
            }
#region oldstuff
            /*
>>>>>>> 5e781c86e0ff468ee25c555ef1c9908fa1a5ceef
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
<<<<<<< HEAD





=======
>>>>>>> 5e781c86e0ff468ee25c555ef1c9908fa1a5ceef

