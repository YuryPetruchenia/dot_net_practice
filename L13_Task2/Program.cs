using System;

namespace L13_Task2
{
    class Program
    {
        static class StringExtensions
        {
            public static void Cut (this String str, int lenght)
            {
                str = str.Substring(0, str.Length - lenght);
            }
        }
        static void Main(string[] args)
        {
            string str = "djbdksjagbuibga";
            Cut(str, 5);
        }
    }
}
