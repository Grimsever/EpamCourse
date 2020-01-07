namespace DataUserModel.UserDataValidation
{
    public interface IValidationNumber
    {
        string RuleValidationOfNumber { get; }
        bool CheckUserNumber(string num);
        bool CheckTwoUserNumber(string num1, string num2);
        bool CheckThreeUserNumber(string num1, string num2, string num3);
    }
}
