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
                int cycles = 1;
                if(data.StartsWith(" "))
                {
                    do
                    {
                        cycles++;
                        data.Remove(1, 1);
                    }
                    while(data.StartsWith(" "));
                    Console.WriteLine(data + cycles);
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
