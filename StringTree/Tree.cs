using System;
using System.Collections.Generic;
using System.Text;

namespace StringTree
{
    class Tree
    {
        bool isReady = false;
        public void LoadText()
        {
            string[] TheBaseData = System.IO.File.ReadAllLines(@"C:\workspace\TreeData.txt");

            foreach(string data in TheBaseData)
            {
                
                if(data.StartsWith(" "))
                {
                    Console.WriteLine(data + "1");
                }
                else
                {
                    Console.WriteLine(data);
                }
            }

            isReady = true;
        }

        public bool IsReady()
        {
            return isReady;
        }

        public void GetNode(int someReference)
        {

        }

        public void WriteOutLineFile()
        {

        }
    }
}
