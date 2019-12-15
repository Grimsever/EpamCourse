using System.Collections.Generic;

namespace DataCalculation
{
    public class FormationOutputData
    {
        List<Data> data;
        DataAnalysis dataAnalysis;
        public FormationOutputData(List<Data> data)
        {
            this.data = data;
            dataAnalysis = new DataAnalysis(data);
        }
        public string GetTable()
        {
            string tableHeader = string.Format("Name    |Budget  |   Source/Purpose   |Outlay  |Income  |Income tax|Actual  |\n");
            string table= tableHeader;
            table += new string('-', tableHeader.Length - 1);

            for (int i = 0; i < data.Count; i++)
            {
                table += string.Format($"\n{data[i].userName,-8}|{data[i].budget,-8}|{data[i].source,-20}|{data[i].outlay,-8}|{data[i].income,-8}|{data[i].IncomeTax,-10}|{data[i].actualBudget,-8}|\n");
                table += new string('-', tableHeader.Length - 1);
            }

            return table;
        }
        public string GetAnalysis()
        {
            return dataAnalysis.Analysis();
        }

    }
}
