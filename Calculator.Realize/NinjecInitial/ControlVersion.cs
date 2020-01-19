using Calculator.Model;
using Calculator.Realize.CalcChar;
using Calculator.Realize.CalcDouble;
using Calculator.Realize.CalcInt;
using Calculator.Realize.CalcString;
using Calculator.Realize.CommandsList;
using Ninject.Modules;

namespace Calculator.Realize.NinjecInitial
{
    public class ControlVersion : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ICommandList>().To<CommandList>();
        }
    }
}
