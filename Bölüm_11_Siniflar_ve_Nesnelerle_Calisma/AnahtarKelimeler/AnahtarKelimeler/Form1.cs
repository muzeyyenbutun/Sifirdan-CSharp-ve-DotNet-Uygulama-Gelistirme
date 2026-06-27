namespace AnahtarKelimeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text ="Button" + i;
                btn.Top = i * 20;
                btn.Height = 30;
                btn.Width = 100;
                this.Controls.Add(btn);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text ="";
                }
            }

        }
    }
}
