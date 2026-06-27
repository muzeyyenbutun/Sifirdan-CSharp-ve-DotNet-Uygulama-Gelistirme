using isimuzaylari2;

namespace isimuzaylari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = A.Goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = B.Gizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = isimuzaylari.Veri.C.Ver();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = isimuzaylari.Veri.D.Ver();
        }
    }
}
