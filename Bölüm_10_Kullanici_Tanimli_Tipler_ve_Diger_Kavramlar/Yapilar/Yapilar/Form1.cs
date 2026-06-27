namespace Yapilar
{
    public partial class Form1 : Form
    {
        struct Tarih
        {
            public int gun;
            public int ay;
            public int yil;
            //Default yapýlandýrýcý eklenemez
            //Aþýrý yüklenmiþ yapýlandýrýcý eklenir.
            public Tarih(int g, int a)
            {
                //Aþýrý yüklemiþ yapýlandýrýcýda bütün alanlara ilk deðer atamasý yapýlmalý
                gun = g;
                ay = a;
                yil = 2019;
            }
            public string ToString()
            {
                return gun + "/" + ay + "/" + yil;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Default yapýlandýrýcý bütün alanlara ilk deðer atar.
            Tarih t = new Tarih();
            button1.Text = t.ToString();
            int sayi = new int(); //varsayýlan yapýlandýrýcý
            Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarih t = new Tarih(22, 11);
            button2.Text = t.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Yapýlandýrýcý kullanmadan da struct tipinde bir deðiþken tanýmlanýr, 
            //ama alanlara ilk deðer atamasý yapýlmaz.

            Tarih t; //=new Tarih();
            t.gun = 10;
            t.ay = 10;
            t.yil = 2019;

            button3.Text = t.ToString();

            int sayi; //=new int();

            sayi = 10;
            sayi = sayi * 10;

            Text = sayi.ToString();
        }
    }
}
