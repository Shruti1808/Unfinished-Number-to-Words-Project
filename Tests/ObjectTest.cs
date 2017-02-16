using Xunit;
using NumbersToWords.Objects;
using System;
using System.Collections.Generic;

namespace NumbersToWordsTest
{
    public class ConversionTest
    {
        [Fact]
        public void changeSingleDigit_singleDigitConversion_one()
        {
            //arrange
            string number = "1";
            string expectedResult = "one";
            Numbers newNumbers= new Numbers(number);
            //act
            string result = newNumbers.Convert();
            //assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void changeteensDigit_teensConversion_twelve()
        {
            //arrange
            string number = "12";
            string expectedResult = "twelve";
            Numbers newNumbers= new Numbers(number);
            //act
            string result1 = newNumbers.Convert();
            Console.WriteLine(result1);
            //assert
            Assert.Equal(expectedResult, result1);
        }
    }
}
