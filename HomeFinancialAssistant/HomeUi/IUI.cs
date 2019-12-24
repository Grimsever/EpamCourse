using DataCalculation.ValidationInput;
using HomeFinancialAssistant.InputAndOutPut;

namespace HomeFinancialAssistant.HomeUi
{
    public interface IUI<T>
    {
        IInputData InputData { get; set; }
        IValidation<double> Validation { get; set; }
        IOutputData<string> OutputData { get; set; }
        T MainPage { get; }
        T SecondPage { get; }
        T ThirdPage { get; set; }
        IHandlerUI Handler { get; set; }


    }
}
