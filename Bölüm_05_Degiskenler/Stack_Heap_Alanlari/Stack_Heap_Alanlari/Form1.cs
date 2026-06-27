namespace Stack_Heap_Alanlari
{
    public partial class Form1 : Form
    {
        class BosSinif
        {
            public int bossayi = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deðer tipli deðiþkenler
            int sayi1 = 10;
            int sayi2 = sayi1;
            sayi1 = 20;
            button1.Text = sayi2.ToString();
            //referans tipli deðiþkenler
            BosSinif b = new BosSinif();
            b.bossayi = 100;
            BosSinif kopya = b; //FFAAA
            //kopya = new BosSinif(); //FFFAA1
            b.bossayi = 200;
            Text = kopya.bossayi.ToString();

        }
    }
}
