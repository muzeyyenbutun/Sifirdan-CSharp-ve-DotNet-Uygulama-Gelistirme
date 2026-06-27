namespace Paketleme
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramlamaDilleri pd = new ProgramlamaDilleri();
            pd.ProgramlamaDilAdi = Console.ReadLine();
            pd.Yazdir();
            Console.ReadKey();
        }
    }
}
