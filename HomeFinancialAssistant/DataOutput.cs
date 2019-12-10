using DataCalculation;
using System.Collections.Generic;

namespace HomeFinancialAssistant
{
    public class DataOutput
    {
        List<Data> data;
        FormationOutputData outputData;
        public DataOutput(List<Data> data)
        {
            this.data = data;
            outputData = new FormationOutputData(data);
        }
        public string OutputTable()
        {
            return outputData.GetTable();
        }
        public string GetInfoByMoney() 
        {
            return outputData.GetAnalysis();
        }
        
    }
}
