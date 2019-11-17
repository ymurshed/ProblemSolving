using System;

namespace CodilitySolution.Lesson_1
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            var start = -1;
            var longestGap = 0;

            var binary = Convert.ToString(N, 2);
            for (var i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    if (start == -1) start = i;
                    else
                    {
                        var gap = i - start - 1;
                        if (gap > longestGap) longestGap = gap;
                        start = i;
                    }
                }
            }

            return longestGap;
        }
    }
}
