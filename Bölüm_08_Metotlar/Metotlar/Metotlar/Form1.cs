namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void YaziGoster()
        {
            Text = DateTime.Now.ToString();
        }
        string Topla(string s1, string s2)
        {
            return s1 + s2;
        }
        string Topla(int s1, int s2)
        {
            return Convert.ToString(s1 + s2);
        }
        //Overload:aþýrý yükleme: adaþ iþlevler
        string Topla(float s1, float s2)
        {
            return Convert.ToString(s1 + s2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            YaziGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = Topla("10", "10");
            button2.Text = Topla(14, 14);
        }
        (int, int, string) CokDegerdondur()
        {
            return (15, 16, "Csharp");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            string adi;

            (sayi1, sayi2, adi) = CokDegerdondur();

            button3.Text = adi + sayi1 + sayi2;
        }
        (int, int, int, float) DortIslem(int s1, int s2)
        {
            int sonuc1 = s1 + s2;
            int sonuc2 = s1 * s2;
            int sonuc3 = s1 - s2;

            float sonuc4 = s1 * 1.0F / s2;

            return (sonuc1, sonuc2, sonuc3, sonuc4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1, s2, s3;
            float s4;

            (s1, s2, s3, s4) = DortIslem(19, 20);

            button4.Text = s1 + " " + s2 + " " + s3 + " " + s4;
        }
    }
}
