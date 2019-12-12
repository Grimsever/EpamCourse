using DataCalculation;
using System.Collections.Generic;

namespace HomeFinancialAssistant
{
    class UI
    {
        private DataInput dataInput;
        private DataOutput dataOutput;
        private List<Data> data;
        string GetTextOfMainPage
        {
            get
            {
                return "Please write the number of the your choice:\n1. Your name \n2. Your budget \nexit/e";
            }
        }
        string GetTextOfPageInputIncomeOutlay
        {
            get
            {
                return "Please make a choice." +
                    "\nTo enter income, enter 1, then enter income." +
                    "\nTo enter outlay, enter 2, then enter outlay." +
                    "\nTo show the result of your budget analysis, enter 3. " +
                    "\nTo exit enter 'exit'/'e'";
            }
        }

        string GetTextOfPageOutputData
        {
            get
            {
                dataOutput = new DataOutput(data);
                return dataOutput.OutputTable() + $"\n{dataOutput.GetInfoByMoney()}" + "\n2.Back \nExit/e";
            }
        }
        public UI()
        {
            data = new List<Data>();
            dataInput = new DataInput(data);
            GetMainPage();

        }
        void GetPageInputIncomeOutlay()
        {
            (bool, bool) isCheck;
            bool isExit;
            PrintToConsole("Helo 2 menu");
            do
            {
                isExit = false;
                System.Console.Clear();
                PrintToConsole(GetTextOfPageInputIncomeOutlay);
                string choice = ReadConsole();
                isCheck=HandlerPageInputIncomeOutlay(choice);
                if (isCheck.Item1 && !isCheck.Item2)
                {
                    PrintToConsole("You made a mistake in entering");
                }
                if (!isCheck.Item1 && isCheck.Item2)
                {
                    PrintToConsole("You choice is wrong");
                }
                if (choice == "3")
                {
                    GetOutputPage(out isExit);
                }
            }
            while ((isCheck.Item1 || isCheck.Item2) && !isExit);
        }
        void GetMainPage()
        {
            bool isName = false;
            bool isBudget = false;
            (bool, bool) isExit = (true, true);
            string choice;
            do
            {
                System.Console.Clear();
                PrintToConsole(GetTextOfMainPage);
                choice = ReadConsole();
                if (choice == "1")
                {
                    isName = HandlerMainPage(choice).Item2;
                }
                if (choice == "2")
                {
                    isBudget = HandlerMainPage(choice).Item2;
                }
                if (isName && isBudget)
                {
                    GetPageInputIncomeOutlay();
                    break;
                }
                if (choice != "1" && choice != "2")
                {
                    isExit = HandlerMainPage(choice);
                }
                Wait();
            }
            while (isExit.Item1 && isExit.Item2);
        }

        void GetOutputPage(out bool isExit)
        {
            string choice;
            do
            {
                System.Console.Clear();
                PrintToConsole(GetTextOfPageOutputData);
                choice = ReadConsole();
            }
            while (HandlerPageOutputData(choice, out isExit));
        }
        (bool, bool) HandlerMainPage(string choice)
        {
            string input;
            bool check;
            switch (choice.ToLower())
            {
                case "1":
                    PrintToConsole("Write your name");
                    input = ReadConsole();
                    check = dataInput.ReadInputUserName(input);
                    if (!check)
                    {
                        PrintToConsole("You made a mistake in entering in name");
                    }
                    else
                    {
                        PrintToConsole("You wrote correct name");
                    }
                    return (true, check);
                case "2":
                    PrintToConsole("Write your budget");
                    input = ReadConsole();
                    check = dataInput.ReadInputBudget(input);
                    if (!check)
                    {
                        PrintToConsole("You made a mistake in entering in name");
                    }
                    else
                    {
                        PrintToConsole("You wrote correct budget");
                    }
                    return (true, check);
                case "e":
                    return (false, false);
                case "exit":
                    return (false, false);
                default:
                    return (true, true);
            }
        }

        (bool, bool) HandlerPageInputIncomeOutlay(string choice)
        {
            switch (choice.ToLower())
            {
                case "1":
                    PrintToConsole("Please write your income");
                    string input = ReadConsole();
                    PrintToConsole("Please write your source the income");
                    string source = ReadConsole();
                    return (true, dataInput.ReadInputIncome(input, source));
                case "2":
                    PrintToConsole("Please write your outlay");
                    input = ReadConsole();
                    PrintToConsole("Please write your purpose the outlay");
                    source = ReadConsole();
                    return (true, dataInput.ReadInputOutlay(input, source));
                case "3":
                    return (true, true);
                case "e":
                    return (false, false);
                case "exit":
                    return (false, false);
                default:
                    return (false, true);
            }
        }

        bool HandlerPageOutputData(string choice, out bool isExit)
        {
            switch (choice.ToLower())
            {
                case "2":
                    isExit = false;
                    return false;
                case "exit":
                    isExit = true;
                    return false;
                case "e":
                    isExit = true;
                    return false;
                default:

                    isExit = false;
                    return true;
            }
        }

        void PrintToConsole(string output)
        {
            System.Console.WriteLine(output);
        }

        string ReadConsole()
        {
            return System.Console.ReadLine();
        }
        void Wait()
        {
            System.Console.ReadKey();
        }

    }
}
