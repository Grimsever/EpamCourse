using DataCalculation.Model;

namespace HomeUI.View
{
    internal class HandlerUI : IHandlerUI
    {
        public Choosee Choices { get ; set ; }

        public HandlerUI()
        {
            Choices = new Choosee();
        }


        public bool HandlerMainPage(Choices choice)
        {
            switch (choice)
            {
                case DataCalculation.Model.Choices.Exit:
                    return false;
                default:
                    return true;
            }
        }

        public bool HandlerSecondPage(Choices choice)
        {
            switch (choice)
            {
                case DataCalculation.Model.Choices.Exit:
                    return false;
                case DataCalculation.Model.Choices.Income:
                    return true;
                case DataCalculation.Model.Choices.Outlay:
                    return true;
                case DataCalculation.Model.Choices.ThirdPage:
                    return true;
                default:
                    return true;
            }
        }

        public bool HandlerThiirdPage(Choices choice)
        {
            switch (choice)
            {
                case DataCalculation.Model.Choices.Exit:
                    return false;
                case DataCalculation.Model.Choices.GoBack:
                    return false;
                default:
                    return true;
            }
        }
    }
}
