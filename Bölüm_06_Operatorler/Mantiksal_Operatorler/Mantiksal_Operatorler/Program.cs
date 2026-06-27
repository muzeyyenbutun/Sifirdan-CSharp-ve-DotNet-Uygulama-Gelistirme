namespace Mantiksal_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 23;
            int sayi2 = 42;
            int sayi3 = 34;
            bool dogruMu = (sayi1 > sayi2) || (sayi3 <= sayi1);
            Console.WriteLine("sayı1=23 <---> sayi2=42  <-----> sayi3=34 \n");
            Console.WriteLine("(sayi1 > sayi2) || (sayi3<=sayi1) :{0}", dogruMu);
        }
    }
}
