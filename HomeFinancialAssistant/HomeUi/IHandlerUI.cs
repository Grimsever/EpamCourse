using DataCalculation.Model;

namespace HomeFinancialAssistant.HomeUi
{
    public interface IHandlerUI
    {
        Choice _Choices { get; set; }
        bool HandlerMainPage(Choices choice);
        bool HandlerSecondPage(Choices choice);
        bool HandlerThiirdPage(Choices choice);

    }
}
