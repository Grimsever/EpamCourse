using System;

namespace HomeFinancialAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            UI uI = new UI();

            Print(uI.GetMainPage);
            do
            {
                if (uI.HandlerMainPage("1", ReadConsole())&&uI.HandlerMainPage("2",ReadConsole()))
                {
                    Print("You entered everything right");
                    Wait();
                    break;
                }
                else
                {
                    Print("You made a mistake :( \nPlease try again");
                    Wait();
                    Console.Clear();
                    Print(uI.GetMainPage);
                }

            }
            while (true);

            string choose;
            do
            {
                do
                {
                    Console.Clear();
                    Print(uI.GetPageInputIncomeOutlay);
                    choose = ReadConsole();
                    if (choose == "1")
                    {
                        Print("Enter your income and source of income");
                        if (uI.HandlerPageInputIncomeOutlay(choose,ReadConsole(), ReadConsole()))
                        {
                            Print("You entered your income and source of income");
                            Wait();
                        }
                        else
                        {
                            Print("You made a mistake when entering income. Try again.");
                            Wait();
                        }
                    }
                    if (choose == "2")
                    {
                        Print("Enter your outlay and purpose of outlay");
                        if (uI.HandlerPageInputIncomeOutlay(choose,ReadConsole(), ReadConsole()))
                        {
                            Print("You entered your outlay and purpose of outlay");
                            Wait();
                        }
                        else
                        {
                            Print("You made a mistake when entering outlay. Try again.");
                            Wait();
                        }
                    }
                }
                while (choose != "exit" && choose != "e" && choose != "3");

                if (choose == "3")
                {
                    do
                    {
                        Console.Clear();
                        Print(uI.GetPageOutputData);
                        choose = ReadConsole();
                    }
                    while (uI.HandlerPageOutputData(choose));
                }
            }
            while (choose.ToLower() != "exit" && choose != "e");
        }
        public static void Print(string menu)
        {
            Console.WriteLine(menu);
        }
        public static string ReadConsole()
        {
            return Console.ReadLine();
        }
        public static void Wait()
        {
            Console.ReadKey();
        }
    }
}
