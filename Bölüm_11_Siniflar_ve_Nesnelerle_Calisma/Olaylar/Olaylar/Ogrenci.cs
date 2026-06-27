public class Ogrenci
{
    public Ogrenci()
    {
        Console.WriteLine("Yapıcı metot çalıştı.");
    }

    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public int Numara { get; set; }
    public double Ortalama { get; set; }

    ~Ogrenci()
    {
        Console.WriteLine("Yıkıcı metot çalıştı");
    }
}
