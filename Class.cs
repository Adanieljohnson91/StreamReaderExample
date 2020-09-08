using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamReader
{
    public class Reader
    {
        public string[] test = {"This", "Is", "A", "Test" };

        public void Write()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\DanJo\source\repos\StreamReader\StreamReader\TextFile.txt"))
            {
                foreach(string word in test)
                {
                    writer.WriteLine(word);
                }
            }
        }
        
    }
}
