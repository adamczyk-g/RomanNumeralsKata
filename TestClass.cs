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
        [TestCase("", 0)]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("M", 1000)]

        public void RomanNumeralsConverterTest(string romanNumeral, int expectedNumber)
        {
            Assert.AreEqual(expectedNumber, RomanNumeralsConverter(romanNumeral));
        }

        Dictionary<char, int> romanNumeralsDictionary = new Dictionary<char, int>()
        {
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50 },
            {'C',100},
            {'M',1000},
        };

        private double RomanNumeralsConverter(string romanNumeral)
        {   
            if (romanNumeral == "I") return 1;
            if (romanNumeral == "II") return 2;
            if (romanNumeral == "III") return 3;

            int result = 0;

            for (int i = 0; i < romanNumeral.Length; i++)
            {
                result += romanNumeralsDictionary[romanNumeral[i]];
            }

            return result;
        }
    }
}
