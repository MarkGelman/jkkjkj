using System;

namespace HW_StartWith_EndWith_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();

            bool found = fStartWith(str1, str2);

            Console.WriteLine(found);

            bool found1 = fEndWith(str1, str2);


        }

        public static bool fStartWith (string str1, string str2)
        {
            for (int indexStr = 0; indexStr<str2.Length; indexStr++)
            {
                if  (str1[indexStr] != str2[indexStr])          
                        return false;
            }
            return true;
        }

        public static bool fEndtWith(string str1, string str2)
        {
            int indexStr = str1.Length;

            for (int len = str2.Length; len > 0; len--)
            {
                if (str1[indexStr] != str2[len])
                    return false;
                indexStr++;
            }
            return true;
        }
    }
}
