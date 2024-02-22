namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintTwoThousandNumbers()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintIncrementByThree()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CheckNumberEquality(int num1, int num2)
        {
            Console.WriteLine((num1 == num2) ? $"{num1} and {num2} are equal." : $"{num1} and {num2} are not equal.");
        }

        //Write a method to check whether a given number is even or odd
        public static void CheckEvenOdd(int userNum)
        {
            Console.WriteLine((userNum % 2 == 0) ? $"{userNum} is an even number." : $"{userNum} is an odd number.");
        }


        //Write a method to check whether a given number is positive or negative
        public static void CheckPositiveNegative(int userNum2)
        {
            Console.WriteLine((userNum2 > 0) ? $"{userNum2} is positive!" : $"{userNum2} is negative.");
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            int userAge;
            bool isInteger;

            Console.WriteLine("\nCheck to see if you are old enough to vote.");

            do
            {
                Console.Write("Enter your age: ");
                string userAgeInput = Console.ReadLine();
                isInteger = int.TryParse(userAgeInput, out userAge);

                if (isInteger == false)
                {
                    Console.WriteLine($"\nSorry, {userAgeInput} is not a valid input. Please try again.\n"); 
                }
                else
                {
                    Console.WriteLine((userAge >= 18) ? $"\nYou're {userAge}! Nice! You can legally vote!" : $"Oh no, you're {userAge}, you cannot legally vote.");
                }

            } while (isInteger == false);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void CheckInRange(int userNum3)
        {
            var myList = new List<int>();
            int myNumber = -10;
            bool isInList = false;

            do
            {
                myList.Add(myNumber);
                myNumber++;

            } while (myNumber <= 10);

            foreach (int num in myList)
            {
                if (num == userNum3)
                {
                    isInList = true;
                }
            }

            Console.WriteLine((isInList == true) ? $"Your number {userNum3} is in my list." : $"Your number {userNum3} is not in my list.");
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int userNum4)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {userNum4} = {(userNum4 * i)}");
            }
        }



        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            // LukeWarm Section:
            // Call Method 1
            PrintTwoThousandNumbers();
            // Call Method 2
            PrintIncrementByThree();

            // Prompt then Call Method 3
            Console.Write("Check if two numbers are the same.\nPlease enter an integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another integer: ");
            int num2 = int.Parse(Console.ReadLine());
            CheckNumberEquality(num1, num2);

            // Prompt then Call Method 4
            Console.Write("\nPlease enter an integer to check if it's odd or even: ");
            int userNum = int.Parse(Console.ReadLine());
            CheckEvenOdd(userNum);

            // Prompt then Call Method 5
            Console.Write("\nEnter an integer to check if it's positive or negative: ");
            int userNum2 = int.Parse(Console.ReadLine());
            CheckPositiveNegative(userNum2);

            // Call Method 6
            CanVote();

            // Prompt and Call Method 7
            Console.Write("\nEnter a number, negative or positive: ");
            int userNum3 = int.Parse(Console.ReadLine());
            CheckInRange(userNum3);

            // Prompt and Call Method 8
            Console.Write("\nEnter a number to display it's multiplication table: ");
            int userNum4 = int.Parse(Console.ReadLine());
            MultiplicationTable(userNum4);
        }
    }
}
