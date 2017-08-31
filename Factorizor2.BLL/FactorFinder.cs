using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor2.BLL
{
    public  class FactorFinder
    {
        public  int[] GetFactors(int num)
        {
            int[] _factors = new int[200]; 
            int _numFactors = 1;
            _factors[0] = 1;

            // var boundary = (int)Math.Floor(Math.Sqrt(num));
            var boundary = (int)num / 2;

            for (int i = 2; i <= boundary; i++)
            {
                if (num % i == 0)
                {
                    _factors[_numFactors] = i;
                    _numFactors++;
                }
            }
            _factors[_numFactors] = num;
            int[] _results = new int[_numFactors + 1];
            for (int i = 0; i < _numFactors + 1; i++)
            {
                _results[i] = _factors[i];
            }
            return _results;
        }
    }
}
