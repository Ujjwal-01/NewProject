using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string guessed_word = "Inception";
            string guessing_word = "";
            int attempt = 0;
            int guessing_word_limit = 3;
            bool No_more_attempt_left = false;



            while (guessing_word != guessed_word && !No_more_attempt_left)
            {
                if (attempt < guessing_word_limit)
                {
                    Console.Write("Enter your guessing word: ");
                    guessing_word = Console.ReadLine();
                    attempt++;

                }
                else No_more_attempt_left = false;
                {
                    Console.WriteLine(" Opps!!no more attempts left ");

                }
                Console.WriteLine("Do you want to try again: Yes/No ? ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                    break;
                if (answer == "no")
                    return;




            }
        }
    }
}
