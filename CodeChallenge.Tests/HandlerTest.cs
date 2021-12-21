using CodeChallengeProgram.Core;
using Xunit;

namespace CodeChallenge.Tests
{
    public class HandlerTest
    {
        FizzBizzHandler fizzbizzhandler = new FizzBizzHandler();
        FactorialHandler factorialhandler = new FactorialHandler();

        [Fact]
        public void FizzBizzPrintWithProperIntputValue()
        {
            int inputfactorialvalue = 10;           
            var result = fizzbizzhandler.FizzBizzPrint(inputfactorialvalue);
            Assert.True(result);
        }


        [Fact]
        public void FactorialWithProperIntputValue()
        {
            int inputfactorialvalue = 6;           
            var result = factorialhandler.FactorialPrint(inputfactorialvalue);
            Assert.Equal("Factorial 6 is 720", result);

        }

        [Fact]
        public void FactorialWithProperNotOutputValue()
        {
            int inputfactorialvalue = 6;
            var result = factorialhandler.FactorialPrint(inputfactorialvalue);
            Assert.NotEqual("Factorial 6 is 750", result);

        }
    }
}
