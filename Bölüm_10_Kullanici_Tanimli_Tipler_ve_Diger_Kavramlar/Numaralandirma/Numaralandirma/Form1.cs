namespace Numaralandirma
{
    enum EArkadaslik
    {
        SadeceBen = 0,
        Arkadaslarim = 1,
        ArkadaslariminArkadaslari = 2,
        Ozel = 3
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EArkadaslik ea = (EArkadaslik)comboBox1.SelectedIndex;
            int sayi = Convert.ToInt32(ea);
            switch (ea)
            {
                case EArkadaslik.SadeceBen:

                    MessageBox.Show(ea.ToString() + sayi);
                    break;
                case EArkadaslik.Arkadaslarim:
                    MessageBox.Show(ea.ToString() + sayi);
                    break;
                case EArkadaslik.ArkadaslariminArkadaslari:
                    MessageBox.Show(ea.ToString() + sayi);
                    break;
                case EArkadaslik.Ozel:
                    MessageBox.Show(ea.ToString() + sayi);
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = comboBox1.SelectedIndex;
            switch (sayi)
            {
                case EArkadas.SadeceBen:
                    MessageBox.Show(sayi.ToString());
                    break;
                case EArkadas.Arkadaslarim:
                    MessageBox.Show(sayi.ToString());
                    break;
                case EArkadas.ArkadaslariminArkadaslari:
                    MessageBox.Show(sayi.ToString());
                    break;
                case EArkadas.Ozel:
                    MessageBox.Show(sayi.ToString());
                    break;
                default:
                    break;
            }
        }
    }
    class EArkadas
    {
        public const int SadeceBen = 0; //const, static gibi ama deðeri deðiþtirilemiyor
        public const int Arkadaslarim = 1;
        public const int ArkadaslariminArkadaslari = 2;
        public const int Ozel = 3;
    }
}
