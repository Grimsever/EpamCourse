namespace DataCalculation
{
    public class Data
    {
        const double tax = 0.13;
        public string userName;
        public double budget;
        public string source;
        public double income;
        private double incomeTax;

        public double IncomeTax
        {
            get
            {
                return incomeTax;
            }
            set
            {
                incomeTax = value * tax;
            }
        }
        public double actualBudget;
        public double outlay;

        public Data(string name, double budget, string source, double outlay, double income)
        {
            userName = name;
            this.budget = budget;
            this.source = source;
            this.outlay = outlay;
            this.income = income;
            IncomeTax = income;
            this.actualBudget = budget - outlay + income - IncomeTax;
        }
    }
}
