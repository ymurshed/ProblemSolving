using System;
using System.Linq;

namespace CodilitySolution.Lesson_2
{
    public class CyclicRotation
    {
        private int[] RotateLeft(int[] A, int K)
        {
            if (!A.Any()) return A;

            var len = A.Length;
            if (len == K) return A;

            var rotateAry = new int[len];
            var startPosition = K % len;
            var itemCountFromFirstElement = len - startPosition;

            Array.Copy(A, 0, rotateAry, startPosition, itemCountFromFirstElement);
            Array.Copy(A, itemCountFromFirstElement, rotateAry, 0, len - itemCountFromFirstElement);
            return rotateAry;
        }

        private int[] RotateRight(int[] A, int K)
        {
            if (!A.Any()) return A;

            var len = A.Length;
            if (len == K) return A;
            if (K > len) K %= len;

            var rotateAry = new int[len];
            var startPosition = len - K;
            var itemCountFromFirstElement = len - startPosition;

            Array.Copy(A, 0, rotateAry, startPosition, itemCountFromFirstElement);
            Array.Copy(A, itemCountFromFirstElement, rotateAry, 0, len - itemCountFromFirstElement);
            return rotateAry;
        }

        public int[] solution(int[] A, int K, bool left = true)
        {
            if (left) return RotateLeft(A, K);
            return RotateRight(A, K);
        }
    }
}
