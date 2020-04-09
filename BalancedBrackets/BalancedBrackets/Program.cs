using System;

/// <summary>
/// Balanced brackets' namespace.
/// </summary>
namespace BalancedBrackets
{
    /// <summary>
    /// Program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string: ");

            string charString = Console.ReadLine();

            Console.WriteLine(BalancedBrackets(charString).ToString());
        }

        /// <summary>
        /// Validates if the string has balanced brackets.
        /// </summary>
        /// <param name="charString">String to validate.</param>
        /// <returns>True if the string has balanced brackets, false if not.</returns>
        public static bool BalancedBrackets(string charString)
        {
            int openBraces = 0;
            int closeBraces = 0;
            int openParens = 0;
            int closeParens = 0;
            int openBrackets = 0;
            int closeBrackets = 0;

            foreach (char c in charString)
            {
                switch (c)
                {
                    case '(':
                        openParens++;
                        break;
                    case ')':
                        closeParens++;
                        break;
                    case '{':
                        openBraces++;
                        break;
                    case '}':
                        closeBraces++;
                        break;
                    case '[':
                        openBrackets++;
                        break;
                    case ']':
                        closeBrackets++;
                        break;
                }
            }

            if (openParens == closeParens && openBraces == closeBraces && openBrackets == closeBrackets)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}