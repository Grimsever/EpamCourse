
using DataCalculation.Model;
using DataCalculation.ValidationInput;
using HomeFinancialAssistant.InputAndOutPut;
using System;

namespace HomeFinancialAssistant.HomeUi
{
    public class UI : IUI<string>
    {
        Choice choice = new Choice();
        public IValidation<double> Validation { get; set; }

        public IInputData InputData { get; set; }
        public IOutputData<string> OutputData { get; set; }
        public IUserData UserData { get; set; }
        public IHandlerUI Handler { get; set; }
        public string thirdPage;
        public string MainPage { get => "Please enter your name  \nFor exit enter: exit or e"; }
        public string SecondPage
        {
            get => "Please make a choice." +
                    "\nTo enter income, enter 1, then enter income." +
                    "\nTo enter outlay, enter 2, then enter outlay." +
                    "\nTo show the result of your budget analysis, enter 3. " +
                    "\nTo exit enter 'exit'/'e'";
        }
        public string ThirdPage { get => thirdPage; set => value=thirdPage; }

        public UI()
        {
            UserData = new UserData();
            Handler = new HandlerUI();
            Validation = new Validation();
            InputData = new InputData(UserData);
            OutputData = new OutputData(UserData,Validation);
            GetMainPage();
        }

        public void GetThirdPage(out Choices input)
        {
            do
            {
                Console.Clear();
                thirdPage = $"{UserData.UserName} your start budget was = {UserData.InitailBudget}" +
                    $"\n{OutputData.AnalizisOfData.GetInfoOfMaxIncome()} \n{OutputData.AnalizisOfData.GetInfoOfMinIncome()} " +
                    $"\n{OutputData.AnalizisOfData.GetInfoOfSpentMaxMoney()} \n{OutputData.AnalizisOfData.GetInfoOfSpentMinMoney()}" +
                    $"\n{OutputData.AnalizisOfData.GetInfoTable()}" +
                    $"\nTo exit write: exit/e" +
                    $"\nTo go to back write: back/go back/b";
                OutputData.WriteConsolePage(ThirdPage);
                input = choice.ConvertStringToChoice(Console.ReadLine());
            }
            while (Handler.HandlerThiirdPage(input));
        }
        public void GetSecondPage()
        {
            Choices input;
            do
            {
                Console.Clear();
                OutputData.WriteConsolePage(SecondPage);
                input = choice.ConvertStringToChoice(Console.ReadLine());
                switch (input)
                {
                    case Choices.Income:
                        Console.WriteLine("Enter income");
                        if (Validation.ValidationNumber(Console.ReadLine(), out double income))
                        {
                            Console.WriteLine("Enter a source of money");
                            string source = Console.ReadLine();
                            InputData.InputIncomeAndSource(income, source);
                        }
                        break;
                    case Choices.Outlay:
                        Console.WriteLine("Enter outlay");
                        if (Validation.ValidationNumber(Console.ReadLine(), out double outlay))
                        {
                            Console.WriteLine("Enter a source of money");
                            string source = Console.ReadLine();
                            InputData.InputOutlayAndSource(outlay, source);
                        }
                        break;
                    case Choices.ThirdPage:
                        GetThirdPage(out input);
                        break;
                }
            }
            while (Handler.HandlerSecondPage(input));
        }
        public void GetMainPage()
        {
            do
            {
                Console.Clear();
                OutputData.WriteConsolePage(MainPage);
                string name = Console.ReadLine();
                if (Validation.ValidationName(name))
                {
                    OutputData.WriteConsoleReport("Name was entering correct");
                    InputData.InputUserName(name);
                    Console.WriteLine("Please enter your budget");
                    string budgetString = Console.ReadLine();
                    if (Validation.ValidationNumber(budgetString, out double budget))
                    {
                        InputData.InputBudget(budget);
                        OutputData.WriteConsoleReport("Budget was entering correct");
                        GetSecondPage();
                        break;
                    }
                    else if (Handler.HandlerMainPage(choice.ConvertStringToChoice(budgetString)))
                    {
                        break;
                    }
                }
                else if (Handler.HandlerMainPage(choice.ConvertStringToChoice(name)))
                {
                    break;
                }
                else 
                {
                    Console.ReadKey();
                }
            }
            while (true);
        }
    }
}
