﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
    public static class MyExtension
    {
        /// <summary>
        /// Mehod that return sum of  'n' digit
        /// </summary>        
        /// <param name="n">Element parameter</param>
        /// <returns>Integer value</returns>
        public static int SummaDigit(this int n)
        {
            int sum = 0;

            n = Math.Abs(n);
            while (n > 9)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum + n;
        }

        /// <summary>
        /// Method that return sum of 'n' element and reverse of 'n'
        /// </summary>
        /// <param name="n">Element parameter</param>
        /// <returns>Ulong value</returns>
        public static ulong SummaWithReverse(this uint n)
        {
            uint temp = n;
            StringBuilder sb = new StringBuilder();

            while (n > 9)
            {
                sb.Append(n % 10);
                n /= 10;
            }
            sb.Append(n);
            return temp + Convert.ToUInt32(sb.ToString());

        }

        /// <summary>
        /// Method that count amount of elements in string , which are not letters of the latin alphabet.
        /// </summary>
        /// <param name="str">String parameter</param>
        /// <returns>Integer value</returns>
        public static int CountNotLetter(this string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(!((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')))
                        count++;
            }
            return count;
        }

        /// <summary>
        /// Method that checks whether day is weekend or not 
        /// </summary>
        /// <param name="day">DayOfWeek parameter</param>
        /// <returns>Bool value</returns>
        public static bool IsDayOff(this DayOfWeek day)
        {

            if (day == DayOfWeek.Sunday || day == DayOfWeek.Saturday)
                return true;
            return false;
        }


        /// <summary>
        /// Method that return positive ,even  element from collection 
        /// </summary>
        /// <param name="numbers">Collection of elements</param>
        /// <returns>IEnumerable -int collection  </returns>
        public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> numbers)
        {
            List<int> positiveEvenNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num > 0 && num % 2 == 0)
                    positiveEvenNumbers.Add(num);
            }
            return positiveEvenNumbers;

        }
    }
}
