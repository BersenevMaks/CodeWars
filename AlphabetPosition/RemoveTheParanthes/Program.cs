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
            string s = "(first group) (second group) (third group)";
            string result = "";
            //Console.WriteLine(new Regex(@"\([\s\w]+\)|\([\w\s\(\)\-.]+\)", RegexOptions.IgnoreCase).Replace(s, ""));
            int opens = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (s.Substring(i, 1) == "(")
                    opens++;
                if (opens == 0)
                    result += s.Substring(i, 1);
                if (s.Substring(i, 1) == ")")
                    opens--;
            }
            Console.WriteLine("\""+result+ "\"");
            Console.ReadKey();
        }
    }
}
