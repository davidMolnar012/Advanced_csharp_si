using System;

namespace SortString
{
    class SortString
    {
        static void Main(string[] args)
        {
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            Console.WriteLine(str);
            string[] words = str.Split(' ');
            Console.WriteLine(string.Join(", ", words));
            Array.Sort(words);
            Console.WriteLine(string.Join(", ", words));
            string s = string.Join(" ", words);
            Console.WriteLine(s);
        }
    }
}
