using DataUserModel.UserDataValidation;
using System.Text.RegularExpressions;

namespace FirstCode.Realization
{
    public class ValidationNumber : IValidationNumber
    {
        public string RuleValidationOfNumber { get; private set; }

        public ValidationNumber()
        {
            RuleValidationOfNumber = @"[^-+0-9.,]";
        }

        public bool CheckUserNumber(string num)
        {
            if (Regex.IsMatch(num, RuleValidationOfNumber))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckTwoUserNumber(string num1, string num2)
        {
            if (Regex.IsMatch(num1, RuleValidationOfNumber) && Regex.IsMatch(num2, RuleValidationOfNumber))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckThreeUserNumber(string num1, string num2, string num3)
        {
            if (Regex.IsMatch(num1, RuleValidationOfNumber) && Regex.IsMatch(num2, RuleValidationOfNumber) && Regex.IsMatch(num3, RuleValidationOfNumber))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}
