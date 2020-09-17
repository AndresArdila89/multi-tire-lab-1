using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Lab1_ConnectedMode2.VALIDATION
{
    public static class Validator
    {
        public static bool IsValidId(string input)
        {
            if (!(Regex.IsMatch(input, @"^\d{4}$")))
            {
                return false;
            }
            return true;
        }
    }
}
