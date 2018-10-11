using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTree
{
    class Tree
    {
        TreeNode baseNode = new TreeNode("Base");
        List<TreeNode> nodes = new List<TreeNode>();
        List<string> stringNodes = new List<string>();
        bool isReady = false;


        public void LoadText()
        {
            string[] TheBaseData = System.IO.File.ReadAllLines(@"E:\Columbia\Senior\Algorithms\TreeData.txt");

            for(int i = 0; i < TheBaseData.Length; i++)
            {
                TreeNode NewNode = new TreeNode(baseNode, TheBaseData[i]);

                nodes.Add(NewNode);
            }


            int whiteForLast = 100;
            for(int i = 0; i < nodes.Count; i++)
            {


                int count = nodes[i].ToString().TakeWhile(c => c == ' ').Count();
                //int tabCount = nodes[i].ToString().TakeWhile(Char.).Count();
                Console.WriteLine("WhiteSpace " + count);

                if(count > whiteForLast)
                {
                    nodes[i].parentNode = nodes[i - 1];
                }

                whiteForLast = count;
            }
            


            isReady = true;



            
        }

        public bool IsReady() //Done
        {
            return isReady;
        }

        public void GetNode(string parentNodeText) //Done
        {
            for(int i = 0; i < nodes.Count; i++)
            {
                
                if (nodes[i].parentNode.nodeData == parentNodeText)
                {
                        Console.WriteLine(nodes[i].nodeData);
                }
                
                else
                {
                    Console.WriteLine("No Node Like That Found");
                }
            }
        }

        public void WriteOutLineFile() //Done
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                stringNodes.Add(nodes[i].nodeData.ToString());
                Console.WriteLine(stringNodes[i]);
            }

            System.IO.File.WriteAllLines(@"E:\Columbia\Senior\Algorithms\TreeFinalData.txt", stringNodes);
        }

        


        public void DebugParentAndChildren()
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                stringNodes.Add(nodes[i].nodeData.ToString());
                Console.WriteLine(stringNodes[i] + nodes[i].parentNode.nodeData);
            }
        }
    }
}
