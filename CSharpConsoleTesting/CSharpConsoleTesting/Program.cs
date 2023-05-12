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

            /*
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
            */

            // Find the Index of the first int
            string MessageIDMsg = "{\"MI\":3327455,";
            int IDIndex = MessageIDMsg.IndexOfAny("0123456789".ToCharArray());
            string MessageIDStr = MessageIDMsg.Substring(0, IDIndex);
            string MessageIDInt = MessageIDMsg.Substring(IDIndex, MessageIDMsg.Length - IDIndex - 1);
            Int32.TryParse(MessageIDInt, out int MsgID);
            MsgID++;
            MessageIDMsg = "{\"MI\":" + MsgID.ToString() + ",";

            // Prevent the Application from stopping
            Console.ReadLine();
        }
    }
}
