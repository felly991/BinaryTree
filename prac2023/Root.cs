using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac2023
{
    public class Root : TreeNode<int>
    {
        public TreeNode<int> root = new TreeNode<int>()
        {
            Value = 10,
            Left = new TreeNode<int>()
            {
                Value = 20,
                Left = new TreeNode<int>()
                {
                    Value = 30,
                    Right = new TreeNode<int>()
                    {
                        Value = 80
                    }
                },
                Right = new TreeNode<int>()
                {
                    Value = 40
                }
            },
            Right = new TreeNode<int>()
            {
                Value = 50,
                Right = new TreeNode<int>()
                {
                    Value = 60,
                    Left = new TreeNode<int>()
                    {
                        Value = 90
                    }
                },
                Left = new TreeNode<int>()
                {
                    Value = 70
                }
            }
        };
    }
}
