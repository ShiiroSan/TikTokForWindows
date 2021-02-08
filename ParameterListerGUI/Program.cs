using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParameterListerGUI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            /*
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
            {*/
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
          //  }
        }
    }
}
