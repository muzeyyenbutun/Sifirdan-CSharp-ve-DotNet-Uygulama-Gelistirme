namespace Arttirma_Azaltma_Operatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            Console.WriteLine("Sayi1 önce arttırma:" + (++sayi1));
            Console.WriteLine("Sayi1 önce azaltma:" + (--sayi1));
            Console.WriteLine("Sayi1 sonra arttırma:" + (sayi1++));
            Console.WriteLine("Sayi1 sonra azaltma:" + (sayi1--));
        }
    }
}
