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
        }
        public bool ReadInputUserName(string input)
        {

            if (input != "")
            {
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
                budget = data.Count >= 1 ?  data[data.Count - 1].actualBudget : this.budget;
                data.Add(new Data(name, budget, source, 0, income));
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
                budget = data.Count >= 1 ? data[data.Count - 1].actualBudget : this.budget;
                data.Add(new Data(name, budget, source, outlay, 0));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
