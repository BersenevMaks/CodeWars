using System;

namespace FindMissingLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new[] { 'a', 'b', 'c', 'd', 'f' };
            char[] chArray = new[] {'a','b','c','d','e','f','g','h','i',
                      'j','k','l','m','n','o','p','q','r',
                      's','t','u','v','w','x','y','z',
                      'A','B','C','D','E','F','G','H','I',
                      'J','K','L','M','N','O','P','Q','R',
                      'S','T','U','V','W','X','Y','Z'};
            for (int j = 0; j < chArray.Length; j++)
                if (array[0] == chArray[j])
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] != chArray[i + j])
                        {
                            Console.WriteLine(chArray[i + j]);
                            j = chArray.Length;
                            break;
                        }
                    }
                }
            Console.ReadLine();
        }
    }
}
