using DataCalculation.Model;

namespace DataCalculation.ValidationInput
{
    public interface IValidation<T>
    {
        bool ValidationName(string input);
        bool ValidationNumber(string input, out T number);
        bool ValidationForAnalizis(IUserData dataUser);
    }
}
