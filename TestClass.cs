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
            Assert.AreEqual(1,RomanNumeralsConverter("I"));
            Assert.AreEqual(0, RomanNumeralsConverter(""));
        }

        private double RomanNumeralsConverter(string romanNumeral)
        {
            if (romanNumeral == "") return 0;
            return 1;
        }
    }
}
