using prac2023;

Root tree = new Root();

Console.WriteLine(string.Join(",", ToEnumerable(tree.root)));

Console.WriteLine(string.Join(",", ToEnumerable2(tree.root)));


//recursion
IEnumerable<T> ToEnumerable<T>(TreeNode<T> root)
{
    if (root == null)
    {
        yield break;
    }
    yield return root.Value;
    foreach (var item in ToEnumerable(root.Left).Concat(ToEnumerable(root.Right)))
    {
        yield return item;
    }
}

//without rec
IEnumerable<T> ToEnumerable2<T>(TreeNode<T> root)
{
    var stack = new Stack<TreeNode<T>>();
    stack.Push(root);
    while (stack.Count > 0)
    {
        var current = stack.Pop();
        if(current == null)
        {
            continue;
        }
        yield return current.Value;
        stack.Push(current.Left);
        stack.Push(current.Right);
    }
}
