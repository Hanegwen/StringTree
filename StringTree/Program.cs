using System;

namespace StringTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.LoadText();

            if(tree.IsReady())
            {
                //Yes It's Ready
            }

            Console.ReadLine();
        }
    }
}
