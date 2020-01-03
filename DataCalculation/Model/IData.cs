namespace DataCalculation.Model
{
    public interface IData
    {
        double ActualBudget { get; set; }
        double Income { get; set; }
        double IncomeTax { get; set; }
        string Source { get; set; }
        double Outlay { get; set; }
    }
}
