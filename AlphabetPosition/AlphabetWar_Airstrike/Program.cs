using System;
using System.Collections.Generic;

namespace AlphabetWar_Airstrike
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();

        }

        public static void AlphabetWar(string str)
        {
            int score = 0;
            int temp = 0;
            Dictionary<char, int> Power = new Dictionary<char, int>
            {
                {'w',-4},
                {'p',-3},
                {'b',-2},
                {'s',-1},
                {'m',4},
                {'q',3},
                {'d',2},
                {'z',1}
            };
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                
                if (c == '*')
                {
                    if (i > 0)
                        str.Remove(i - 1);
                    if (i < str.Length - 1)
                        str.Remove(i + 1);
                    str.Remove(i);
                }
            }

            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (Power.TryGetValue(c, out temp))
                {
                    score += temp;
                }
            }
            if (score > 0) Console.WriteLine("Right side wins!");
            else if (score < 0) Console.WriteLine("Left side wins!");
            else Console.WriteLine("Let's fight again!");

        }

        public static void Test()
        {
            AlphabetWar("z");
            AlphabetWar("****");
            AlphabetWar("z*dq*mw*pb*s");
            AlphabetWar("zdqmwpbs");
            AlphabetWar("zz*zzs");
            AlphabetWar("*wwwwww*z*");
            AlphabetWar("b*o");
        }
    }
}
