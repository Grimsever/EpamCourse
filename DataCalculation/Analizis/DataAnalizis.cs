using DataCalculation.Model;
using DataCalculation.ValidationInput;
using System.Linq;

namespace DataCalculation.Analizis
{
    public class DataAnalizis : IAnalizisOfData<string>
    {
        public IUserData UserData { get; set; }
        public IValidation<double> Validation { get; set; }

        public DataAnalizis(IUserData dataUser, IValidation<double> validation)
        {
            UserData = dataUser;
            Validation = validation;

        }

        public string GetInfoOfSpentMaxMoney()
        {
            if (Validation.ValidationForAnalizis(UserData))
            {
                var max = UserData.Datas.FindIndex(i => i.Outlay == UserData.Datas.Max(j => j.Outlay));
                return $"You spent the most {UserData.Datas[max].Outlay} on the {UserData.Datas[max].Source}";
            }
            else
            {
                return "No records, Error. Add new records about your expenses";
            }
        }

        public string GetInfoOfSpentMinMoney()
        {
            if (Validation.ValidationForAnalizis(UserData))
            {
                int min = UserData.Datas.FindIndex(i => i.Outlay == UserData.Datas.Min(j => j.Outlay));
                return $"You spent the laest {UserData.Datas[min].Outlay} on the {UserData.Datas[min].Source}";
            }
            else
            {
                return "No records, Error. Add new records about your expenses";
            }
        }
        public string GetInfoOfMaxIncome()
        {
            if (Validation.ValidationForAnalizis(UserData))
            {
                var max = UserData.Datas.FindIndex(i => i.Income == UserData.Datas.Max(j => j.Income));
                return $"You got the most {UserData.Datas[max].Income} out of a {UserData.Datas[max].Source}";
            }
            else
            {
                return "No records, Error. Add new records about your income";
            }
        }

        public string GetInfoOfMinIncome()
        {
            if (Validation.ValidationForAnalizis(UserData))
            {
                int min = UserData.Datas.FindIndex(i => i.Income == UserData.Datas.Max(j => j.Income));
                return $"You got the laest {UserData.Datas[min].Income}  out of a {UserData.Datas[min].Source}";
            }
            else
            {
                return "No records, Error. Add new records about your income";
            }
        }

        public string GetInfoTable()
        {
            if (Validation.ValidationForAnalizis(UserData))
            {
                string mainHeader = $"{UserData.UserName} your initial budget was {UserData.InitailBudget}\n";
                string tableHeader = string.Format("\nSource/Purpose   |Outlay  |Income  |Income tax|Actual  |\n");
                string table = tableHeader;
                table += new string('-', tableHeader.Length - 1);

                for (int i = 0; i < UserData.Datas.Count; i++)
                {
                    table += string.Format($"\n{ UserData.Datas[i].Source,-17}|{ UserData.Datas[i].Outlay,-8}|{ UserData.Datas[i].Income,-8}|{UserData.Datas[i].IncomeTax,-10}|{ UserData.Datas[i].ActualBudget,-8}|\n");
                    table += new string('-', tableHeader.Length - 1);
                }

                return table;
            }
            else
            {
                return "No information";
            }
        }

    }
}
