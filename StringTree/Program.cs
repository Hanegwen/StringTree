using System;

namespace StringTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.LoadText();


            Console.WriteLine("Press 1 To Try and Output a List");
            Console.WriteLine("Press 2 To Find a Child Node");

            //Console.WriteLine("DEBUG: Press 4 To Print Children with Parents");
            string Input = Console.ReadLine();

            switch(Input)
            {
                case "1":
                    if (tree.IsReady())
                    {
                        tree.WriteOutLineFile();
                    }
                    else
                    {
                        Console.WriteLine("Not Ready or Didn't Work");
                        tree.GetNode(Console.ReadLine());
                    }
                    break;
                case "2":
                    Console.WriteLine("Type the entire word with Capitals of Spaces of parent");
                    tree.GetNode(Console.ReadLine());
                    break;

                //case "4":
                    //tree.DebugParentAndChildren();
                    //break;
                default:
                    break;
            }

            

            Console.ReadLine();
        }
    }
}
