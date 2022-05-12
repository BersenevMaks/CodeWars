using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The sunset sets at twelve o' clock.";
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string result = "";
            int index = -1;
            for (int i = 0; i < text.Length; i++)
            {
                index = abc.IndexOf(text.ToLower().Trim().Substring(i, 1));
                if (index > -1)
                    result += index + 1 + " ";
            }
            Console.WriteLine(result.Remove(result.Length - 1, 1));
            Console.ReadKey();
        }
    }
}
