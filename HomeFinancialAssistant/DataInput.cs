using DataCalculation;
using System.Collections.Generic;

namespace HomeFinancialAssistant
{
    class DataInput
    {
        List<Data> data;
        string name;
        double budget;
        public DataInput(List<Data> data)
        {
            this.data = data;
            data.Add(new Data("", 0));
        }
        public bool ReadInputUserName(string input)
        {

            if (input != "")
            {
                data[0].userName = input;
                name = input;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ReadInputBudget(string input)
        {

            if (double.TryParse(input, out double budget) && budget > 0)
            {
                data[0].budget = budget;
                this.budget = budget;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ReadInputIncome(string input, string source)
        {
            if (double.TryParse(input, out double income) && income > 0)
            {
                if (Data.count > 1)
                {
                    budget = data[Data.count-2].actualBudget;
                    data.Add(new Data(name, budget, source, 0, income));
                }
                else if (Data.count == 1)
                {
                    data[0].income = income;
                    data[0].source = source;
                    data[0].actualBudget = data[0].budget + income;
                    Data.count++;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ReadInputOutlay(string input, string source)
        {
            if (double.TryParse(input, out double outlay) && outlay > 0)
            {
                if (Data.count > 1)
                {
                    budget = data[Data.count-2].actualBudget;
                    data.Add(new Data(name, budget, source, outlay, 0));

                }
                else if (Data.count == 1)
                {
                    data[0].outlay = outlay;
                    data[0].source = source;
                    data[0].actualBudget = data[0].budget - outlay;
                    Data.count++;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
