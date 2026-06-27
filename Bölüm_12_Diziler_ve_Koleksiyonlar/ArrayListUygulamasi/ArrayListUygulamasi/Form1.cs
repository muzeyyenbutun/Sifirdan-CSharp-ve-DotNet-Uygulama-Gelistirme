using System.Collections;

namespace ArrayListUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList liste = new ArrayList();
            liste.Add(10);//0
            liste.Add("Müzeyyen"); //1
            liste.Add(button1);//2
            liste.Add(button1);//3
            liste.Add(button1);//4
            liste.Add(button1);//5
            liste.Add(button1);//6
            button1.Text = Convert.ToString(liste[0]); //10
            Button btn1 = (Button)liste[2];
            Text = btn1.Text;
            liste.RemoveAt(2);
            liste.Remove(button1);//sadece bir tane button1 listeden çýkarýlýr.
            //Button btn1 = (Button)liste[2]; //hata oluþur
            Text = button1.Text;
            liste.Clear(); //bütün elemanlarý listeden çýkarýlýr.
            Text = liste.Count.ToString();
        }
    }
}
