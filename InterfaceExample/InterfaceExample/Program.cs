using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5, };
            ArrayList nums2 =new ArrayList {1,2,3,4,5 };
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Avg(nums2));

        }

        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
                
            }
            return sum;
        }

        static double Avg(IEnumerable nums)
        {
            int sum = 0; double count = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
                count++;
            }
            return sum/count;
        }
    }
}
