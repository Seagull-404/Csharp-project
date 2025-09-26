using System;
using Microsoft.Win32.SafeHandles;

namespace sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            Console.WriteLine("请输入圆盘个数");
            int n = int.Parse(Console.ReadLine());
            c.hanoi(n, 'A', 'B', 'C');

        }
    }
    internal class calculator
    {
        public void hanoi(int n, char qs, char zj, char mb)
        {
            if (n == 0) return;
            else
            {
                hanoi(n - 1, qs, mb, zj);//将起始柱A上n-1个圆盘利用目标住C挪动到中间柱B上
                Console.WriteLine(qs + "->" + mb);//把最后一个圆盘挪动到目标柱C上，展示挪动过程
                hanoi(n - 1, zj, qs, mb);//把剩下n-1个圆盘从中间柱B利用起始柱A挪动到最底层圆盘目标柱C上

            }

        }




    }
}
