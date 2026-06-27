namespace Temsilciler
{
    public partial class Form1 : Form
    {
        delegate int hesapla(int sayi1, int sayi2);
        public Form1()
        {
            InitializeComponent();
        }
        int Topla(int s1, int s2)
        {
            return s1 + s2;
        }

        int Carp(int s1, int s2)
        {
            return s1 * s2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hesapla fonksiyon = Carp;
            int sonuc = fonksiyon(10, 20);
            button1.Text = sonuc.ToString();

            fonksiyon = Topla;

            sonuc = fonksiyon(10, 20);

            Text = sonuc.ToString();
        }
    }
}
