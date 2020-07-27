// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase("",0)]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        public void RomanNumeralsConverterTest(string expected, int arabicNumber)
        {
            Assert.AreEqual(arabicNumber, RomanNumeralsConverter(""));
        }

        private double RomanNumeralsConverter(string romanNumeral)
        {   
            if (romanNumeral == "I") return 1;
            if (romanNumeral == "II") return 2;
            if (romanNumeral == "III") return 3;
            return 0;
        }
    }
}
