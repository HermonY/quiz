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
            string[] questions = new string[]{"Who are the 2014/2015 champions of Europe?","Who are the 2014/2015 FA Cup champions?"};
            string[] answers = new string[]{"Barcelona","Arsenal"};
            ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Yellow,ConsoleColor.Magenta};
            int[] whiteList = new int[] {1, 0};

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
                //use a case insensitive string comparison
                if(userVal.Equals(answer,StringComparison.InvariantCultureIgnoreCase)){
                    Console.WriteLine("correct!");
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

