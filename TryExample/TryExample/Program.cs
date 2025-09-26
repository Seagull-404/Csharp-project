using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Caculator c=new Caculator();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            int r = c.Add(x,y);
            Console.WriteLine(r);
        }
    }
    class Caculator
    {
        public int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            bool hasError= false;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch (ArgumentException ane)
            {

                Console.WriteLine(ane.Message);
                hasError = true;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                hasError = true;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                hasError = true;
            }
            finally
            {
                if (hasError)
                {
                    Console.WriteLine("又犯罪了");
                }
                else
                {
                    Console.WriteLine("搞滴蛮好");
                }
            
            }
         
            int result=a+b;
            return result;
        
        }
    }
}
