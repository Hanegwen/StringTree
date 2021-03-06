﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringTree
{
    class TreeNode
    {
        public TreeNode parentNode;
        public string nodeData;

        public TreeNode(string nodeData)
        {
            this.parentNode = null;
            this.nodeData = nodeData;
        }

        public TreeNode(TreeNode parentNode, string nodeData)
        {
            this.parentNode = parentNode;
            this.nodeData = nodeData;
        }
    }
}
