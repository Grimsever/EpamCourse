using DataCalculation.Model;

namespace DataCalculation.Analizis
{
    public interface IAnalizisOfData<T>
    {
        IUserData UserData { get; set; }
        T GetInfoOfSpentMaxMoney();
        T GetInfoOfSpentMinMoney();
        T GetInfoOfMaxIncome();
        T GetInfoOfMinIncome();
        T GetInfoTable();

    }
}
