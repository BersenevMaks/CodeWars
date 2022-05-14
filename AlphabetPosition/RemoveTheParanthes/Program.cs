using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RemoveTheParanthes
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            string s = "(first group) (second group) (third group)";
            Console.WriteLine(new Regex(@"\([\s\w]+\)|\([\w\s\(\)\-.]+\)", RegexOptions.IgnoreCase).Replace(s, ""));
            int end = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i, 1) == "(")
                { start = i; break; }
            }
            for (int i = s.Length - 1; i > start; i--)
            {
                if (s.Substring(i, 1) == ")")
                { end = i + 1; break; }
            }
            int numSymb = s.Length - end;
            if (end >= s.Length) numSymb = 0;
            Console.WriteLine("\""+s.Substring(0, start) + s.Substring(end, numSymb)+"\"");

            Console.ReadKey();
        }
    }
}
