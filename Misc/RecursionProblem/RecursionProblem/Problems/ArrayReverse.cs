namespace RecursionProblem.Problems
{
    public class ArrayReverse
    {
        public static int[] Reverse(int[] ary, int start, int end)
        {
            if (start >= end)
                return ary;

            var temp = ary[start];
            ary[start] = ary[end];
            ary[end] = temp;
            return Reverse(ary, ++start, --end);
        }
    }
}
