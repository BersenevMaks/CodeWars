using System;

namespace LastDigit_Of_a_Large_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 937640, 767456, 981242 };
            int mult = array[array.Length - 1];
            for (int i = array.Length; i > 0; i--)
            {
                mult = (int)Math.Pow(array[i - 1] % 10, mult) % 10;
            }
            Console.WriteLine(mult);
            Console.ReadKey();
        }
    }
}
