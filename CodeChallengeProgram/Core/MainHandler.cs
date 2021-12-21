using CodeChallengeProgram.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallengeProgram.Core
{
    public class MainHandler
    {
        public IFizzBizzHandler _fbhandler;
        public IFactorialHandler _fahandler;
        public int maxvalue = 100;
        public string methodname;

        public MainHandler(IFizzBizzHandler fbhandler, IFactorialHandler fahandler)
        {
            this._fbhandler = fbhandler;
            this._fahandler = fahandler;
        }

        public void Run()
        {
            try
            {
                Console.WriteLine("Welcome ! Type  FizzBizz  for fb , Type Factorial for fa ");

                methodname = Console.ReadLine();

                if (methodname == "fb")
                {
                    _fbhandler.FizzBizzPrint(maxvalue);
                }
                else if (methodname == "fa")
                {
                    Console.WriteLine("Please Enter Any number");
                    Console.WriteLine(_fahandler.FactorialPrint(Convert.ToInt32(Console.ReadLine())));
                }
                else
                {
                    Console.WriteLine("please type properly  : Type  FizzBizz  for fb , Type Factorial for fa ");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
