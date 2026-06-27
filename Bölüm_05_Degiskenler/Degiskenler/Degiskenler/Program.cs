using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int normalsayi; // tamsayı sayısal değişken tanımlandı.
            normalsayi = 3; // değişkene değer atandı.
            int tamsayi = 4; // tamsayı sayısal değişken tanımlandı ve değer atandı.

            double noktalısayi; // Noktalı sayı değişkeni tanımlaması yapıldı.
            noktalısayi = 125.86; // değişkene noktalı sayı ataması yapıldı.

            string gun; // metin türünde bir değişken tanımlandı.
            gun = "Pazartesi"; // değişkene değer atandı.

            float sonuc = tamsayi * 1.0F / normalsayi;

            Console.WriteLine("int değeri: " + normalsayi);
            Console.WriteLine("int değeri: " + tamsayi);
            Console.WriteLine("double değeri: " + noktalısayi);
            Console.WriteLine("string değeri: " + gun);
            Console.WriteLine("float değeri: " + sonuc);

            Console.ReadKey();
        }
    }
}