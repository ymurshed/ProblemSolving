using System;
using System.Collections.Generic;
using System.Linq;

namespace StringProblem.Problems
{
    public class LineComparator
    {
        public static List<string[]> Synonyms = new List<string[]>
        {
            new[] {"rate", "ratings", "rates"},
            new[] {"approval", "popularity"}
        };

        public static List<string[]> Lines = new List<string[]>
        {
            new[] {"obama approval rate", "obama popularity ratings"},
            new[] {"obama popularity rates", "obama approval ratings"},
            new[] {"obama approval rating", "obama TV ratings"},
            new[] {"obama approval rate", "popularity ratings obama"}
        };

        public static void CompareLine()
        {
            var output = new List<bool>();

            foreach (var line in Lines)
            {
                var x = line[0].Split(' ');
                var y = line[1].Split(' ');

                var line1 = new List<string>(x);
                var line2 = new List<string>(y);

                if (line1.Count != line2.Count)
                {
                    output.Add(false);
                    continue;
                }

                for (var i = 0; i < line1.Count; i++)
                {
                    line1[i] = GetSynonym(line1[i]);
                    line2[i] = GetSynonym(line2[i]);
                }

                line1.Sort();
                line2.Sort();

                output.Add(line1.SequenceEqual(line2));
            }

            Console.WriteLine($"Result is: {string.Join(" ", output)}");
        }

        private static string GetSynonym(string intput)
        {
            var synonyms = Synonyms.Find(o => o.Contains(intput));
            if (synonyms != null && synonyms.Any()) return synonyms.First();
            return intput;
        }
    }
}