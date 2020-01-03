namespace DataCalculation.Model
{
    public class Data : IData
    {
        const double tax = 0.13;
        public double ActualBudget { get; set; }
        public double Income { get; set; }
        public string Source { get; set; }
        public double Outlay { get; set; }
        private double incomeTax;
        public double IncomeTax
        {
            get
            {
                return incomeTax;
            }
            set
            {
                incomeTax = Income * tax;
            }
        }
        public Data(double budget, double income, double outlay, string source)
        {
            Income = income;
            Source = source;
            Outlay = outlay;
            IncomeTax = income;
            ActualBudget = budget - outlay - IncomeTax + income;

        }
    }
}
