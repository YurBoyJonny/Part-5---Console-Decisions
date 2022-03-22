using System;
namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////// MENU //////////////////////////////////////////////////////////////////
            {
                {
                    Console.WriteLine("Type 1 for STAGES, 2 for HURRICANE, or 3 for DICE GAME.");
                    int menu = Convert.ToInt32(Console.ReadLine());
                    if (menu == 1)
                    {
                        Console.WriteLine("Stages");
                    }
                    else if (menu > 1)
                    {
                        Console.WriteLine("Error");
                    }
                    else if (menu < 1)
                    {
                        Console.WriteLine("Error");
                    }

                }
            }
            ////////////////////////////////////////////////////////////////// STAGES //////////////////////////////////////////////////////////////////
            {
                Console.WriteLine("----Stages----");
                int age;
                Console.WriteLine("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age > 18)
                {
                    Console.WriteLine("Adult");
                }
                else if (age < 0)
                {
                    Console.WriteLine("Error");
                }
                else if (age <= 5)
                {
                    Console.WriteLine("Toddler");
                }
                else if (age <= 10)
                {
                    Console.WriteLine("Child");
                }
                else if (age <= 12)
                {
                    Console.WriteLine("Preteen");
                }
                else if (age > 12)
                {
                    Console.WriteLine("Teen");
                }
            }
            ////////////////////////////////////////////////////////////////// HURRICANE //////////////////////////////////////////////////////////////////
            {
                Console.WriteLine("----Hurricane----");
                Console.Write("Enter a hurricane category level out of; 1, 2, 3, 4, 5 ");
                int userCategory = Convert.ToInt32(Console.ReadLine());

                

            }
            ////////////////////////////////////////////////////////////////// DICE GAME //////////////////////////////////////////////////////////////////
            {
                string diceOne = (@"-----
|   |
| o |
|   |
-----");
                string diceTwo = (@"-----
|o  |
|   |
|  o|
-----
");
                string diceThree = (@"-----
|o  |
| o |
|  o|
-----
");
                string diceFour = (@"-----
|o o|
|   |
|o o|
-----
");
                string diceFive = (@"-----
|o o|
| o |
|o o|
-----
");
                string diceSix = (@"-----
|o o|
|o o|
|o o|
-----
");
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



                    
                Console.WriteLine(diceOne);
                Console.WriteLine(diceTwo);
                Console.WriteLine(diceThree);
                Console.WriteLine(diceFour);
                Console.WriteLine(diceFive);
                Console.WriteLine(diceSix);

                double winnings = 0;

                double doubles = (bet * 2);
                double notDouble = (bet * 1.5);
                double evenSum = bet;
                double oddSum = bet;


                double moneyLeft = bet +- winnings;

                Console.WriteLine("You have: $" + moneyLeft + " left");

                

            }
            Console.ReadKey();
        }
    }
}