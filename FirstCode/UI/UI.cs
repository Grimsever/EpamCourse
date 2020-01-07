using DataAnaliz.Analiz;
using DataAnaliz.Calculator;
using DataUserModel.UserDataValidation;
using DataUserModel.Users;
using DataUserModel.Users.DataAccessLayer;
using FirstCode.Realization;
using System.Globalization;

namespace FirstCode.UI
{
    public class UI
    {
        private readonly ICalculator<decimal> calculator;

        private readonly ICalculationCostMonth<decimal> calculationCost;

        private readonly IValidationNumber validationNumber;

        private readonly IUserData users;
        private readonly ConsoleInputData consoleInput;
        private readonly ConsoleOutputData consoleOutput;

        NumberFormatInfo Myformat = new NumberFormatInfo();
        public UI(ICalculator<decimal> calculator, ICalculationCostMonth<decimal> calculationCost, IValidationNumber validation, IUserData userData)
        {
            this.calculator = calculator;
            this.calculationCost = calculationCost;
            validationNumber = validation;
            users = userData;
            Myformat.NumberDecimalSeparator = ",";
            consoleOutput = new ConsoleOutputData();
            consoleInput = new ConsoleInputData();
            Start();
        }
        public bool LogIn(string userName, string userPass)
        {
            return users.GetUser(userName, userPass) is User;
        }

        public void Start()
        {
            consoleOutput.ConsoleReport("Hello!\nWrite your name");
            string name = consoleInput.Read();
            consoleOutput.ConsoleReport("Write your password");
            string pass = consoleInput.Read();
            User user;
            if (LogIn(name, pass))
            {
                user = users.GetUser(name, pass);
                consoleOutput.ConsoleReport("User was found");
                GetChoice(user);
            }
            else
            {
                consoleOutput.ConsoleReport("User is not found");
                user = new User(new Data());
                user.Name = name;
                user.Password = pass;
                AddDataUser(user);
            }
        }

        public void GetChoice(User user)
        {
            consoleOutput.ConsoleReport("1. Get info\n2. Edit user info\n3.Delete user and create new");
            switch (consoleInput.Read())
            {
                case "1":
                    GetInfo(user);
                    break;
                case "2":
                    AddDataUser(user);
                    break;
                case "3":
                    users.DeleteUser(user);
                    Start();
                    break;
            }
        }
        public void AddDataUser(User user)
        {
            consoleOutput.ConsoleReport("Add information about four employee");
            for (int i = 0; i < user.data.Workers.Length;)
            {
                consoleOutput.ConsoleReport("Enter name");
                
                string name = consoleInput.Read();
                consoleOutput.ConsoleReport("Enter a profession");
                string prof = consoleInput.Read();
                consoleOutput.ConsoleReport("Enter a salary");
                string salary = consoleInput.Read();
                if (validationNumber.CheckUserNumber(salary))
                {
                    user.data.Workers[i] = new Worker(name, prof, decimal.Parse(salary.Replace(',', '.')));
                    i++;
                    consoleOutput.ConsoleReport($"Employee number {i} was entered");
                }
                else
                {
                    consoleOutput.ConsoleReport("You made a mistake in entering salary");
                }
            }
            do
            {
                consoleOutput.ConsoleReport("Add information about product");
                consoleOutput.ConsoleReport("Enter name");
                string name = consoleInput.Read();
                consoleOutput.ConsoleReport("Enter a purchase price");
                string price = consoleInput.Read();
                consoleOutput.ConsoleReport("Enter a count");
                string count = consoleInput.Read();
                consoleOutput.ConsoleReport("Enter a percentage mark-up");
                string percent = consoleInput.Read();
                if (validationNumber.CheckThreeUserNumber(price, count, percent))
                {

                    user.data.Products = new Product(name, decimal.Parse(price), double.Parse(count), double.Parse(percent));
                    break;
                }
                consoleOutput.ConsoleReport("You made a mistake");
            }
            while (true);
            do
            {
                consoleOutput.ConsoleReport("Add cost rental");
                string cost = consoleInput.Read();
                if (validationNumber.CheckUserNumber(cost))
                {
                    user.data.RentalPrice = decimal.Parse(cost);
                    break;
                }
                consoleOutput.ConsoleReport("You made a mistake");
            }
            while (true);
            users.AddUser(user);
            consoleOutput.ConsoleReport("You added all information");
            GetInfo(user);
        }
        public void GetInfo(User user)
        {
            System.Console.Clear();
            string info = $"Name:{user.Name} Pass: {user.Password}";
            info += $"\nCost rental {user.data.RentalPrice} \nProduct: Name {user.data.Products.Name} Cost {user.data.Products.PurchasePrice}  Count {user.data.Products.Count} Sale cost {user.data.Products.SalePrice}";
            info += "\nEmployees";
            for (int i = 0; i < 4; i++)
            {
                info += $"\nName {user.data.Workers[i].Name} Prof {user.data.Workers[i].Profession} Sal {user.data.Workers[i].Salary}";
            }
            consoleOutput.ConsoleReport(info);
            consoleOutput.ConsoleReport("Result");
            string res = $"Income per Month {calculationCost.IncomePerMonth(user)}";
            res += $"\nFix expenses per Month {calculationCost.FixExpensesPerMonth(user)}";
            res += $"\n Variable expenses per Month {calculationCost.VeriableExpensesPerMonth(user)}";
            consoleOutput.ConsoleReport(res);
            consoleOutput.ConsoleReport($"Delta per month: {calculationCost.Delta(user)}");
        }

    }

}
