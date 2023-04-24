using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Started");

            // Check if a substring is detected in a list of strings
            List<string> StringList = new List<string>();

            StringList.Add("B1art");
            StringList.Add("P2eter");
            StringList.Add("P3iet");

            foreach (string str in StringList) 
            {
                if (str.Contains("2"))
                {
                    Console.WriteLine(str);
                }
            }

            // Prevent the Application from stopping
            Console.ReadLine();
        }
    }
}
