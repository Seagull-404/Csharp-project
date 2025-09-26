using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form();
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog();
        }
    }
}
