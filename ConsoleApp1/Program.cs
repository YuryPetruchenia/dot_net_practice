using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            void Tack1 ()
            {
                int[] array = new int[3];
            }

            void Task2 ()
            {
                object [] array = { 32, 'A', "Hello"};
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                array[0] = (int)array[0] + 10;

                array[2] = array[2] + ",guys!";

                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }

            void Task3 ()
            {
                int[] ar = new int[13];
                Random rand = new Random();
                for (int i = 0; i < ar.Length; i++)
                    ar[i] = rand.Next();

                foreach (var item in ar)
                {
                    Console.WriteLine(item);
                }

                Array.Sort(ar);
                Console.WriteLine("Max velue");
                Console.WriteLine(ar[12]);
            }

            

            
        }
    }
}
