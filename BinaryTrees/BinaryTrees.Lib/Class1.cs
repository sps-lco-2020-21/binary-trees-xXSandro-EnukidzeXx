using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTrees.Lib
{
    public class BinaryTree
    {
        BinaryTreeNode _root;
        public BinaryTree()
        {

        }

        public BinaryTree(int value)
        {
            _root = new BinaryTreeNode(value);
        }

        public void Add(int newValue)
        {
            if (_root == null)
            {
                _root = new BinaryTreeNode(newValue);
            }
            else
            {
                _root.Add(newValue);
            }
        }

        public bool Contains(int value)
        {
            return _root.Contains(value);
        }
        public int Depth()
        {
            return(_root == null ? 0 : _root.Depth);
        }

        public int Sum
        {
            get
            {
                return (_root == null ? 0 : _root.Sum);
            }
        }
    }

    public class BinaryTreeNode
    {
        int _value;
        BinaryTreeNode _left;
        BinaryTreeNode _right;
        public BinaryTreeNode(int value) 
        {
            _value = value;
        }

        public void Add(int nv)
        {
            if(nv<_value && _left == null)
            {
                _left = new BinaryTreeNode(nv);
                return;
            }
            if(nv>_value && _right == null)
            {
                _right = new BinaryTreeNode(nv);
                return;
            }

            if (nv < _value)
            {
                _left.Add(nv);
            }
            else
            {
                _right.Add(nv);
            }

        }
        public bool Contains(int targetVal)
        {
            BinaryTreeNode current = this;
            while(current != null)
            {
                if(current._value < targetVal)
                {
                    current = current._right;
                    continue;
                }
                if(current._value > targetVal)
                {
                    current = current._left;
                    continue;
                }
                if(current._value == targetVal)
                {
                    return true;
                }
            }
            return false;
        }
        public int Depth
        {
            get
            {
                if (this != null)
                    return 1 + Math.Max(_left.Depth, _right.Depth);
                else
                    return 0;
            }
        }

        public int Sum
        {
            get
            {
                BinaryTreeNode current = this;
                if(current==null)
                {
                    return 0;
                }
                else
                {
                    return (_value + _left.Sum + _right.Sum);
                }
            }
        }
    }
}
