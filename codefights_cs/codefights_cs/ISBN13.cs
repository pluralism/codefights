using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class ISBN13
    {
        public string[] isbn13(string number)
        {
            number = string.Join("", number.Where(char.IsDigit));
            if (number.Length == 10) number = number.Substring(0, 9);
            number = number.Insert(1, "-").Insert(5, "-");
            string modified = number.Replace("-", ""), isbn10, isbn13;
            int current = 10, sum = 0, factor = 1;

            for(int i = 0; i < modified.Length; i++)
                sum += (int)Char.GetNumericValue(modified[i]) * current--;

            isbn10 = number + "-" + (11 - (sum % 11)) % 11;
            isbn13 = "978-" + number;
            modified = isbn13.Replace("-", "");
            sum = 0;
            for(int i = 0; i < modified.Length; i++)
            {
                sum += factor * (int)Char.GetNumericValue(modified[i]);
                factor = factor == 1 ? 3 : 1;
            }
            isbn13 = isbn13 + "-" + ((10 - sum % 10) < 10 ? (10 - sum % 10) : 0);
            return new[] { "ISBN-10: " + isbn10,
                "ISBN-13: " + isbn13 };
        }

    }
}
