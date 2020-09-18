using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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



        public static bool IsValidName(string input)
        {
            if (!(Regex.IsMatch(input, @"[a-zA-Z]+$"))){
                return false;
            }
            return true;
        }

        public static bool IsEmpty(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
