namespace StaticKavrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.sayi1 = 1;
            Goster(Class1.sayi1, "Class1");
            //Class1 c1 = new Class1();
            //Goster(Class1.sayi1, "c1 nesnesi oluþturulup");
            Class2 c2 = new Class2();
            Goster(Class1.sayi1, "Class2");

            //Class1.sayi1 Class3 teki test deðiþkenine aktarýlýyor
            Class3 c3 = new Class3();

            Goster(Class1.sayi1, "Class3");
            Goster(c3.test, "c3 nesnesi üzerindeki deðiþken");
            Class1.SayiEkle(10);
            Goster(Class1.sayi1, "Class1");
            ////Class3 teki test deðiþkeni aynen kalýr. Çünkü Class1.sayi1 deðiþkenini
            ///test deðiþkenine aktarýlmadý
            Goster(c3.test, "c3 nesnesi üzerindeki deðiþken");
        }
        void Goster(int sayi, string class_name)
        {
            textBox1.Text += class_name + " sayi1=" + sayi + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = Class4.sayi1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Goster(Class4.sayi1, "Class4");
            Class4 c4_1 = new Class4();

            Goster(c4_1.sayi2, "c4_1");
            Goster(Class4.sayi1, "Class4");

            Class4 c4_2 = new Class4();

            Goster(c4_2.sayi2, "c4_2");
            Goster(Class4.sayi1, "Class4");

            Class4 c4_3 = new Class4();

            Goster(c4_3.sayi2, "c4_3");
            Goster(Class4.sayi1, "Class4");

            Class4 c4_4 = new Class4();

            Goster(c4_4.sayi2, "c4_4");
            Goster(Class4.sayi1, "Class4");

            //static sayý nesne her oluþturulduðunda sýfýrlanmaz, kaldýðý yerden devam eder.
        }
    }
}
