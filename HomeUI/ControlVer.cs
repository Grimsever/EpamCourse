using DataCalculation.Analizis;
using DataCalculation.Model;
using DataCalculation.ValidationInput;
using HomeUI.View;
using Ninject.Modules;

namespace HomeUI
{
    public class ControlVer : NinjectModule
    {
        public override void Load()
        {

            this.Bind<IUserData>().To<UserData>().InSingletonScope();
            this.Bind<IData>().To<Data>().InSingletonScope();
            this.Bind<IHandlerUI>().To<HandlerUI>();
            this.Bind<IInputData>().To<InputData>();
            this.Bind<IOutputData<string>>().To<OutputData>();
            this.Bind<IValidation<double>>().To<Validation>();
            this.Bind<IAnalizisOfData<string>>().To<DataAnalizis>();
        }
    }
}
