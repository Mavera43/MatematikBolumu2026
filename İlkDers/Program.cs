using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlkDers
{
    internal class Program
    {
        // double vize = 0 , final = 0;
        // double vize = 0;
        // double final = 0;
        double vize, final, ortalama; // Değişkenleri tanımlarken aynı satırda yapabiliriz.
                                      // neden double? Çünkü notlar genellikle ondalık sayı olabilir (örneğin, 85.5 gibi).

        ////vize ve final notunu alıp ortalamayı hesaplayıp
        ////ekrana yazdıran program
        //Console.WriteLine("Vize notunu giriniz: ");
        //    vize = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan bir girdi bekler. Bu satır, kullanıcı bir tuşa basana kadar programın durmasını sağlar.
            
        //    Console.WriteLine("Final notunu giriniz: ");
        //    final= Convert.ToDouble(Console.ReadLine());

        //     ortalama = (vize* 0.4) + (final* 0.6);
        //    // Ortalama hesaplama formülü: vize %40, final %60 etkili.
        //    //Console.WriteLine(ortalama);
        //    //Console.WriteLine("Ortalamanız : ");
        //    //Console.WriteLine(ortalama); // Ortalama değerini ekrana yazdırır.
        //    //Console.WriteLine("Ortalamanız : " + ortalama); // Ortalama değerini ekrana yazdırır.
        //    Console.WriteLine($"Ortalamanız : {ortalama}'dır");
 
        //    //$ ve süslü parantezler, string interpolation (dizgi içi yerleştirme) olarak
        //    //adlandırılan bir özelliktir.
        //    //Bu özellik, değişkenleri ve ifadeleri doğrudan bir string içinde
        //    //kullanmanıza olanak tanır.
        //    //Yukarıdaki örnekte, ortalama değişkeninin değeri doğrudan string içinde yerleştirilmiştir ve ekrana yazdırılır.

        //    if(ortalama>=50)
        //        Console.WriteLine("Geçti");
        //    else
        //        Console.WriteLine("Kaldı");

          
        static void Main(string[] args)  // Main methodu, programın başlangıç noktasıdır.
                                         // Program çalıştırıldığında, bu method otomatik olarak çağrılır.
        {
        basla:  //bu bir etikettir. goto komutu ile bu etikete atlama yapabiliriz.
            double s1, s2 = 0;
            Console.WriteLine("1. sayıyı giriniz");
             s1 = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan bir girdi bekler. Bu satır, kullanıcı bir tuşa basana kadar programın durmasını sağlar.
            Console.WriteLine("2. sayıyı giriniz");
             s2 = Convert.ToDouble( Console.ReadLine());

            double toplam, ortalama = 0;
            // toplam = Convert.ToDouble(s1) + Convert.ToDouble(s2);
            toplam = s1 + s2;
            ortalama = toplam / 2; //ortalama = (s1 + s2) / 2; şeklinde de yazılabilir.
            //Console.WriteLine("Sayıların Toplamı :" + toplam);
            //Console.WriteLine("Sayıların ortalama :" + ortalama);
            Console.WriteLine($"Sayıların Toplamı : {toplam}");
            Console.WriteLine($"Sayıların Ortalaması : {ortalama}");
            Console.WriteLine("Başka işlem yapacak mısınız [E/H]");
            string cevap = Console.ReadLine();
            if (cevap == "E" || cevap == "e")
                goto basla; // goto komutu, programın akışını belirtilen etikete atlar.
                            // Bu durumda, "basla" etiketine atlar ve kullanıcıdan tekrar sayılar girmesini sağlar.
            else
                Console.WriteLine("Program sonlandırıldı.");

          //  double sayı1;
          //  double 1sayı; // Değişken isimleri rakamla başlayamaz. Bu nedenle, "1sayı" geçerli bir değişken adı değildir.

            //float pi = 13.14f; // float türünde bir değişken tanımlarken,
            //                   // ondalık sayıların sonuna "f" eklenmelidir.
            //                   // Bu, derleyiciye bu sayının float türünde olduğunu belirtir.
            //decimal para = 100.50m; // decimal türünde bir değişken tanımlarken,
            //                        // ondalık sayıların sonuna "m" eklenmelidir.
            //                        // Bu, derleyiciye bu sayının decimal türünde olduğunu belirtir.
            //double e = 2.71828d; // double türünde bir değişken tanımlarken, ondalık sayıların sonuna herhangi bir ek eklenmesine gerek yoktur.
            //                    // double türü, ondalık sayıları temsil etmek için kullanılan bir veri türüdür ve genellikle daha yüksek hassasiyet sağlar.
            Console.ReadLine();

        }
    }
}
