using DataCalculation;
using System.Collections.Generic;

namespace HomeFinancialAssistant
{
    class UI
    {
        private DataInput dataInput;
        private DataOutput dataOutput;
        private List<Data> data;
        public string GetMainPage
        {
            get
            {
                return "Please write your name, and budget";
            }
        }
        public string GetPageInputIncomeOutlay
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

        public string GetPageOutputData
        {
            get
            {
                dataOutput = new DataOutput(data);
                return dataOutput.OutputTable()+$"\n{dataOutput.GetInfoByMoney()}"+ "\n2.Back \nExit/e";
            }
        }
        public UI()
        {
            data = new List<Data>();

            dataInput = new DataInput(data);
        }
        public bool HandlerMainPage(string choice,string input)
        {
            switch (choice.ToLower())
            {
                case "1":
                    return dataInput.ReadInputUserName(input);
                case "2":
                    return dataInput.ReadInputBudget(input);
                case "e":
                    return false;
                case "exit":
                    return false;
                default:
                    return false;
            }
        }

        public bool HandlerPageInputIncomeOutlay(string choice, string input, string source)
        {
            switch (choice.ToLower())
            {
                case "1":
                    return dataInput.ReadInputIncome(input,source);                    
                case "2":
                    return dataInput.ReadInputOutlay(input,source);
                default:
                    return true;
            }
        }

        public bool HandlerPageOutputData(string choice)
        {
            switch (choice.ToLower())
            {
                case "2":
                    return false;
                case "exit":
                    return false;
                case "e":
                    return false;
                default:
                    return true;
            }
        }




    }
}
