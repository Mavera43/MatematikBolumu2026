using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace turdonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //byte sayi1 = 10;
        //byte sayi2 = 20;
        //byte sonuc;
        //sonuc = (byte)(sayi1 + sayi2);
        //Console.WriteLine($"sayı1'in tipi{sayi1.GetType()}");
        //Console.WriteLine($"sayı2'in tipi{sayi2.GetType()}");
        //Console.WriteLine($"sayı1 ve sayı2 nin tipi : {(sayi1 + sayi2).GetType()}");
        //// byte türünde iki sayının toplamı byte türünde olmayabilir. Bu nedenle, sonuç int türünde olur.

        //int sayi3 = 100;
        ////stringe dönüştürme
        //string metin = sayi3.ToString(); // int türündeki sayi3'ü string türüne dönüştürür.
        //Console.WriteLine($"sayı 3'ün tipi : {sayi3.GetType()}");
        //Console.WriteLine("-----------------");
        //Console.WriteLine(123235.2342m.ToString().GetType());
        //int x1, x2, x3;
        //string str1 = "123";
        //x1 = 1; x2=2; x3=3;
        //string metin2 = x1 + x2 + x3 +str1;
        //metin2=(x1 + x2 + x3 + str1);
        //Console.WriteLine(metin2);
        //metin2 =x1.ToString() + x2.ToString() + x3.ToString() + str1;
        //Console.WriteLine(metin2);
        //Console.WriteLine("--------------");
        ////char tipi tek karakter tutar. Tek tırnak içinde yazılır.
        //    char karakter = 'A';
        //    Console.WriteLine($"karakterin tipi : {karakter.GetType()}");
        //    Console.WriteLine($"karakterin değeri : {karakter}");
        //    int ch = karakter; // char türündeki karakteri int türüne dönüştürür. Bu, karakterin ASCII değerini verir.
        //karakter = 'Y';
        //ch= karakter; // char türündeki karakteri int türüne dönüştürür. Bu, karakterin ASCII değerini verir.
        //Console.WriteLine($"karakterin ASCII değeri : {ch}");

        //Console.WriteLine((3.0f * (5.0f / 7f)).GetType());
        // int i =  (int)(3f * (5f / 7f));
        //// Console.Write($"i değeri : {i}");

        //Console.WriteLine("-----------------------");
        //int a = 10;
        //int b = 20;
        //decimal c;
        //a = a * 2;
        //b = 20 + 50 - 10 * 2;
        //c = (decimal)(b / 3m);
        //Console.WriteLine($"b nin değeri {b}");
        //Console.WriteLine($"c nin değeri {c}");
        //// artırma ve eksiltme operatörleri
        ////    a++;  a'nın değerini 1 artırır. a = a + 1; ile aynı anlama gelir.
        ////    b--;  b'nin değerini 1 azaltır. b = b - 1; ile aynı anlama gelir.
        //a = 1;b = 3;
        //Console.WriteLine($"anın değeri : {a++}");
        //Console.WriteLine($"b'nin değeri : {--b + a}");
        //a = 10;
        //b = 20;
        ////a = a + b;
        //a += a + b; // a'nın değerini a + b kadar artırır. a = a + (a + b); ile aynı anlama gelir.
        //a -= 5; // a'nın değerini 5 azaltır. a = a - 5; ile aynı anlama gelir.
        bir:
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            string s1 = Console.ReadLine();
            if (!int.TryParse(s1, out int sayi1))
                goto bir;

            iki:
            Console.WriteLine("Lütfen başka bir sayı giriniz : ");
            string s2 = Console.ReadLine();
            if (!int.TryParse(s2, out int sayi2))
                goto iki;
            int sonuc = sayi1 + sayi2;
            Console.WriteLine($"Sonuç : {sonuc}");



            Random zar = new Random();
            int zarAtma1 = 5;
            int zarAtma2 = 5;
            int zarAtma3 = 5;
            int toplam = zarAtma1 + zarAtma2 + zarAtma3;
            Console.WriteLine($"Zar Atma:  {zarAtma1} + {zarAtma2} + {zarAtma3} = {toplam}");

            if ((zarAtma1 == zarAtma2) && (zarAtma2 == zarAtma3))
            {
                Console.WriteLine("3lu attin! +6 puan kazandınız!");
                toplam += 6;
            }

            else if ((zarAtma1 == zarAtma2) || (zarAtma2 == zarAtma3) || (zarAtma1 == zarAtma3))
            {
                Console.WriteLine("çift attın! +2 puan kazandınız!");
                toplam += 2;
            }

            else
            {
                Console.WriteLine("Üzgünüm! Kaybettiniz.");
            }
            if (toplam >= 15)
                Console.WriteLine($"Kazandınız. puanınız : {toplam}");
        }

    }
    }
}
