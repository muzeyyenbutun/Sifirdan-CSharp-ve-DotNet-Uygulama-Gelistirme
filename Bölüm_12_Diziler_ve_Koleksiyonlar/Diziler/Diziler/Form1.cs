namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 4, 53, 3, 4, 56, 23 };
            int[] kopya = dizi;
            kopya[0] = 99;
            button1.Text = dizi[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 4, 53, 3, 4, 56, 23 };
            int[] kopya = new int[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
            {
                kopya[i] = dizi[i];
            }
            kopya[0] = 99;
            button2.Text = dizi[0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 4, 53, 3, 4, 56, 23 };
            int[] kopya = new int[dizi.Length];
            dizi.CopyTo(kopya, 0);
            kopya[0] = 99;
            button3.Text = dizi[0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 4, 53, 3, 4, 56, 23 };
            int[] kopya = new int[dizi.Length];
            Array.Copy(dizi, kopya, kopya.Length);
            kopya[0] = 99;
            button3.Text = dizi[0].ToString();
        }
        int Minimum(params int[] dizi)
        {
            int enkucuk = dizi[0];//dizinin ilk elemaný küçük kabul edilir
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < enkucuk)
                {
                    enkucuk = dizi[i];
                }
            }
            return enkucuk;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] dizi = { 11, -2, 3, 4, -5, 6 };
            int sayi = Minimum(dizi);
            button6.Text = sayi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi = Minimum(4, 6, 7, 8, 99, -9, 10);
            button7.Text = sayi.ToString();
        }
    }
}
