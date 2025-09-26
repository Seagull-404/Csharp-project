using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myform form = new Myform();
            
            form.ShowDialog();  
        }
    }
    class Myform : Form
    {
        private TextBox textBox;
        private Button button;

        public Myform()
        { 
           this.button = new Button();  
            this.textBox = new TextBox();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.ButtonClicked;
            this.button.Text= "Say Hello";
            this.button.Top = 20;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello,World!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
        }
    }

}
