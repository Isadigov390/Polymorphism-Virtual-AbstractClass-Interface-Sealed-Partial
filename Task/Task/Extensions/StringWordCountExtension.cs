using System.Text.RegularExpressions;

namespace Task.Extensions
{
    internal static class StringWordCountExtension
    {   
        public static int MatchCount(this string sentence,string word)
        {
            string[] words = Regex.Split(sentence, @"\W|_");
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                //Console.WriteLine(words[i]);
                if (words[i] == word) count++;
            }

            return count;
        }
    }
}

#warning git push;