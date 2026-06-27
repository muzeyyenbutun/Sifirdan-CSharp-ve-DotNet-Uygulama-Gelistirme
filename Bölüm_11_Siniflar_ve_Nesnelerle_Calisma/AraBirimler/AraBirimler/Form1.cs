namespace AraBirimler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            KisiManager km = new KisiManager(ogrenci);

            button1.Text = km.KalanPara().ToString();

            Personel personel = new Personel();
            KisiManager km2 = new KisiManager(personel);

            Text = km2.KalanPara().ToString();
        }
    }
}
