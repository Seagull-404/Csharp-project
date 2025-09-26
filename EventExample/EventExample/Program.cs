using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Timer timer = new Timer();
            //timer.Interval = 1000;  
            //Boy boy = new Boy();
            //Girl girl = new Girl();
            //timer.Elapsed += boy.Action;
            //timer.Elapsed += girl.Action;
            //timer.Start();
            //Console.ReadLine();
            Form form = new Form(); 
            Controller controller=new Controller(form); 
            form.ShowDialog();  

        }
    }
    class Controller
    {
        private Form form;
        public Controller(Form form)
        {

            if (form != null)
            {
                this.form = form;
                this.form.Click += this.FormClicked;
            }

        }

        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }


        //class Boy
        //{
        //    internal void Action(object sender, ElapsedEventArgs e)
        //    {
        //        Console.WriteLine("You Jump!");
        //    }
        //}
        //class Girl
        //{
        //    internal void Action(object sender, ElapsedEventArgs e)
        //    {
        //        Console.WriteLine("I Jump!");
        //    }
        //}
    }
