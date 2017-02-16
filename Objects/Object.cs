using System;
using System.Collections.Generic;

namespace NumbersToWords.Objects
{
    public class Numbers
    {
        private string _number;
        private char[] _digitArray;
        private string _result;
        public static Dictionary<char,string> singleDigit = new Dictionary<char,string>()
        {
            {'0', ""},
            {'1', "one"},
            {'2', "two"},
            {'3', "three"},
            {'4', "four"},
            {'5', "five"},
            {'6', "six"},
            {'7', "seven"},
            {'8', "eight"},
            {'9', "nine"},
        };
        public static Dictionary<char,string> teens = new Dictionary<char,string>()
        {
            {'0', "ten"},
            {'1', "eleven"},
            {'2', "twelve"},
            {'3', "thirteen"},
            {'4', "fourteen"},
            {'5', "fifteen"},
            {'6', "sixteen"},
            {'7', "seventeen"},
            {'8', "eightteen"},
            {'9', "nineteen"},
        };

        public Numbers(string userNumber)
        {
            _number = userNumber;
            _digitArray = userNumber.ToCharArray();
            _result = "";
        }
        public string Convert()
        {
            foreach (KeyValuePair<char,string> pair in singleDigit)
            {
                if (pair.Key == _digitArray[_digitArray.Length -1])
                {
                    _result += pair.Value;
                }
            }
            foreach (KeyValuePair<char,string> pair in teens)
            {
                if (pair.Key == _digitArray[_digitArray.Length -1] && _digitArray[_digitArray.Length -2] == '1')
                {
                    _result += pair.Value;
                }
            }
            return _result;
        }
    }
}
