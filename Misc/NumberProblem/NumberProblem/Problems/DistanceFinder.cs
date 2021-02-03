using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberProblem.Problems
{
    public class DistanceFinder
    {
        public static List<int> Numbers = new List<int>
        {
            1, 5, 10, 2, 5, 7, 2, 1, 10, 8, 1, 5, 7, 5, 2, 9
        };

        private static void PrintResult(List<KeyValuePair<int, DistanceModel>> items, bool isMax = true)
        {
            foreach (var item in items)
            {
                Console.WriteLine(isMax
                    ? $"Total {item.Key} found = {item.Value.ItemCount}, max distance = {item.Value.MaxDistance}"
                    : $"Total {item.Key} found = {item.Value.ItemCount}, min distance = {item.Value.MinDistance}");
            }
        }

        public static void FindDistance()
        {
            var nummberIndexes = new Dictionary<int, DistanceModel>();

            for (var i = 0; i < Numbers.Count; i++)
            {
                var key = Numbers[i];

                if (!nummberIndexes.ContainsKey(key))
                {
                    nummberIndexes[key] = new DistanceModel
                    {
                        LastIndex = i,
                        ItemCount = 1,
                        MaxDistance = int.MinValue,
                        MinDistance = int.MaxValue
                    };
                }
                else
                {
                    var indexGap = i - nummberIndexes[key].LastIndex;
                    if (indexGap > nummberIndexes[key].MaxDistance) nummberIndexes[key].MaxDistance = indexGap;
                    if (indexGap < nummberIndexes[key].MinDistance) nummberIndexes[key].MinDistance= indexGap;

                    nummberIndexes[key].ItemCount++;
                    nummberIndexes[key].LastIndex = i;
                }
            }

            var max = nummberIndexes.Max(o => o.Value.MaxDistance);
            var min = nummberIndexes.Min(o => o.Value.MinDistance);

            var maxDistanceItems = nummberIndexes.Where(o => o.Value.MaxDistance >= max).Select(o => o).ToList();
            var minDistanceItems = nummberIndexes.Where(o => o.Value.MinDistance <= min).Select(o => o).ToList();

            PrintResult(maxDistanceItems);
            PrintResult(minDistanceItems, false);
        }
    }

    public class DistanceModel
    {
        public int LastIndex { get; set; }
        public int MaxDistance { get; set; }
        public int MinDistance { get; set; }
        public int ItemCount { get; set; }
    }
}
