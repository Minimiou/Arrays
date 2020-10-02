using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[2];

            //names[0] = "John Doe";
            //names[1] = "Jane Doe";

            //foreach (string s in names)
            //Console.WriteLine(s);

            //Console.ReadLine();


            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine("Item number " + i + ": " + names[i]);
            //}
            //int[] numbers = new int[5] { 4, 3, 8, 0, 5 };
            ////or
            //int[] cats = { 4, 3, 8, 0, 5,7 };

            //Console.ReadLine();


            Random generator = new Random();
            int input;

            int[] numbers = new int[30];

            Console.WriteLine("Please enter 2 numbers");
            

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = generator.Next(1, 101);
            }
            
            


            Array.Sort(numbers);

            Console.ReadLine();
        }
    }
}
