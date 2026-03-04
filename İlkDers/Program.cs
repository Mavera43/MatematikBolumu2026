using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlkDers
{
    internal class Program
    {
        static void Main(string[] args)  // Main methodu, programın başlangıç noktasıdır.
                                         // Program çalıştırıldığında, bu method otomatik olarak çağrılır.
        {
            // double vize = 0 , final = 0;
            // double vize = 0;
            // double final = 0;
            double vize, final, ortalama; // Değişkenleri tanımlarken aynı satırda yapabiliriz.
            // neden double? Çünkü notlar genellikle ondalık sayı olabilir (örneğin, 85.5 gibi).

            //vize ve final notunu alıp ortalamayı hesaplayıp
            //ekrana yazdıran program
            Console.WriteLine("Vize notunu giriniz: ");
            vize = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan bir girdi bekler. Bu satır, kullanıcı bir tuşa basana kadar programın durmasını sağlar.
            
            Console.WriteLine("Final notunu giriniz: ");
            final= Convert.ToDouble(Console.ReadLine());

             ortalama = (vize * 0.4) + (final * 0.6);
            // Ortalama hesaplama formülü: vize %40, final %60 etkili.
            //Console.WriteLine(ortalama);
            //Console.WriteLine("Ortalamanız : ");
            //Console.WriteLine(ortalama); // Ortalama değerini ekrana yazdırır.
            //Console.WriteLine("Ortalamanız : " + ortalama); // Ortalama değerini ekrana yazdırır.
            Console.WriteLine($"Ortalamanız : {ortalama}'dır");
 
            //$ ve süslü parantezler, string interpolation (dizgi içi yerleştirme) olarak
            //adlandırılan bir özelliktir.
            //Bu özellik, değişkenleri ve ifadeleri doğrudan bir string içinde
            //kullanmanıza olanak tanır.
            //Yukarıdaki örnekte, ortalama değişkeninin değeri doğrudan string içinde yerleştirilmiştir ve ekrana yazdırılır.

            if(ortalama>=50)
                Console.WriteLine("Geçti");
            else
                Console.WriteLine("Kaldı");

        }
    }
}
