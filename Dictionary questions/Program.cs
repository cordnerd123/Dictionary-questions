using System;
using System.Linq;
using System.Collections.Generic;

namespace Dictionary_questions
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] nums1 = { 1, 2, 2, 1 };
            //int[] nums2 = { 2, 2 };
            //Console.WriteLine("Question 5-Part 2");
            //int[] intersect2 = Intersect2(nums1, nums2);
            //Console.WriteLine("Part 2- Intersection of two arrays is: ");
            //DisplayArray(intersect2);
            //Console.WriteLine("\n");

        }
        public static int[] Intersect2(int[] nums1, int[] nums2)
        
        {
            try
            {
                string[] vars1 = nums1.ToString;
                string[] vars2 = nums2.ToString;
                IEnumerable<string> query = from var in vars1.Intersect(vars2)
                                            select var;

                foreach (var str in query)
                {
                    Console.WriteLine(str);

                }

            catch
            {

            }
        }

    }
}
