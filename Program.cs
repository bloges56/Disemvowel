using System;
using System.Linq;

namespace Disemvowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Disemvowel(string str)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for(int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                   str = str.Remove(i, 1);
                   i--;
                }
            }
            return str;
        }
    }
}

