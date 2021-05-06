using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParameterListerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        private List<string> argList = new List<string>();
        private string filePath = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;

            var userGivenURLs = new List<string>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    var fileLines = File.ReadAllLines(filePath);
                    userGivenURLs.AddRange(fileLines);
                }
            }
            var urlList = new List<URLParamArgs>();
            foreach (string userURL in userGivenURLs)
            {
                urlList.Add(new URLParamArgs(userURL));
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
                        uniqArgList[arg].AddPosition(i + 1);
                    }
                    else
                    {
                        uniqArgList.Add(arg, new UniqArg(url.BaseURL, url.ValsList[i], 1, i + 1));
                    }
                }
            }
            argList = uniqArgList.Keys.ToList();
            for (int i = 0; i < uniqArgList.Count; i++)
            {
                treeView1.BeginUpdate();
                var dictElem = uniqArgList.ElementAt(i);
                treeView1.Nodes.Add(dictElem.Key);
                treeView1.Nodes[i].Nodes.Add("Occurence");
                treeView1.Nodes[i].Nodes[0].Nodes.Add(uniqArgList[dictElem.Key].Occurence.ToString());
                treeView1.Nodes[i].Nodes.Add("Value");
                for (int j = 0; j < uniqArgList[dictElem.Key].Value.Count; j++)
                {
                    treeView1.Nodes[i].Nodes[1].Nodes.Add(uniqArgList[dictElem.Key].Value[j]);
                }
                treeView1.Nodes[i].Nodes.Add("BaseURLCaller");
                for (int j = 0; j < uniqArgList[dictElem.Key].BaseURLCaller.Count; j++)
                {
                    treeView1.Nodes[i].Nodes[2].Nodes.Add(uniqArgList[dictElem.Key].BaseURLCaller[j]);
                }
                treeView1.Nodes[i].Nodes.Add("Position");
                for (int j = 0; j < uniqArgList[dictElem.Key].Position.Count; j++)
                {
                    treeView1.Nodes[i].Nodes[3].Nodes.Add(uniqArgList[dictElem.Key].Position[j].ToString());
                }


                treeView1.EndUpdate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string argSTR = "";
            foreach (string argument in argList)
            {
                argSTR += argument + "\n";
            }
            File.WriteAllText(filePath.Remove(filePath.Length-4,4) + "_Args.txt", argSTR);
            MessageBox.Show("Done.");
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
