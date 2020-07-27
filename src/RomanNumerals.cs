using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata.src
{
    public class RomanNumerals
    {
        private Dictionary<char, int> romanDictionary = new Dictionary<char, int>()
        {
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50 },
            {'C',100},
            {'D',500},
            {'M',1000},
        };

        public int ConvertToArabic(string roman)
        {
            int result = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (IsNotLastNumeral(roman, i) && IsNextNumeralBigger(roman, i))
                    result -= romanDictionary[roman[i]];
                else
                    result += romanDictionary[roman[i]];
            }

            return result;
        }

        private bool IsNextNumeralBigger(string roman, int i)
        {
            return romanDictionary[roman[i + 1]] > romanDictionary[roman[i]];
        }

        private bool IsNotLastNumeral(string romanNumeral, int i)
        {
            return i + 1 < romanNumeral.Length;
        }
    }
}
