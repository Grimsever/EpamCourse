using DataUserModel.Users;

namespace DataAnaliz.Analiz
{
    public interface ICalculationCostMonth<T>
    {
        T FixExpensesPerMonth(User user);
        T VeriableExpensesPerMonth(User user);
        T IncomePerMonth(User user);
        T Delta(User user);
    }
}
