using System;
using System.Linq;
using System.Collections.Generic;

namespace Dictionary_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 1, 2, 2 };
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            Console.Write("Part 2- Intersection of two arrays is: ");
            Console.Write("[" + String.Join(",",intersect2.Select(p => p.ToString())) + "]");
            Console.WriteLine("\n");

        }
        public static int[] Intersect2(int[] nums1, int[] nums2)
        
        {
            var primarydict = nums1.Select((index, value) => new { value, index })
                      .ToDictionary(pair => pair.value, pair => pair.index);

            var secondarydict = nums2.Select((index, value) => new { value, index })
                      .ToDictionary(pair => pair.value, pair => pair.index);

            //outputs index of intersection in terms of nums1
            var resultDict = primarydict.Keys.Intersect(secondarydict.Keys)
                                          .ToDictionary(t => t, t => primarydict[t]);

            int x = resultDict.Count;
            int[] retrn = new int[x];

            for (int i=0; i<x;i++)
                retrn[i] = resultDict[i];

            return retrn;
        }

    }
}
