using DataCalculation.Model;

namespace DataCalculation.ValidationInput
{
    public class Validation : IValidation<double>
    {
        public bool ValidationForAnalizis(IUserData dataUser)
        {
            return dataUser.Datas.Count > 0 ? true : false;
        }

        public bool ValidationName(string input)
        {
            return input != "" ? true : false;
        }

        public bool ValidationNumber(string input, out double number)
        {
            double.TryParse(input, out number);
            return number > 0 ? true : false;
        }
    }
}
