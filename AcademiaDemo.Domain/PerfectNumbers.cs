namespace AcademiaDemo.Domain
{
    using System;

    public class PerfectNumbers
    {
        public bool IsPerfectNumber(int number)
        {
            if (number < 0 || number > 10000)
            {
                throw new Exception("Number must be between 0 and 10000");
            }

            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                return true;
            }
            return false;
        }
    }
}
