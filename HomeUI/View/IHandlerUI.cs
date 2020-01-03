using DataCalculation.Model;

namespace HomeUI.View
{
    public interface IHandlerUI
    {
        Choosee Choices { get; set; }
        bool HandlerMainPage(Choices choice);
        bool HandlerSecondPage(Choices choice);
        bool HandlerThiirdPage(Choices choice);

    }
}
