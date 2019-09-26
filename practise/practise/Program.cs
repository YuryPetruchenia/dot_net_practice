using System;

namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {
            System.TimeSpan str = DateTime.Now.TimeOfDay;
            int hours = str.Hours;
            if (hours >= 9 && hours < 12)
                Console.WriteLine("Good morning, gyes");
            if (hours >= 12 && hours <15)
                Console.WriteLine("Good day, gyes");
            if (hours >= 15 && hours < 22)
                Console.WriteLine("Good evening, gyes");
            if (hours >= 22 && hours < 9)
                Console.WriteLine("Good night, gyes");
            Console.ReadKey();

        }
    }
}
