using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ParameterLister
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((?:[a-z]+|_|-)*)=((?:[a-zA-Z]+|[0-9]+|_|-|\.|\%|\*)*)";
            Console.WriteLine("Print argument list here:");
            var lolipop = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;

            var var1 = Regex.Matches(lolipop, pattern, options);
            var argList = new List<string>();
            for (int i = 0; i < var1.Count; i++)
            {
                argList.Add(var1[i].Groups[1].Value);
            }
            File.AppendAllLines("arg", argList);
        }
    }
}
