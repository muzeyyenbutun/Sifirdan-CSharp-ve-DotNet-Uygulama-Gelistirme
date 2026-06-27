using System.Collections;

namespace StackveQueue
{
    public partial class Form1 : Form
    {
        Stack liste1 = new Stack();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ekle
            liste1.Push(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object cikan = liste1.Pop();
            button2.Text = cikan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sadece ilk eleman hangi onu getirir
            object ýlkeleman = liste1.Peek();
            button3.Text = ýlkeleman.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //stack içerisindeki elemanlarý listeler
            object[] icerik = liste1.ToArray();
            listBox1.Items.Clear();
            for (int i = 0; i < icerik.Length; i++)
            {
                listBox1.Items.Add(icerik[i].ToString());
            }
        }
    }
}