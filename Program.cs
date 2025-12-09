using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Led1
{
    internal class Program
    {
       
        
          

       
            static void Main(string[] args)
            {
                Console.WriteLine("How old are you?");
                string ageInput = Console.ReadLine();
                //TODO:calculate birth year of user
                //     and display to console
                //-----------------------------------------------
                // convert string  to int

                try
                {
                    int age = Int32.Parse(ageInput);
                    int birthYear = 2025 - age;
                    Console.WriteLine("Oh, " + ageInput +
                         " So your birth year is " + birthYear);
                    //if/else/switch
                    /*
                     * Generation X(Gen X): 0 <- 1980
                     * Generation Y(Millennials): 1981 <- 1996
                     * Generation Z(Gen Z): 1997 <- 2012
                     * Generation Alpha: 2024 - Present
                     */
                    Console.WriteLine("Your Gen is ");
                    if (birthYear <= 1980)
                    {
                        Console.WriteLine("Gen X");
                    }

                    else if (birthYear <= 1996)
                    {
                        Console.WriteLine("Gen Y");
                    }

                    else if (birthYear <= 2012)
                    {
                        Console.WriteLine("Gen Z");
                    }

                    else if (birthYear <= 2024)
                    {
                        Console.WriteLine("Gen Alpha");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("You input wrong number.");
                    return;
                }

            }
        }
}
