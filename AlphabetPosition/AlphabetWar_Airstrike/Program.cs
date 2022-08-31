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

        public static void AlphabetWar(string test, string fight)
        {
            string str = "";
            bool isBomb = false;
            int score = 0;
            int temp = 0;

            Console.WriteLine("=====");
            Console.WriteLine(fight+" : "+test);

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

            for (int i = 0; i < fight.Length; i++)
            {
                char c = fight[i];
                if (c != '*')
                {
                    if (isBomb)
                    {
                        isBomb = false;
                        continue;
                    }
                    str += c;
                }
                else if (c == '*')
                {
                    if (str.Length > 0 && !isBomb) str = str.Remove(str.Length - 1, 1);
                    isBomb = true;
                }
            }
            Console.WriteLine("-bobmbs : " + str);
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
            AlphabetWar("Right side wins!", "z");
            AlphabetWar("Let's fight again!", "****");
            AlphabetWar("Let's fight again!", "z*dq*mw*pb*s");
            AlphabetWar("Let's fight again!", "zdqmwpbs");
            AlphabetWar("Right side wins!", "zz*zzs");
            AlphabetWar("Left side wins!", "*wwwwww*z*");
            AlphabetWar("","b*o");
        }
    }
}
