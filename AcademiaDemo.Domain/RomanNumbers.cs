namespace AcademiaDemo.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RomanNumbers
    {
        private Dictionary<int, string> numbers = new Dictionary<int, string>
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" },
        };
        public string Convert(int number)
        {
            if (number < 0 || number > 4000)
            {
                throw new Exception("Number must be between 0 and 4000");
            }
            var retVal = new StringBuilder(5);
            foreach (var n in numbers.Reverse()) // Começa nos números maiores para efetuar a subtração
            {
                while (number >= n.Key) // Quando o numero for maior que uma key ou seja 14 > 10
                {
                    number -= n.Key; // subtrai 10 (key) ao numero e fica com 4
                    retVal.Append(n.Value); // vai adicionar 10 (X) a string final
                }
            }
            return retVal.ToString();
        }
    }
}
