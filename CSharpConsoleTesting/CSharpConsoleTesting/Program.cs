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

            Dictionary<string, string> Test = new Dictionary<string, string>();
            Test.Add("1", "Red");
            Test.Add("2", "Blue");
            Test.Add("3", "Blue");
            Test.Add("4", "Green");

            List<string> test1 = new List<string>();
            foreach (string Msg in Test.Values.Distinct()) 
            {
                string Key = Test.FirstOrDefault(x => x.Value == Msg).Key;
                test1.Add(Key +  Msg);
            }

            // Prevent the Application from stopping
            Console.ReadLine();
        }
    }
}
