using System;
using System.Collections.Generic;
using System.Globalization;
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
                    foreach (var soloParam in TheCrewOfParam)
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
                Console.WriteLine("Print URL list (seperated by space) or file with link you wanna scan here:");
                string userGivingMeTheInfo = Console.ReadLine();
                string[] CrewOfUserGaveInfo = userGivingMeTheInfo.Split(" ");
                foreach (string IAmBoredOfUsingVarName in CrewOfUserGaveInfo)
                {
                    if (IsValidPath(IAmBoredOfUsingVarName).IsFile)
                    {
                        string[] BagOfBiscuit = File.ReadAllLines(IAmBoredOfUsingVarName);
                        foreach (var Mars in BagOfBiscuit)
                        {
                            BagOfCandies.Add(Mars);
                        }
                    }
                    else
                        BagOfCandies.Add(IAmBoredOfUsingVarName);
                }
            }

            var urlList = new List<URLParamArgs>();

            foreach (string candie in BagOfCandies)
            {
                urlList.Add(new URLParamArgs(candie));
            }
            var uniqArgList = new Dictionary<string, UniqArg>();
            foreach (URLParamArgs url in urlList)
            {
                for (int i = 0; i < url.ArgsList.Count; i++)
                {
                    var arg = url.ArgsList[i];
                    if (uniqArgList.ContainsKey(arg))
                    {
                        uniqArgList[arg].AddBaseURLCaller(url.BaseURL);
                        uniqArgList[arg].AddValue(url.ValsList[i]);
                        uniqArgList[arg].Occurence++;
                        uniqArgList[arg].AddPosition(i+1);
                    }
                    else
                    {
                        uniqArgList.Add(arg, new UniqArg(url.BaseURL, url.ValsList[i], 1, i+1));
                    }
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

    class UniqArg
    {
        private List<string> baseURLCaller = new List<string>();
        private List<string> value = new List<string>();
        private int occurence;
        private List<int> position = new List<int>();

        public UniqArg(string baseURLCaller, string value, int occurence, int position)
        {
            BaseURLCaller.Add(baseURLCaller);
            Value.Add(value);
            Occurence = occurence;
            Position.Add(position);
        }

        public int Occurence { get => occurence; set => occurence = value; }
        public List<string> BaseURLCaller { get => baseURLCaller; set => baseURLCaller = value; }
        public List<string> Value { get => value; set => this.value = value; }
        public List<int> Position { get => position; set => position = value; }

        public void AddBaseURLCaller(string baseURL)
        {
            BaseURLCaller.Add(baseURL);
        }

        public void AddValue(string value)
        {
            Value.Add(value);
        }

        public void AddPosition(int pos)
        {
            Position.Add(pos);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}