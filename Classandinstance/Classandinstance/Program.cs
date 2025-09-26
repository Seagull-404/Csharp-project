using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classandinstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form myForm;
            myForm = new Form();
            myForm.Text = "我的窗口";
            myForm.ShowDialog();
        }
    }
}
