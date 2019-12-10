using System.Collections.Generic;
using System.Linq;

namespace DataCalculation
{
    public class DataAnalysis
    {
        List<Data> info;
        public DataAnalysis(List<Data> data)
        {
            info = data;
        }

        public string Analysis()
        {
            double maxIncome = info.Max(i => i.income);
            int indMaxIncome = info.FindIndex(i => i.income == maxIncome);
            double maxOutlay = info.Max(i => i.outlay);
            int indMaxOutlay = info.FindIndex(i=>i.outlay==maxOutlay);
            return $"{info[0].userName} spent {maxOutlay} on the {info[indMaxOutlay].source} " +
                $"\nand earned {maxIncome} of the {info[indMaxIncome].source}";
        }
    }
}
