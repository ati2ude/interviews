using System;

namespace RD.Common.Extensions
{
    public class Extension
    {
        public static bool IsNumeric(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
