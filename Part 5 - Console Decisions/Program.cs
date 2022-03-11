using System;

namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////// STAGES ////////////////////////////////////////
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
            //////////////////////////////////////// HURRICANE ////////////////////////////////////////
            {
                Console.WriteLine("----Hurricane----");





            }
            //////////////////////////////////////// DICE GAME ////////////////////////////////////////
            {
                Console.WriteLine("----Dice Game----");
                Double money = 100;
                Console.WriteLine("You have $" + money + " in your bank account. Let's feed your gambling addiction :)");

                Console.WriteLine("How much do you bet?");
                Double bet = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What side of the dice do you call?");
                int diceSide = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine("Are you sure you want to choose " + diceSide + " with a bet of $" + bet + "?");
                string answer = Console.ReadLine();
                if (answer is "no")
                    Console.WriteLine("Okay then D:");
                else
                    Console.WriteLine("Okay then :D");








            }
            Console.ReadKey();
        }
    }
}
