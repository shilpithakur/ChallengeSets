using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //if (char.IsLetter(c))
            //{
            //    return true;
            //}
            //else
            //    return false;

            return (char.IsLetter(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //if ((vals.Length) % 2 == 0) { return true; }
            // else { return false; }
            return ((vals.Length) % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return !(num % 2 == 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();
            if (numbers != null && numbers.Count() != 0)
            {
                return numbers.Min() + numbers.Max();
            }
            else return 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
            
        }


        public int Sum(int[] numbers)
        {
            if (numbers != null)
            {
                int temp = 0;
                foreach (int num in numbers)
                {
                    temp += num;

                }
                return temp;
            }
            else return 0;
        }
       


        public int SumEvens(int[] numbers)
        {
            //if (numbers != null)

            //{
            //    int temp = 0;

            //    foreach (int num in numbers)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            temp += num;
            //        }
            //    }
            //    return temp;

            //}
            //else return 0;

            return numbers == null ? 0 : numbers.Where(x => x % 2 == 0).Sum();
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null)
            {
                int temp = 0;

                foreach (int num in numbers)
                {
                    temp +=num;
                }
                return temp % 2 != 0;
                
            }
            else return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number > 0) ? number / 2 : 0;
        }
    }
}
