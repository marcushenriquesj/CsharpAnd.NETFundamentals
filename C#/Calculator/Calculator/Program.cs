using Microsoft.Win32;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Please, enter your name.");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}!");
            UserCalculations();


        }

        static void UserCalculations()
        {
            decimal num1 = 0, num2 = 0;
            bool enteredBothNums = false;
            string userInput = string.Empty;

            do
            {
                Console.WriteLine("please enter your first of two digits you wish to perform a calculation on or type 'exit' to exit app");
                userInput = Console.ReadLine();
                if (decimal.TryParse(userInput, out num1))
                {
                    Console.WriteLine($"The first number you entered is: {num1} \nPlease enter the second number or type 'exit' to exit app");
                    userInput = Console.ReadLine();
                    if (decimal.TryParse(userInput, out num2))
                    {
                        enteredBothNums = true;
                        break;
                    }
                }
                if (!enteredBothNums)
                {
                    Console.WriteLine("that was not a number lets try again!");
                }
            } while (userInput != "exit");

            
            bool isValidOperation = false;
            do
            {
                Console.WriteLine("Please type whether you want to use addition, subtraction, multiplication, and division.");
                userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "addition":
                        Console.WriteLine($"{num1} + {num2} = {Addition(num1, num2)}");
                        isValidOperation = true;
                        break;
                    case "subtraction":
                        Console.WriteLine($"{num1} - {num2} = {Subtraction(num1, num2)}");
                        isValidOperation = true;
                        break;
                    case "multiplication":
                        Console.WriteLine($"{num1} * {num2} = {Multiplication(num1, num2)}");
                        isValidOperation = true;
                        break;
                    case "division":
                        Console.WriteLine($"{num1} / {num2} = {Division(num1, num2)}");
                        isValidOperation = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid operation.");
                        break;

                }


            } while (!isValidOperation);
        }

        public static decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Division(decimal a, decimal b)
        {
            return a / b;
        }

        public static decimal Multiplication(decimal a, decimal b)
        {
            return a * b; 
        }



    }
}