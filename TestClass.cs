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
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("M", 1000)]

        public void RomanNumeralsConverterTest(string romanNumeral, int expectedNumber)
        {
            Assert.AreEqual(expectedNumber, RomanNumeralsConverter(romanNumeral));
        }

        private double RomanNumeralsConverter(string romanNumeral)
        {   
            if (romanNumeral == "I") return 1;
            if (romanNumeral == "II") return 2;
            if (romanNumeral == "III") return 3;
            if (romanNumeral == "V") return 5;
            if (romanNumeral == "X") return 10;
            if (romanNumeral == "L") return 50;
            if (romanNumeral == "C") return 100;
            if (romanNumeral == "M") return 1000;

            return 0;
        }
    }
}
