using System.Runtime.CompilerServices;

namespace Task.Extensions
{
    internal static class ExtensionMethods
    {
        public static bool IsOdd(this int number)
        {
            return (number % 2 != 0);
        }
        public static bool IsEven(this int number)
        {
            return (number % 2 == 0);
        }
        public static bool IsContainsDigit(this string str)
        {
            
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {   
                    return true;
                }

            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            if (str == null || String.IsNullOrWhiteSpace(str)) return str;
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
        public static int[] GetValueIndexes(this string str, char ch)
        {

            int count = 0;
            for (int i = 0; i<str.Length; i++)
            {
                if (str[i] == ch) { count++; }
            }
            int[] indexes = new int[count];
            int index = 0;
            if (count > 0)
            {
                for(int i = 0; i < str.Length; i++)
                {
                    if (str[i]==ch)indexes[index++] = i;
                }
            }
            return indexes;
        }

        public static string GetFirstSentence(this string str)
        {

            static int GetIndexOfDot(string s)
            {
                for (int i = 0;i<s.Length;i++) if (s[i] == '.' || s[i]=='?' || s[i]=='!') { return i; }
                return -1;
            }
            int index=GetIndexOfDot(str);
            if (index == -1) { return str; }
            return str.Substring(0,index);//str.Substring(0,index+1)
        }

        public static string GetSecondWord(this string str)
        {
            string[] words = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length>1) return words[1];
            else return "There is no 2nd word";



        }



    }
}
