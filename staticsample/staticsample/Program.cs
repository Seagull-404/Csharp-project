using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace staticsample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你好");
            Form form=new Form();
            form.Text = "你好";
            form.ShowDialog();


        }
    }
}
