using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleClassLibrary
{
    public static class StringUtilities
    {
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            var reversed = new string(input.Reverse().ToArray());
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
        }

        public static string ToCamelCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            return char.ToLower(input[0]) + input.Substring(1);
        }
    }
}
