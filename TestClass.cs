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
        }

        private double RomanNumeralsConverter(string romanNumeral)
        {
            return 1;
        }
    }
}
