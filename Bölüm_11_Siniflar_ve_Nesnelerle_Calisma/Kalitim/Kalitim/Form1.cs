namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            Text = Class1.sayi4.ToString();
            Class1.sayi4 = 500;
            button1.Text = Class3.sayi4.ToString();
        }
    }
}
