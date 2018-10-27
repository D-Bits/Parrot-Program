using System;
using System.Collections.Generic;
using System.Text;

/*
 * A program to use a conditional to determine if a parrot is dead, or alive.
 * Based on the Monty Python skit
 * By Dana Lockwood 3/16/18
 */

namespace ParrotProgram
{
    class parrot
    {
        static void Main(string[] args)
        {
            parrot.DeadorAlive();
        }

        static void DeadorAlive()
        {
            Console.Write("Is this parot dead or alive?: ");
            string life = Console.ReadLine();
            Console.WriteLine("");

            //Begin conditional
            if (life == "alive") 
            {
                Console.WriteLine("Its not dead, its just sleeping!");
                Console.WriteLine();
                Console.WriteLine("(Press any key to exit.)");
            }
            else if (life == "dead")
            {
                Console.WriteLine("THIS PARROT IS NO MORE! IT HAS CEASED TO BE! ITS EXPIRED AND GONE TO MEET IT'S MAKER!");
                Console.WriteLine();
                Console.WriteLine("(Press any key to exit.)");
            } 
            else
            {
                Console.WriteLine("Please enter 'alive' or 'dead' (case senstive). Press any key to exit.");
                Console.WriteLine();
                Console.WriteLine("(Press any key to exit.)");
            }
            //End conditional

            Console.ReadKey();
        }

    }
}