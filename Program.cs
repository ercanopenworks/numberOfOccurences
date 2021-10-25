using System;
using System.Collections.Generic;
using System.Linq;

namespace numberOfOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = Console.ReadLine().TrimEnd().Split(',').ToList().Select(a => Convert.ToInt32(a)).ToList();
            List<int> arr2 = Console.ReadLine().TrimEnd().Split(',').ToList().Select(a => Convert.ToInt32(a)).ToList();

            Console.WriteLine(solution(arr1.ToArray(), arr2.ToArray()));
        }

        public static int solution(int[] X, int[] Y)
        {
            int res = 1;
            Dictionary<double, int> set = new Dictionary<double, int>();

            for (int i = 0; i < X.Length; i++)
            {
                double frac = ((double)X[i] / (double)Y[i]);
                if (!set.ContainsKey(frac))
                {
                    set.Add(frac, 1);
                }
                else set[frac]++;

            }

            
            var keyOfMaxValue = set.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            res = set[keyOfMaxValue];

            return res;
        }
    }
}
