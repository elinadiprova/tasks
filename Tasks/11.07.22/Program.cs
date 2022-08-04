﻿using System;

namespace _11._07._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            TreeNode tree = new TreeNode();
        }
    }

    
// * Definition for a binary tree node.
  public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

    }

    public class Solution
    {
        public bool CheckTree(TreeNode root)
        {
            if(root.val == root.left.val + root.right.val)
            {
                return true;
            }
            return false;
        }
    }
}
