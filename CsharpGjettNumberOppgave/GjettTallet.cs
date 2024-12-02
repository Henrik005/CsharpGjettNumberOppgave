using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGjettNumberOppgave
{
    internal class GjettTallet
    {
        public void Run()
        {
            Random rand = new Random();
           int randomNr = rand.Next(0, 100);
            Console.WriteLine("Guess The Correct Number between 1-100!");

            bool running = true;
            while (running)
            {
                var input = Console.ReadLine();
                int numInput = Convert.ToInt32(input);

                if (numInput < randomNr)
                {
                    Console.WriteLine("Guess Higher!");
                }
                else if (numInput > randomNr)
                {
                    Console.WriteLine("Guess Lower!");

                }
                else if (numInput == randomNr)
                {
                    YouWin();
                }
            }
        }
        public void YouWin()
        {
            Console.WriteLine("You Won!!! Play Again? :)");
            string input = Console.ReadLine();
            
            if (input == "Yes")
            {
                Console.Clear();
                Run();
            }
            else
            {
                Console.WriteLine("Goodbye! ;)");
                System.Environment.Exit(0);
            }

        }
    }
}
