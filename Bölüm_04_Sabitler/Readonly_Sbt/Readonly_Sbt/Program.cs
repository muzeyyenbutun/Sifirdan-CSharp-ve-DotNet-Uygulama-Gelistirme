class Program
{
    // Pi sayısını sabit olarak tanımlayalım
    public static readonly double pi = 3.14159;

    static void Main(string[] args)
    {
        // Değişkenleri tanımlayalım
        double alan, cevre, yaricap;
        string yaricapGir;

        Console.WriteLine("Dairenin yarıçapını girin: ");
        yaricapGir = Console.ReadLine();
        yaricap = Convert.ToDouble(yaricapGir);
        cevre = 2 * pi * yaricap;
        alan = pi * Math.Pow(yaricap, 2);

        Console.WriteLine("Dairenin alanı= {0}", alan);
        Console.WriteLine("Dairenin çevresi= {0}", cevre);
        Console.ReadKey();
    }
}