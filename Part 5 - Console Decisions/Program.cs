using System;

namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////// Stages
            {
                Console.WriteLine("----Stages----");

                int age;
                Console.WriteLine("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());



                if (age < 0)
                {
                    Console.WriteLine("Error");
                }
                else if (age <= 5)
                {
                    Console.WriteLine("Child");
                }
                else if (age < 19)
                {
                    Console.WriteLine("Toddler");
                }
                else if (age > 18)
                {
                    Console.WriteLine("Adult");
                }
                else if (age <= 10)
                {
                    Console.WriteLine("Preteen");
                }
                else if (age <= 12)
                {
                    Console.WriteLine("Teen");



                }
            }
            /////////////////////////////////////////////////////////////////////////// Hurricane
            {
                Console.WriteLine("----Hurricane----");





            }
            /////////////////////////////////////////////////////////////////////////// Dice Game
            {
                Console.WriteLine("----Dice Game----");

            
            
            }


            Console.ReadKey();
        }
    }
}
