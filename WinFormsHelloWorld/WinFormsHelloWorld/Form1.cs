namespace WinFormsHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxshowhello_Click(object sender, EventArgs e)
        {
            maskedTextBoxshowhello.Text = "hello world!";
        }
    }
}
