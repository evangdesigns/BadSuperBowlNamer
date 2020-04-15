using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamer
{
    public class Translator
    {
        public string Translate(int number)
        {
            var romanNumeral = "";

            while (number > 0)
            {
                if (number >= 10)
                {
                    romanNumeral += "X";
                    number -= 10;
                }
                else if (number == 9)
                {
                    romanNumeral += "IX";
                    number -= 9;
                }
                else if (number >= 5)
                {
                    romanNumeral += "V";
                    number -= 5;
                }
                else if (number == 4)
                {
                    romanNumeral += "IV";
                    number -= 4;
                }
                else if (number >= 1)
                {
                    romanNumeral += "I";
                    number -= 1;
                }
            }
            
            return romanNumeral;
        }
    }
}
