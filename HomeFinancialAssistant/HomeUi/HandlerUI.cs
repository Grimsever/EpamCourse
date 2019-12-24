
using DataCalculation.Model;

namespace HomeFinancialAssistant.HomeUi
{
    public class HandlerUI : IHandlerUI
    {
        public Choice _Choices { get ; set ; }

        public HandlerUI()
        {
            _Choices = new Choice();
        }


        public bool HandlerMainPage(Choices choice)
        {
            switch (choice)
            {
                case Choices.Exit:
                    return false;
                default:
                    return true;
            }
        }

        public bool HandlerSecondPage(Choices choice)
        {
            switch (choice)
            {
                case Choices.Exit:
                    return false;
                case Choices.Income:
                    return true;
                case Choices.Outlay:
                    return true;
                case Choices.ThirdPage:
                    return true;
                default:
                    return true;
            }
        }

        public bool HandlerThiirdPage(Choices choice)
        {
            switch (choice)
            {
                case Choices.Exit:
                    return false;
                case Choices.GoBack:
                    return false;
                default:
                    return true;
            }
        }
    }
}
