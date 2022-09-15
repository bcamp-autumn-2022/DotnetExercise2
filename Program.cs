using System;
using System.IO;
using System.Net;
using System.Text;

namespace DotnetExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url;
            Console.WriteLine("Give the url");
            url=Console.ReadLine();
            string test = url.Substring(0, 8);
            if (String.Compare(test, "https://") == 0)
            {
                
            }
            else {
                url = "https://" + url;
            }
            WebRequest wb = WebRequest.Create(url);
            WebResponse rp = wb.GetResponse();
            StreamReader reader = new StreamReader(rp.GetResponseStream(), Encoding.ASCII);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
