using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaDemo.Domain
{
    public class Factorial
    {
        public int CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new Exception("Number can't be negative");
            }
            if (number > 30)
            {
                throw new Exception("Number can't be bigger than 30");
            }
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
