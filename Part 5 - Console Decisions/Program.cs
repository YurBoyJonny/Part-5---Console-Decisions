using System;
////////////////////////////////////////////////////////////////// MENU //////////////////////////////////////////////////////////////////
namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {             
            Console.WriteLine("Type 1 for STAGES, 2 for HURRICANE, or 3 for DICE GAME.");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                Stages();
            }
            if (menu == 2)
            {

            }
            if (menu == 3)
            {
                Dice();
            }
            else if (menu > 3)
            {
                Console.WriteLine("Error");
            }
            else if (menu < 1)
            {
                Console.WriteLine("Error");
            }

            
            

            ////////////////////////////////////////////////////////////////// STAGES //////////////////////////////////////////////////////////////////
            
                
           
            
        }

        public static void Stages()
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

        public static void Hurricane() 
        { 
            ////////////////////////////////////////////////////////////////// HURRICANE //////////////////////////////////////////////////////////////////

            Console.WriteLine("----Hurricane----");
            Console.Write("Enter a hurricane category level out of; 1, 2, 3, 4, 5 ");
            int userCategory = Convert.ToInt32(Console.ReadLine());
        }

        public static void Dice()
        {
            


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
                Console.WriteLine("You have $" + money + " in your bank account. How Much do you bet?");
                Double bet = Convert.ToDouble(Console.ReadLine());



                double winnings = 0;
                double doubles = (bet * 2);
                double notDouble = (bet * 1.5);
                double evenSum = bet;
                double oddSum = bet;

                Console.WriteLine("What side of the dice do you call?"); ///////////////////////////// 
                int diceSide = Convert.ToInt32(Console.ReadLine());

                Random rnd = new Random();
                int diceRolled = rnd.Next(1, 7);
                Console.WriteLine("The die landed on " + diceRolled); ///////////////////////////////// TWO DICE NEEDED
                if (diceRolled == 1)
                {
                    Console.WriteLine(diceOne);
                }
                else if (diceRolled == 2)
                {
                    Console.WriteLine(diceTwo);
                }
                else if (diceRolled == 3)
                {
                    Console.WriteLine(diceThree);
                }
                else if (diceRolled == 4)
                {
                    Console.WriteLine(diceFour);
                }
                else if (diceRolled == 5)
                {
                    Console.WriteLine(diceFive);
                }
                else if (diceRolled == 6)
                {
                    Console.WriteLine(diceSix);
                }


                if (diceSide == diceRolled)
                {
                    Console.WriteLine("Win!");

                }
                if (diceSide != diceRolled)
                {
                    Console.WriteLine("Lose!");
                }



                double moneyLeft = bet + -winnings;

                Console.WriteLine("You have: $" + moneyLeft + " left");




                Console.ReadKey();
            }
        }
    }
}