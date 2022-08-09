using System.Linq;

namespace Algorithms
{
    public static class StringManipulation
    {
        /// <summary>
        /// Call this to get the string between
        /// </summary>
        /// <param name="strSource">Source String</param>
        /// <param name="strStart">Where to Start looking</param>
        /// <param name="strEnd">Where to Stop looking</param>
        /// <returns>The cream between if unsucessful returns given string</returns>
        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start).Trim();
            }

            return strSource;
        }

        /// <summary>
        /// Call this to remove duplicate words within a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns>string with duplicate words removed</returns>
        public static string RemoveDuplicates(string text)
        {
            return string.Join(" ", text.Split(' ').Distinct());
        }
    }
}