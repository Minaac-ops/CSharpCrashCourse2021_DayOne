﻿using System;

namespace CrashCourse2021ExercisesDayOne.Utils
{
    internal class StringUtil
    {
        internal int LengthOfString(string stringToMeasure)
        {
            if (stringToMeasure == null)
            {
                throw new NullReferenceException(Constants.StringCannotBeNull);
            }
            return stringToMeasure.Length;
        }

        internal string SumStrings(string value1, string value2)
        {
            int result = int.Parse(value1) + int.Parse(value2);
            return result.ToString();
        }

        internal string DivideString(string value1, string value2)
        {
            int result = int.Parse(value1) / int.Parse(value2);
            return result.ToString();
        }

        internal string StringContains(string value1, string value2)
        {
            if (value1.Contains(value2))
            {
                return "YES";
            }
            else return "NO";
        }

        internal string StringToUpperCase(string value1)
        {
            return value1.ToUpper();
        }

        internal string AdditionFromPlusString(string inputString)
        {
            string[] numbers = inputString.Split("+");
            var finalNumber = 0;
            
            foreach (var numberInString in numbers)
            {
                var number = int.Parse(numberInString);
                finalNumber += number;
            }
            return finalNumber.ToString();
        }

        internal string EvenNumber(int numbertoTest)
        {
            if (numbertoTest % 2 == 0)
            {
                return "EVEN";
            }
            return "ODD";
        }
    }
}