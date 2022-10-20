using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            string result = "";
            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 0; j <= str1.Length - i; j++)
                {
                    if(str2.Contains(str1.Substring(j, i)))
                    {
                        result = str1.Substring(j, i);
                    }
                }
            }
            return result;
        }
    }
}
