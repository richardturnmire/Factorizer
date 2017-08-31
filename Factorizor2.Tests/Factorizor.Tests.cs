using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor2.BLL;
using NUnit.Framework;

namespace Factorizor2.Tests
{
    [TestFixture]
    public class FactorizorTests
    {
        [TestCase(2, new int[] { 1, 2 })]
        [TestCase(6, new int[] { 1, 2, 3, 6 })]
        [TestCase(11, new int[] { 1, 11 })]
        public void FactorFinderTest(int x, int[] expected)
        {
            FactorFinder ff = new FactorFinder();
            int[] actual = ff.GetFactors(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 6 }, true)]
        [TestCase(new int[] { 1, 7 }, false)]
        [TestCase(new int[] { 1, 2, 5, 10 }, false)]
        public void PerfectCheckerTest(int[] x, bool expected)
        {

            bool actual = PerfectChecker.IsItPerfect(x);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 6 }, false)]
        [TestCase(new int[] { 1, 7 }, true)]
        [TestCase(new int[] { 1, 2, 5, 10 }, false)]
        public void PrimeCheckerTest(int[] x, bool expected)
        {

            bool actual = PrimeChecker.IsItPrime(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
