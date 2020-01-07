using DataAnaliz.Analiz;
using DataAnaliz.Calculator;
using DataUserModel.Users;

namespace FirstCode.Realization
{
    public class CalculationCostForMonth : ICalculationCostMonth<decimal>
    {
        ICalculator<decimal> Calculator { get; set; }
        public CalculationCostForMonth(ICalculator<decimal> calculator)
        {
            Calculator = calculator;
        }
        public decimal FixExpensesPerMonth(User user)
        {
            decimal exp = user.data.RentalPrice;
            for (int i = 0; i < user.data.Workers.Length; i++)
            {
                exp = Calculator.Addition(exp, user.data.Workers[i].Salary);
            }
            return exp;
        }
        public decimal VeriableExpensesPerMonth(User user)
        {
            return Calculator.Multiplication(user.data.Products.PurchasePrice, (decimal)user.data.Products.Count);
        }
        public decimal IncomePerMonth(User user)
        {
            return Calculator.Multiplication(user.data.Products.SalePrice, (decimal)user.data.Products.Count);
        }

        public decimal Delta(User user)
        {
            return Calculator.Subtraction(IncomePerMonth(user), Calculator.Addition(FixExpensesPerMonth(user), VeriableExpensesPerMonth(user)));
        }
    }
}
