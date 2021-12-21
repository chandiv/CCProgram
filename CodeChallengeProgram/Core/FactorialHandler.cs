using CodeChallengeProgram.Contract;

namespace CodeChallengeProgram.Core
{
    public class FactorialHandler : IFactorialHandler
    {
        public int factorialvalue = 1;
        public string FactorialPrint(int number)
        {
            for (int f = 1; f <= number; f++)
                factorialvalue = factorialvalue * f;

            return $"Factorial { number } is { factorialvalue }";
        }
    }
}
