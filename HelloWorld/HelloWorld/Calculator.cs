using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Calculator
    {
        private List<int> listOfPrograms = new List<int>() { 1, 2 };

        public void StartCalculator()
        {
            Console.WriteLine("Initiating calculator");
            var success = false;
            var isCorrect = false;
            int programNumber = 0;
            while ((!success && !isCorrect) || (success && !isCorrect))
            {
                Console.WriteLine("1. Add, 2. End");
                Console.Write("Choose a program: ");
                var input = Console.ReadLine();
                success = Int32.TryParse(input, out programNumber);
                if (success)
                {
                    if (listOfPrograms.Contains(programNumber))
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Please choose an existing program");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number");
                }
            }
            
            switch (programNumber)
            {
                case 1:
                    Console.WriteLine("Program chosen: Add");
                    StartAdd();
                    StartCalculator();
                    break;
                case 2:
                    Console.WriteLine("Program ending, press enter to continue...");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }

        public void StartAdd()
        {
            var firstNumber = GetInputNumber("first");
            var secondNumber = GetInputNumber("second");
            var res = firstNumber + secondNumber;
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + res);
            Console.WriteLine("Press enter to restart calculator");
            Console.ReadLine();
        }

        private int GetInputNumber(string position)
        {
            while (true)
            {
                Console.Write("Choose " + position + " number: ");
                var input = Console.ReadLine();
                var success = Int32.TryParse(input, out int res);
                if (success)
                {
                    return res;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
        }
    }
}
