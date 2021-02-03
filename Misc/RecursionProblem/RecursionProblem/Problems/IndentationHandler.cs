using System;
using System.Collections.Generic;
using System.Linq;

namespace RecursionProblem.Problems
{
    public class Node
    {
        public string Name { get; set; }
        public int IndentationCount { get; set; }
        public List<object> Childs { get; set; }
    }

    public class IndentationHandler
    {
        public static void HandleIndentation(string input)
        {
            var splitChars = new[]{'<', '>' , '/'};
            var items = input.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            var root = CreateTree(new List<string>(items));

            Console.WriteLine($"<{root.Name}>");
            TraverseNodes(root.Childs);
            Console.WriteLine($"</{root.Name}>");
        }

        private static Node CreateTree(List<string> itemCollection)
        {
            var nodes = new Stack<Node>();
            foreach (var item in itemCollection)
            {
                if (nodes.Count > 0 && nodes.Peek().Name.Equals(item))
                {
                    var root = nodes.Pop();
                    if (nodes.Count == 0) return root;

                    var top = nodes.Peek();
                    root.IndentationCount = !root.Childs.Any() ? 1 : ((Node)root.Childs.First()).IndentationCount + 1;
                    top.Childs.Add(root);
                }
                else
                {
                    var newItem = new Node
                    {
                        Name = item,
                        IndentationCount = 0,
                        Childs = new List<object>()
                    };
                    nodes.Push(newItem);
                }
            }
            return null;
        }

        private static void TraverseNodes(IEnumerable<object> childs, int currentIndentation = 0)
        {
            foreach (Node child in childs)
            {
                var tempMaxIndentation = child.IndentationCount > currentIndentation ? child.IndentationCount : currentIndentation;

                PrintNode(child, tempMaxIndentation, "<");
                TraverseNodes(child.Childs, tempMaxIndentation);
                PrintNode(child, tempMaxIndentation, "</");
            }
        }

        private static void PrintNode(Node child, int maxIndentation, string start)
        {
            var gap = "";
            var spaceChar = "   ";
            var count = maxIndentation - child.IndentationCount;
            for (var i = 0; i <= count; i++) gap += spaceChar;
            Console.WriteLine($"{gap}{start}{child.Name}>");
        }
    }
}
