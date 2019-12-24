namespace DataCalculation.Model
{
    public enum Choices
    {
        Income = 1,
        Outlay,
        ThirdPage,
        GoBack,
        Exit,
        Mistacke,
    }
    public class Choice
    {
        public Choices ConvertStringToChoice(string input)
        {
            switch (input.ToLower())
            {
                case "1":
                    return Choices.Income;
                case "2":
                    return Choices.Outlay;
                case "3":
                    return Choices.ThirdPage;
                case "go back":
                    return Choices.GoBack;
                case "back":
                    return Choices.GoBack;
                case "b":
                    return Choices.GoBack;
                case "exit":
                    return Choices.Exit;
                case "e":
                    return Choices.Exit;
                default:
                    return Choices.Mistacke;
            }
        }
    }
}
