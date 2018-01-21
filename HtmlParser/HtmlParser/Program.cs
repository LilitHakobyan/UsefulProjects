using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace HtmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlCode;
            using (var client = new WebClient())
            {
                htmlCode = client.DownloadString("https://free-proxy-list.net/");
            }
            var tdLlist = new List<string>();
            //Console.WriteLine(htmlCode);
            for (int i = 0; i < htmlCode.Length; i++)
            {
                if ((htmlCode[i] == '<') && (htmlCode[i + 1] == 't') && (htmlCode[i + 2] == 'd') && (htmlCode[i + 3] == '>'))
                {
                    int index = i + 4;
                    string element = string.Empty;
                    while (htmlCode[index] != '<')
                    {
                        element += htmlCode[index++];

                    }
                    tdLlist.Add(element);
                }
            }

            var ipList = new List<string>();
            var portList = new List<int>();
            var countryList = new List<string>();
            for (int i = 0; i < tdLlist.Count; i += 4)
            {
                ipList.Add(tdLlist[i]);
                portList.Add(int.Parse(tdLlist[i + 1]));
                countryList.Add(tdLlist[i + 2]);
            }

         
        }
    }
}
