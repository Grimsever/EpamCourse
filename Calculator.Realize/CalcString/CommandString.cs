using Calculator.Model;

namespace Calculator.Realize.CalcString
{
    public class CommandString:ICommands
    {
        public object Addition(object num1, object num2)
        {
            return (string)num1 + (string)num2;
        }

        public object Division(object num1, object num2)
        {
            string str1 = (string)num1;
            string str2 = (string)num2;
            int newLength = str1.Length / str2.Length;
            string comStr = str1 + str2;
            string newStr = "";
            for (int i = 0; i < newLength; i++)
            {
                newStr += comStr[i];
            }
            return newStr;
        }

        public object Multiplication(object num1, object num2)
        {

            string newStr = "";
            for (int i = 0; i < ((string)num1).Length; i++)
            {
                for (int j = 0; j < ((string)num2).Length; j++)
                {
                    newStr += ((string)num2)[j];
                }
            }
            return newStr;
        }

        public object Subtraction(object num1, object num2)
        {
            string newStr = "";
            string str1 = (string)num1;
            string str2 = (string)num2;
            if (str1.Length > str2.Length)
            {
                int newLength = str1.Length - str2.Length;
                for (int i = 0; i < newLength; i++)
                {
                    newStr += str1[i];
                }
            }
            else if (str1.Length < str2.Length)
            {
                int newLength = str2.Length - str1.Length;
                for (int i = newLength - 1; i >= 0; i--)
                {
                    newStr += str2[i];
                }
            }
            return newStr;
        }


    }
}
