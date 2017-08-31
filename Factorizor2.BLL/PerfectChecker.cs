using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor2.BLL
{
    public static class PerfectChecker
    {
        public static bool IsItPerfect(int[] factors)
        {
            bool _result = false;
            int intPerfect = 0;

            for (int i = 0; i < factors.Length - 1; i++)
            {
                intPerfect += factors[i];
                
            }

            if (intPerfect == factors[factors.Length - 1])
                           _result = true;
            
            return _result;
        }
    }
}
