using System;
namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////// STAGES //////////////////////////////////////////////////////////////////
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
            ////////////////////////////////////////////////////////////////// HURRICANE //////////////////////////////////////////////////////////////////
            {
                Console.WriteLine("----Hurricane----");
                Console.Write("Enter a hurricane category level out of; 1, 2, 3, 4, 5 ");
                int userCategory = Convert.ToInt32(Console.ReadLine());

                (category1 >= 64, category1 <= 95);

                DisplayMeasurement(1);
                DisplayMeasurement(2);
                DisplayMeasurement(3);
                DisplayMeasurement(4);
                DisplayMeasurement(5);

                void DisplayMeasurement(int measurement)
                {
                    switch (measurement)
                    {
                        case < 1:
                        case > 5:
                            Console.WriteLine($"Measured value is {measurement}; out of an acceptable range.");
                            break;

                        default:
                            Console.WriteLine($"Measured value is {measurement}.");
                            break;
                    }
                }

            }
            ////////////////////////////////////////////////////////////////// DICE GAME //////////////////////////////////////////////////////////////////
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
                    Console.WriteLine("Okay then ):");
                else
                    Console.WriteLine("Okay then :)");


                double winnings;

                double doubles = (bet * 2);
                double notDouble = (bet * 1.5);
                double evenSum = ;
                double oddSum = ;


                double moneyLeft = bet +- winnings;

                Console.WriteLine("You have: $" + moneyLeft + " left");


            }
            Console.ReadKey();
        }
    }
}