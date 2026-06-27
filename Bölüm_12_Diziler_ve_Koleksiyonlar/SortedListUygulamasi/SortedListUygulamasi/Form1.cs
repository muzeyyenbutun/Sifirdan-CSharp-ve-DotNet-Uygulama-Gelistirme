using System.Collections;

namespace SortedListUygulamasi
{
    public partial class Form1 : Form
    {
        SortedList liste = new SortedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste.Add("müzeyyen", 10); //yoksa ekler varsa hata verir
            liste["irem"] = 199;
            liste["burcu"] = 299;
            liste["müzeyyen"] = 399; //varsa deðiþtirir yoksa ekle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object deger = liste[textBox1.Text];
            if (deger != null)
            {
                button2.Text = liste[textBox1.Text].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                string value = liste.GetByIndex(i).ToString();
                string key = liste.GetKey(i).ToString();
                listBox1.Items.Add(key + "=" + value);
            }
        }
    }
}
