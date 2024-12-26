using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTesting
{
    public class TestingMethods
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public bool PosOrNeg(int a)
        {
            bool PNResult = a < 0 ? false : true;
            return PNResult;
        }

        public int SumOfNatNum(int a)
        {
            int sum = a*(a + 1) / 2;
            return sum;
        }
    }
}
