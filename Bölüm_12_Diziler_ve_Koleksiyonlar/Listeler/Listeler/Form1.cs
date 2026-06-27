namespace Listeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generics:Genellemeler
            List<int> liste = new List<int>();
            liste.Add(10);
            button1.Text = liste[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();
            liste.Add("müzeyyen");
            button2.Text = liste[0];
        }
    }
}
