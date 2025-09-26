
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] nums =  new int []  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //wehre 方法会遍历集合中的每一个元素，对于每一个元素
            //都调用a=a>5这个lambda表达式判断一下是否为true
            //如果为true则把这个元素放到结果集合中
            IEnumerable<int> result = nums.Where(a => a>5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
