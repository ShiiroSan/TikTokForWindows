using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace TikTokProtobufConverter
{
    class Program
    {
        public struct Data
        {
            public Data(int intValue, string strValue)
            {
                IntegerData = intValue;
                StringData = strValue;
            }

            public int IntegerData { get; private set; }
            public string StringData { get; private set; }
        }

        static void Main(string[] args)
        {
            string namespaceToUse = "TikTokForWindows";

            string classNamePattern = @"final class\s(.+)?(?=\sextends Message)";
            string pattern = @"(?:@WireField\(adapter =.+?(?=tag =))tag = ([0-9]+)\)\s+(public|private)\s(.+)?(?=\s)\s(.+)?(?=;)";

            Console.WriteLine("Enter the path to the folder you want to convert");
            string specifiedFolder = Console.ReadLine();

            //specifiedFolder = Environment.CurrentDirectory;
            foreach (string file in Directory.EnumerateFiles(specifiedFolder, "*.java"))
            {

                RegexOptions options = RegexOptions.Multiline;
                //string input = File.ReadAllText("list.txt");
                string input = File.ReadAllText(file);

                string className = Regex.Match(input, classNamePattern).Groups[1].Value;

                MatchCollection regex = Regex.Matches(input, pattern, options);
                var list = new List<Data>();
                foreach (Match match in regex)
                {
                    list.Add(new Data(int.Parse(match.Groups[1].Value), match.Groups[2].Value + " " + convertTypeToCSharp(match.Groups[3].Value) + " " + match.Groups[4].Value));
                }
                list = InsertionSort(list);
                string csharpout = $"using ProtoBuf;\nusing System.Collections.Generic;\n\nnamespace {namespaceToUse} {{\n" + "\t[ProtoContract]" + Environment.NewLine + $"\tclass {className} {{" + Environment.NewLine;
                for (int i = 0; i < list.Count; i++)
                {
                    string item = list[i].StringData;
                    if (item != null)
                    {
                        csharpout += $"\t\t[ProtoMember({list[i].IntegerData})]" + Environment.NewLine + "\t\t" + list[i].StringData + "{ get; set; }" + Environment.NewLine;
                    }
                }
                csharpout += "\t}\n}";
                //Console.WriteLine(csharpout);
                File.WriteAllText(specifiedFolder + "\\CSharp\\" + className + ".cs", csharpout);
            }
        }

        static List<Data> InsertionSort(List<Data> inputArray)
        {
            for (int i = 0; i < inputArray.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1].IntegerData > inputArray[j].IntegerData)
                    {
                        Data temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        static string convertTypeToCSharp(string javatype)
        {
            switch (javatype)
            {
                case "List<String>":
                    return "List<string>";
                case "String":
                    return "string";
                case "Long":
                    return "long";
                case "Boolean":
                    return "bool";
                case "Integer":
                    return "int";
                case "Double":
                    return "double";
                default:
                    return javatype;
            }
        }
    }
}
