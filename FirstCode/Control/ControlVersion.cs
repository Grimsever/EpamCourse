using DataAnaliz.Analiz;
using DataAnaliz.Calculator;
using DataUserModel.OperationWithFile;
using DataUserModel.UserDataValidation;
using DataUserModel.Users.DataAccessLayer;
using FirstCode.Realization;
using Ninject.Modules;

namespace FirstCode.Control
{
    public class ControlVersion : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ICalculator<decimal>>().To<Calculator>();
            this.Bind<IValidationNumber>().To<ValidationNumber>();
            this.Bind<IUserData>().To<UserData>();
            this.Bind<IFileOperation>().To<FileOperation>();
            this.Bind<ICalculationCostMonth<decimal>>().To<CalculationCostForMonth>();
        }
    }
}
