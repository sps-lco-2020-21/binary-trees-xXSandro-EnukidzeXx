using System;
using BinaryTrees.Lib;
using System.Diagnostics;

namespace BinaryTrees.App
{
    class Program
    {
        static void Main()
        {
            BinaryTree bt = new BinaryTree(3);
            bt.Add(5);
            bt.Add(7);
            bt.Add(9);
            bt.Add(2);
            bt.Add(1);
            bt.Add(4);
            Debug.Assert(bt.Contains(7)==true);
            Debug.Assert(bt.Contains(12)==false);
            //Debug.Assert(bt.Depth() == 4);
            Debug.Assert(bt.Sum == 28);
        }
    }
}
