﻿using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
