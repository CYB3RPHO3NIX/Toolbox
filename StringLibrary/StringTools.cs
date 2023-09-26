using System.Text.RegularExpressions;

namespace StringLibrary
{
    public static class StringTools
    {
        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Method to count the occurrences of a substring in a string
        public static int CountSubstringOccurrences(string input, string substring)
        {
            int count = 0;
            int index = input.IndexOf(substring);
            while (index != -1)
            {
                count++;
                index = input.IndexOf(substring, index + 1);
            }
            return count;
        }

        // Method to truncate a string to a specified length
        public static string Truncate(string input, int maxLength)
        {
            if (input.Length <= maxLength)
                return input;
            return input.Substring(0, maxLength);
        }

        // Method to convert a string to title case
        public static string ToTitleCase(string input)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}