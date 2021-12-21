using CodeChallengeProgram.Contract;
using System;

namespace CodeChallengeProgram.Core
{
    public class FizzBizzHandler : IFizzBizzHandler
    {
        public bool FizzBizzPrint(int maxvalue)
        {
            try
            {
                for (int minvalue = 1; minvalue <= maxvalue; minvalue++)
                {
                    if (minvalue % 3 == 0 && minvalue % 5 == 0)
                        Console.WriteLine("FizzBizz");
                    else if (minvalue % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (minvalue % 5 == 0)
                        Console.WriteLine("Bizz");
                    else
                        Console.WriteLine(minvalue);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
