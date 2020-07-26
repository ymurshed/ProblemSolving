using System.Collections.Generic;
using System.Linq;

namespace AddTwoNums
{

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var num1 = GetNumbersFromListNode(l1);
            var num2 = GetNumbersFromListNode(l2);
            var num3 = Sum(num1, num2);
            var node = GetListNodeFromNumber(num3);
            return node;
        }

        public static List<int> GetNumbersFromListNode(ListNode listNode)
        {
            var numbers = new List<int>();
            while (listNode != null)
            {
                numbers.Add(listNode.val);
                listNode = listNode.next;
            }
            return numbers;
        }

        public static ListNode GetListNodeFromNumber(List<int> numbers)
        {
            var listNodes = new List<ListNode>();

            foreach (var n in numbers)
            {
                var node = new ListNode(n);
                listNodes.Add(node);
            }

            for (var i = 0; i < listNodes.Count - 1; i++)
            {
                listNodes[i].next = listNodes[i + 1];
            }

            return listNodes.FirstOrDefault();
        }

        private static List<int> Sum(IList<int> a, IList<int> b)
        {
            if (a.Count > b.Count)
            {
                var appendCount = a.Count - b.Count;
                for (var i = 0; i < appendCount; i++)
                {
                    b.Add(0);
                }
            }
            else if (b.Count > a.Count)
            {
                var appendCount = b.Count - a.Count;
                for (var i = 0; i < appendCount; i++)
                {
                    a.Add(0);
                }
            }

            var carry = 0;
            var result = new List<int>();

            for (var i = 0; i < a.Count; i++)
            {
                var sum = a[i] + b[i] + carry;
                
                if (sum > 9)
                {
                    sum = sum % 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                result.Add(sum);    
            }

            if (carry == 1) result.Add(1);
            return result;
        }
    }
}
