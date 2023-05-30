using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Quiz_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the GK(General Knowledge) Quiz Competition.");
            Console.WriteLine("First Enter Your Name: ");
            string name = Console.ReadLine();
            double result = 0;
            if(double.TryParse(name, out result))
            {
                Console.WriteLine("Please Enter A Valid Name.");
                Console.WriteLine("Press Enter For Exit....");
            }
            else
            {
                Console.WriteLine("Now Lets Start The Quiz.");
                Console.WriteLine("Instructions: ");
                Console.WriteLine("You Will Get 3 GK Questions To Answer. If You Answer All The Questions Correct, You Will Be Recognized As An Intelligent Person.");
                Console.WriteLine("You Have To Give All Answers Correct, If You Missed Any Of The Questions You Can't Answer The Other Questions");
                Console.WriteLine("");
                Console.WriteLine("Here Is Your First Question: ");
                Console.WriteLine("1. FFC stands for");
                Console.WriteLine("(A) Foreign Finance Corporation");
                Console.WriteLine("(B) Film Finance Corporation");
                Console.WriteLine("(C) Federation of Football Council");
                Console.WriteLine("(D) None of the above");
                Console.WriteLine("");
                Console.WriteLine("Write ABCD For The Answer (Only In Capital)");
                string answer = Console.ReadLine();
                if(answer == "B")
                {
                    Console.WriteLine("The Answer Is Correct.");
                    Console.WriteLine("");
                    Console.WriteLine("Here Is Your Second Question: ");
                    Console.WriteLine("2. Fastest shorthand writer was");
                    Console.WriteLine("(A) Dr. G. D. Bist");
                    Console.WriteLine("(B) J.R.D.Tata");
                    Console.WriteLine("(C) J.M.Tagore");
                    Console.WriteLine("(D) Khudada Khan");
                    string answer1 = Console.ReadLine();
                    if(answer1 == "A")
                    {
                        Console.WriteLine("The Answer Is Correct.");
                        Console.WriteLine("");
                        Console.WriteLine("Here Is Your Third And The Last Question: ");
                        Console.WriteLine("3. First human heart transplant operation conducted by Dr. Christiaan Barnard on Louis Washkansky, was conducted in");
                        Console.WriteLine("(A) 1967");
                        Console.WriteLine("(B) 1968");
                        Console.WriteLine("(C) 1958");
                        Console.WriteLine("(D) 1922");
                        string answer2 = Console.ReadLine();
                        if(answer2 == "A")
                        {
                            Console.WriteLine("The Answer Is Correct.");
                            Console.WriteLine($"Hurray {name} You Are An Intelligent Person.");
                        }
                        else
                        {
                            Console.WriteLine("Oops You Missed It.");
                            Console.WriteLine("Press Enter For Exit....");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Oops The Answer Is Incorrect. Sorry You Can't Answer The Other Questions.");
                        Console.WriteLine("Press Enter For Exit....");
                    }
                }
                else
                {
                    Console.WriteLine("Oops The Answer Is Incorrect. Sorry You Can't Answer The Other Questions.");
                    Console.WriteLine("Press Enter For Exit....");
                }
            }

            Console.ReadLine();
        }
    }
}
