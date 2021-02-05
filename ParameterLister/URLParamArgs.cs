using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ParameterLister
{
    class URLParamArgs
    {
        List<string> argsList = new List<string>();
        String baseURL;
        String url;
        List<string> valsList = new List<string>();
        public URLParamArgs(string url)
        {
            Url = url ?? throw new ArgumentNullException(nameof(url));
            makeArgsAndValsList();
        }

        public List<string> ArgsList { get => argsList; set => argsList = value; }
        public string BaseURL { get => baseURL; set => baseURL = value; }
        public string Url { get => url; set => url = value; }
        public List<string> ValsList { get => valsList; set => valsList = value; }
        private void makeArgsAndValsList()
        {
            string pattern = @"(?:(http(?:s|)\:\/\/(?:[^?]*))|)(?:\&|\?)([^=]*)\=([^&]*)";
            /*
             * (?:(http(?:s|)\:\/\/(?:[^?]*))|) --> Capture the url
             * (?:\&|\?)([^=]*)\= --> Capture the argument
             * ([^&]*) --> capture the value
             */
            RegexOptions options = RegexOptions.Multiline;

            var Lollipops = Regex.Matches(Url, pattern, options);
            BaseURL = Lollipops[0].Groups[1].Value;
            for (int i = 0; i < Lollipops.Count; i++)
            {
                Match lollipop = Lollipops[i];
                argsList.Add(lollipop.Groups[2].Value);
                valsList.Add(lollipop.Groups[3].Value);
            }
        }
    }
}
