namespace If_Switch_Case_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 > 0)
            {
                button1.Text = "sayý pozitif";
            }
            else if (sayi1 < 0)
            {
                button1.Text = "sayý negatif";
            }
            else
            {
                button1.Text = "sayý nötr";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox2.Text);
            int sayi2 = Convert.ToInt32(textBox3.Text);

            if (sayi1 > sayi2)
            {
                button2.Text = sayi1 + "büyük" + sayi2;
            }
            else if (sayi1 < sayi2)
            {
                button2.Text = sayi1 + "küçük" + sayi2;
            }
            else
            {
                button2.Text = sayi1 + "eþit" + sayi2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = 11, sayi2 = 14, sayi3 = 12;

            int enbuyuk = sayi1;

            if (sayi2 > enbuyuk)
            {
                enbuyuk = sayi2;
            }

            if (sayi3 > enbuyuk) enbuyuk = sayi3;
            button3.Text = enbuyuk.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox4.Text);

            switch (sayi)
            {
                case 1:
                    button4.Text = "Pazartesi";
                    break;
                case 2:
                    button4.Text = "Salý";
                    break;
                case 3:
                    button4.Text = "Çarþamba";
                    break;
                case 4:
                    button4.Text = "Perþembe";
                    break;
                case 5:
                    button4.Text = "Cuma";
                    break;
                case 6:
                    button4.Text = "Cumartesi";
                    break;
                case 7:
                    button4.Text = "Pazar";
                    break;
                default:
                    button4.Text = "Böyle bir gün yok!";
                    break;
            }
        }
    }
}
