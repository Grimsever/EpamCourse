using DataCalculation.Analizis;
using DataCalculation.Model;
using DataCalculation.ValidationInput;
using Ninject.Modules;



namespace DataCalculation.Control
{
    public class VersionControlNinject : NinjectModule
    {
        public override void Load()        {
            this.Bind<IData>().To<Data>();
            this.Bind<IUserData>().To<UserData>();
            this.Bind<IValidation<double>>().To<Validation>();
            this.Bind<IAnalizisOfData<string>>().To<DataAnalizis>();
             
           // this.Bind<IUI<string>>().To<UI>();

        }
    }
}
