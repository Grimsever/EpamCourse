using Calculator.Model;
using System;


namespace Calculator.CalculatorConsole
{
    public class UiConsole
    {
        private ICommandList commands;
        public UiConsole(ICommandList commandList)
        {
            commands = commandList;
        }
        public void Start()
        {
           Console.WriteLine("Write two numbers/strings/chars");
            object first = Console.ReadLine();
            object sec = Console.ReadLine();
            ICalculator calc= commands.GetCalc((string)first, (string)sec);
            Console.WriteLine($"Your type is {calc.Numb1.GetType()}");
            Console.ReadKey();
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Make choice operation");
                Console.WriteLine(GetMenuOperation());
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result is {calc.Addition()}");
                        break;
                    case "2":
                        Console.WriteLine($"Result is {calc.Subtraction()}");
                        break;
                    case "3":
                        Console.WriteLine($"Result is {calc.Multiplication()}");
                        break;
                    case "4":
                        Console.WriteLine($"Result is {calc.Division()}");
                        break;
                    case "ex":
                        Console.WriteLine("Bye");
                        break;
                    case "exit":
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("You made the wrong choice");
                        break;
                }
                Console.ReadKey();
            }
            while (choice!="ex" && choice!="exit");
        }
        public string GetMenuOperation()
        {
            return $"1.Addition \n2.Subtraction \n3.Multiplication \n4.Division \nFor break write exit/ex";

        }
    }
}
