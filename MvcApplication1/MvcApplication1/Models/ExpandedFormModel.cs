using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ExpandedFormModel
    {
        private List<int> _digits = new List<int>();

        public ExpandedFormModel()
        {
            System.Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {
                _digits.Add(random.Next(101, 9999));
            }
        }

        public List<int> Digits
        {
            get
            {
                return _digits;
            }
        }

        public List<string> NumberInEnglishForm
        {
            get
            {
                List<string> numberInEnglish = new List<string>();
                for (int i = 0; i <= _digits.Count() - 1; i++)
                {
                    numberInEnglish.Add(ConvertDigitToEnglishForm(_digits[i]));
                }

                return numberInEnglish;
            }
        }

        private string ConvertDigitToEnglishForm(int num)
        {
            string tempString = "";
            int thousands;
            int temp;
            string result = "";
            if (num < 0 || num > 100000)
            {
                System.Console.WriteLine(num + " \tNot Supported");
                return string.Empty;
            }

            if (num == 0)
            {
                System.Console.WriteLine(num + " \tZero");
                return string.Empty;
            }

            if (num < 1000)
            {
                HelperConvertNumberToText(num, out tempString);
                result += tempString;
            }
            else
            {
                thousands = num / 1000;
                temp = num - thousands * 1000;
                HelperConvertNumberToText(thousands, out tempString);
                result += tempString;
                result += "Thousand ";
                HelperConvertNumberToText(temp, out tempString);
                result += tempString;
            }
            return result;
        }

        private bool HelperConvertNumberToText(int num, out string buf)
        {
            string[] strones = {
            "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
            "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",
          };

            string[] strtens = {
              "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty",
              "Seventy", "Eighty", "Ninety", "Hundred"
          };

            string result = "";
            buf = "";
            int single, tens, hundreds;

            if (num > 1000)
                return false;

            hundreds = num / 100;
            num = num - hundreds * 100;
            if (num < 20)
            {
                tens = 0; // special case
                single = num;
            }
            else
            {
                tens = num / 10;
                num = num - tens * 10;
                single = num;
            }

            result = "";

            if (hundreds > 0)
            {
                result += strones[hundreds - 1];
                result += " Hundred ";
            }
            if (tens > 0)
            {
                result += strtens[tens - 1];
                result += " ";
            }
            if (single > 0)
            {
                result += strones[single - 1];
                result += " ";
            }

            buf = result;
            return true;
        }
    }
}