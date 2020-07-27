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
        [Test]
        public void RomanNumeralsConverterTest()
        {
            Assert.AreEqual(0, RomanNumeralsConverter(""));
            Assert.AreEqual(1,RomanNumeralsConverter("I"));
            Assert.AreEqual(2, RomanNumeralsConverter("II"));
            Assert.AreEqual(3, RomanNumeralsConverter("III"));
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
