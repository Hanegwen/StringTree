using System;
using System.Collections.Generic;
using System.Text;

namespace StringTree
{
    class Tree
    {
        List<TreeNode> nodes = new List<TreeNode>();
        bool isReady = false;
        public void LoadText()
        {
            string[] TheBaseData = System.IO.File.ReadAllLines(@"C:\workspace\TreeData.txt");

            foreach(string data in TheBaseData)
            {
                string localData = data;
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

                TreeNode data = new TreeNode();
            }

            isReady = true;
        }

        public bool IsReady()
        {
            return isReady;
        }

        public void GetNode(int nodeNumber)
        {
            Console.WriteLine(nodes[nodeNumber]);
        }

        public void WriteOutLineFile()
        {

        }

        
    }
}
