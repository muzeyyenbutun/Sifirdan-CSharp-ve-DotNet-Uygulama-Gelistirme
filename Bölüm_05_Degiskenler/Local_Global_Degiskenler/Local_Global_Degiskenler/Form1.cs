namespace Local_Global_Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int sayi1 = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi2 = 2;
            button1.Text = sayi1.ToString();
            Text = sayi2.ToString();
        }
    }
}
