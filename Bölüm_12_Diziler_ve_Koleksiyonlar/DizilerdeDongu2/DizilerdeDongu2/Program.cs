int[] rakamlar = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int sayac = 0;
foreach (var elemandegeri in rakamlar)
{
    Console.WriteLine(sayac + ". eleman=" + elemandegeri);
    sayac++;
}