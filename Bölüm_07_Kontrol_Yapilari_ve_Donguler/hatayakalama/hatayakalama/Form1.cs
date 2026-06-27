namespace hatayakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);

                int sonuc = sayi1 / sayi2;
            }
            catch (FormatException hata)
            {
                MessageBox.Show("Sayý Giriniz");
            }
            catch (DivideByZeroException hata)
            {
                MessageBox.Show("Sýfýra Bölünme Hatasý");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }
    }
}
