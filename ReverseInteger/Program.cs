using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int ReverseInt(int x)
            {
                bool isNegative = false;
                string stringInput = x.ToString();

                if (stringInput[0] == '-')
                {
                    stringInput = stringInput.Substring(1, stringInput.Length - 1);
                    isNegative = true;
                }

                int a = stringInput.Length - 1;
                string Reverse = "";
                
                while(a >= 0)
                {
                    Reverse = Reverse + stringInput[a];
                    a--;
                }

                if (isNegative)
                {
                    stringInput = "-" + stringInput;
                }

                int answer = int.Parse(stringInput);
                return answer;
            }
            int input = -321;
            Console.WriteLine(ReverseInt(input));
        }
    }
}
