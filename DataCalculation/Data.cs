namespace DataCalculation
{
    public class Data
    {
        public static int count=0;
        public string userName;
        public double budget;
        public string source;
        public double income;
        public double actualBudget;
        public double outlay;

        public Data(string name, double budget)
        {
            this.userName = name;
            this.budget = budget;
            source = "";
            income = 0;
            outlay = 0;
            actualBudget = 0;
        }
        public Data(string name, double budget, string source,double outlay, double income)
        {
            userName = name;
            this.budget = budget;
            this.source = source;
            this.outlay = outlay;
            this.income = income;
            this.actualBudget = budget -outlay +income;
        }
    }
}
