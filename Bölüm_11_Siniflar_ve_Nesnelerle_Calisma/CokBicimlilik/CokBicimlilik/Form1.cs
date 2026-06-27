namespace CokBicimlilik
{
    public partial class Form1 : Form
    {
        Kalem kl = new Kalem();
        DolmaKalem dk = new DolmaKalem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ZeminRengiDegistir(button1);
            ZeminRengiDegistir(textBox1);
        }
        void ZeminRengiDegistir(Control ctl)
        {
            ctl.BackColor = Color.Red;
        }
        void ZeminRengiDegistir(Button ctl)
        {
            ctl.BackColor = Color.Red;
        }
        void ZeminRengiDegistir(TextBox ctl)
        {
            ctl.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kalem butonu
            kl.Yaz(textBox1.Text);
            button1.Text = kl.MurekkepMiktari.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Dolma kalem butonu
            dk.Yaz(textBox1.Text);
            button2.Text = dk.MurekkepMiktari.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Doldur butonu
            dk.Doldur();
            button2.Text = dk.MurekkepMiktari.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //dolmakalem->Kalem butonu
            //kalem gibi davranýyor. Kalemin metodlarý kullanýlýyor
            Kalem k = (Kalem)dk;

            k.Yaz(textBox1.Text);

            button4.Text = k.MurekkepMiktari.ToString();
        }
    }
}
