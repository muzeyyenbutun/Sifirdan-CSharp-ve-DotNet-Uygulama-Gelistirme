namespace Dongular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //f5:çalýþtýr
        //f9:break point ekle/kaldýr
        //f10:adým adým kodu çalýþtýr (fonsiyonlarýn içine girme)
        //f11:adým adým çalýþtýr. Fonksiyona denk gelirsen içine gir.
        //Ctrl+f10: imlecin bulunduðu satýra kadar çalýþtýr
        private void Test(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplam = toplam + i;
            }

            button1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            int i = 1;
            for (; ; )
            {
                if (i <= 100)
                {
                    toplam = toplam + i;
                    i++;
                }
                else
                {
                    break; //döngüden çýk;
                }
            }

            button2.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            int i = 1;
            while (true)
            {
                if (i <= 100)
                {
                    toplam = toplam + i;
                    i++;
                }
                else
                {
                    break; //döngüden çýk;
                }
            }

            button3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            int i = 1;
            while (i <= 100)
            {
                toplam = toplam + i;
                i++;
            }

            button4.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int i = 101;
            do
            {
                toplam = toplam + 1;
                i++;

            } while (i <= 100);

            button5.Text = toplam.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    toplam = toplam + i;
                }
            }

            button6.Text = toplam.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 0; i <= 100; i += 5)
            {
                toplam = toplam + i;
            }

            button7.Text = toplam.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int notum;

            bool sonuc = int.TryParse(textBox1.Text, out notum);
            if (sonuc == false)
            {
                MessageBox.Show("Sayý Giriniz");
                return;
            }
            if (notum > 90 && notum <= 100)
            {
                button8.Text = "A Aldýn";
            }
            else if (notum > 80 && notum <= 90)
            {
                button8.Text = "B Aldýn";
            }
            else if (notum > 70 && notum <= 80)
            {
                button8.Text = "C Aldýn";
            }
            else if (notum > 60 && notum <= 70)
            {
                button8.Text = "D Aldýn";
            }
            else if (notum > 0 && notum <= 60)
            {
                button8.Text = "K Aldýn";
            }
            else
            {
                button8.Text = "0-100 arasý not giriniz";
            }
        }
    }
}
