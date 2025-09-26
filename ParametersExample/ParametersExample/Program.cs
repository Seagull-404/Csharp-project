using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int result = CalculateSum(1,2,3);
            //Console.WriteLine(result);
            string str = "Tim;Tom,Amy.Lis";
            string[] reuslt = str.Split(';', ',', '.');
            foreach (var name in reuslt)
            {
                Console.WriteLine(name);
            }
        }

        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }
}
