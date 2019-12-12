using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ParameterLister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> BagOfCandies = new List<string>();
            if (args.Length > 0)
            {
                Console.WriteLine("Hoy Captain! We have some parameter there!");
                if (args.Length == 1)
                {
                    Console.WriteLine("Urm Captain, only one in fact!");
                    string sadNSoloParameter = args[0];
                    if (IsValidPath(sadNSoloParameter).IsFile)
                    {
                        Console.WriteLine("That was a file in fact!");
                        string[] BagOfBiscuit = File.ReadAllLines(sadNSoloParameter);
                        foreach (var Twix in BagOfBiscuit)
                        {
                            BagOfCandies.Add(Twix);
                        }
                    }
                    else
                    {
                        Console.WriteLine("... Only one link there!");
                        BagOfCandies.Add(sadNSoloParameter);
                    }
                }
                else
                {
                    Console.WriteLine("Captain! Many parameter there!");
                    var TheCrewOfParam = args;
                    foreach(var soloParam in TheCrewOfParam)
                    {
                        Console.WriteLine("They even put file on it!");
                        if (IsValidPath(soloParam).IsFile)
                        {
                            string[] BagOfBiscuit = File.ReadAllLines(soloParam);
                            foreach (var Mars in BagOfBiscuit)
                            {
                                BagOfCandies.Add(Mars);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tiny link there!");
                            BagOfCandies.Add(soloParam);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Print argument list here:");
                BagOfCandies.Add(Console.ReadLine());
            }
            string pattern = @"((?:[a-z]+|_|-)*)=((?:[a-zA-Z]+|[0-9]+|_|-|\.|\%|\*)*)";
            RegexOptions options = RegexOptions.Multiline;

            foreach(string candie in BagOfCandies)
            {
                var Lollipops = Regex.Matches(candie, pattern, options);
                var argList = new List<string>();
                var valList = new List<string>();
                foreach (Match lollipop in Lollipops)
                {
                    argList.Add(lollipop.Groups[1].Value);
                }
            }
        }

        static (string URI, bool IsAbsoluteUri, bool IsFile) IsValidPath(string path) //based on drzaus on stackoverflow
        {
            Uri u;
            try
            {
                u = new Uri(path);
            }
            catch (Exception)
            {
                return (
                    URI: path,
                    IsAbsoluteUri: false,
                    IsFile: true
                );
            }

            return (
                    URI: path,
                    u.IsAbsoluteUri,
                    u.IsFile
                );
        }
    }
}