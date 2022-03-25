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
                Hurricane();
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
        }
////////////////////////////////////////////////////////////////// STAGES //////////////////////////////////////////////////////////////////
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
        ////////////////////////////////////////////////////////////////// HURRICANE //////////////////////////////////////////////////////////////////
        public static void Hurricane()
        {
            Console.WriteLine("----Hurricane----");
            Console.WriteLine("Enter a hurricane category level out of; 1, 2, 3, 4, 5 ");
            int userCategory = Convert.ToInt32(Console.ReadLine());

            Console.Write("This hurricane category is ");
            switch (userCategory)
            {
                case 1:
                    Console.WriteLine("74-95 mph or 64-82 kt or 119-153 km/hr");
                    break;
                case 2:
                    Console.WriteLine("96-110 mph or 83-95 kt or 154-177 km/hr");
                    break;
                case 3:
                    Console.WriteLine("111-130 mph or 96-113 kt or 178-209 km/hr");
                    break;
                case 4:
                    Console.WriteLine("131-155 mph or 114-135 kt or 210-249 km/hr");
                    break;
                case 5:
                    Console.WriteLine("Greater than 155 mph or 135 kt or 249 km/hr");
                    break;
                default:
                    break;
            }
        }
////////////////////////////////////////////////////////////////// DICE GAME //////////////////////////////////////////////////////////////////
        public static void Dice()
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

            if (bet < 0 || bet > money)
            {
                bet = 0;
            }

            double originalSum = money - bet;
            double doubles = (bet * 2);
            double notDouble = (bet * 1.5);
            double evenSum = (bet * 2);
            double oddSum = (bet * 2);

            Console.WriteLine("Type 1 for doubles,2 for not double, 3 for even sum, or 4 for odd sum");
            int outcomeBet = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int diceRolled1 = rnd.Next(1, 7);
            new Random();
            int diceRolled2 = rnd.Next(1, 7);
            double bothDice = diceRolled1 + diceRolled2;
            Console.WriteLine("You got " + bothDice);

            if (diceRolled1 == 1 || diceRolled2 == 1)
            {
                Console.WriteLine(diceOne);
            }
            if (diceRolled1 == 2 || diceRolled2 == 2)
            {
                Console.WriteLine(diceTwo);
            }
            if (diceRolled1 == 3 || diceRolled2 == 3)
            {
                Console.WriteLine(diceThree);
            }
            if (diceRolled1 == 4 || diceRolled2 == 4)
            {
                Console.WriteLine(diceFour);
            }
            if (diceRolled1 == 5 || diceRolled2 == 5)
            {
                Console.WriteLine(diceFive);
            }
            if (diceRolled1 == 6 || diceRolled2 == 6)
            {
                Console.WriteLine(diceSix);
            }

            if (diceRolled1 == diceRolled2 && outcomeBet == 1)
            {
                bet = Convert.ToDouble(doubles);
                double moneyLeft = doubles + originalSum;
                Console.WriteLine("You have: $" + moneyLeft + " left");
            }
            if (diceRolled1 != diceRolled2 && outcomeBet == 2)
            {
                bet = Convert.ToDouble(notDouble);
                double moneyLeft = notDouble + originalSum;
                Console.WriteLine("You have: $" + moneyLeft + " left");
            }
            if (outcomeBet == 3 && (bothDice == 2 || bothDice == 4 || bothDice == 6 || bothDice == 8 || bothDice == 10 || bothDice == 12))
            {
                bet = Convert.ToDouble(evenSum);
                double moneyLeft = evenSum + originalSum;
                Console.WriteLine("You have: $" + moneyLeft + " left");
            }
            if (outcomeBet == 4 && (bothDice == 1 || bothDice == 3 || bothDice == 5 || bothDice == 7 || bothDice == 9 || bothDice == 11))
            { 
                bet = Convert.ToDouble(oddSum);
                double moneyLeft = oddSum + originalSum;
                Console.WriteLine("You have: $" + moneyLeft + " left");
            }

            double moneyLeft1 = money + originalSum;
            Console.WriteLine("You have: $" + moneyLeft1 + " left");
            Console.ReadKey();
        }
    }
}

