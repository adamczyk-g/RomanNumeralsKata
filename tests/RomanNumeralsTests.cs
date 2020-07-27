// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using RomanNumeralsKata.src;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase("", 0)]

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]

        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("XX", 20)]
        [TestCase("XXX", 30)]

        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]
        [TestCase("XIV", 14)]
        [TestCase("XIX", 19)]
        [TestCase("MCM", 1900)]

        [TestCase("MCMXXXIX", 1939)]
        [TestCase("MMXX", 2020)]
        [TestCase("MCDX", 1410)]
        [TestCase("MCDXCIX", 1499)]
        [TestCase("MCMLXXXIX", 1989)]

        public void RomanToArabicConverterTest(string romanNumeral, int expectedNumber)
        {
            Assert.AreEqual(expectedNumber, new RomanNumerals().ConvertToArabic(romanNumeral));
        }        
        
    }
}
