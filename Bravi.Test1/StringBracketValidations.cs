using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravi.Test1
{
    public static class StringBracketValidations
    {
        private readonly static Dictionary<char, char> bracketPairs = new Dictionary<char, char>() { { '(', ')' }, { '{', '}' }, { '[', ']' } };

        /// <summary>
        /// Extension method created for checking if bracket expressions such as "{}[]()" are valid or not.
        /// </summary>
        /// <returns>
        /// True when all opening and closing brackets are present and in the correct order, false otherwise.
        /// </returns>
        public static bool IsValidBracketExpression(this String input)
        {
            Stack<char> openBracketStack = new Stack<char>();

            try
            {
                foreach (char character in input)
                {
                    if (bracketPairs.Keys.Contains(character))
                        openBracketStack.Push(character);
                    else if (bracketPairs.Values.Contains(character))
                        if (character == bracketPairs[openBracketStack.First()]) // throws InvalidOperationException when opening bracket is not found.
                            openBracketStack.Pop();
                        else
                            return false;
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }

            return !openBracketStack.Any();
        }
    }
}
