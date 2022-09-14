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
                string Reversed = "";
                
                while(a >= 0)
                {
                    Reversed += stringInput[a];
                    a--;
                }

                if (isNegative)
                {
                    Reversed = "-" + Reversed;
                }

                var answer = int.Parse(Reversed);
                if(answer > int.MaxValue)
                {
                    return 0;
                }
                return answer;
            }

            int input = -2147;
            Console.WriteLine(ReverseInt(input));
        }
    }
}
