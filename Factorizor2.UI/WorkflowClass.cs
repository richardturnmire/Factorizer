using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor2.BLL;


namespace Factorizor2.UI
{
    public class WorkflowClass
    {
        public void Start()
        {
            FactorFinder ff = new FactorFinder();
            int num = InputClass.GetIntFromUser("Enter number to process");
            int[] factors = ff.GetFactors(num);
            OutputClass.SentToConsole($"\nThe factors of {num} are as follows:\n");
            for (int i = 0; i < factors.Length; i++)
            {
                OutputClass.SentToConsole($"{factors[i]}");
            }

            if (PerfectChecker.IsItPerfect(factors))

                OutputClass.SentToConsole($"\n{num} is a perfect number!");
            else
                OutputClass.SentToConsole($"\n{num} is NOT a perfect number!");


            if (PrimeChecker.IsItPrime(factors))
                OutputClass.SentToConsole($"\n{num} is a prime number!");
            else
                OutputClass.SentToConsole($"\n{num} is NOT a prime number!");

            OutputClass.SentToConsole("\nPress any key to end.");
            Console.ReadKey();

        }
    }
}
