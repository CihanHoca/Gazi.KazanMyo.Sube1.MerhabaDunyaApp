using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.Sube1.KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Birinci sayıyı giriniz:");
            //byte sayi1 = byte.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz:");
            //byte sayi2 = byte.Parse(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Birinci sayı büyük");
            //}
            //else if(sayi1<sayi2)
            //{
            //    Console.WriteLine("İkinci sayı büyük");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşit");
            //}



            //?: -> Ternary Operator.
            //Kullanımı: [Şart]?[Doğru değer]:[Yanlış değer]

            // Console.WriteLine(sayi1>sayi2?"Birinci sayı büyük": "İkinci sayı büyük ya da sayılar eşit");

            //   &&
            //1      1=1
            //1      0=0
            //0      1=0
            //0      0=0

            //   ||
            //1     1=1
            //1     0=1
            //0     1=1
            //0     0=0


            //byte a = 10;
            //byte b = 3; 
            //Console.WriteLine((!(a == b) && (b == 3)));

            //Hava nasıl?
            //Güzel/Kötü
            //Kötü-> Evde otur
            //Güzel->Güzel diyosun ama kaç derece?
            // 0'dan küçükse -> Çok soğuk Evde otur
            // 0-15 ->Soğuk Evde otur
            // 15-30->Dışarı çık
            // 30'dan büyükse -> Çok sıcak evde otur


            //String bir class'tır. Referans tipidir.

            //Console.WriteLine("Hava Nasıl?");
            //string cevap = Console.ReadLine();
            //if (cevap.ToLower() == "kötü")
            //{
            //    Console.WriteLine("Evde otur");
            //}
            //else if (cevap.ToLower() == "güzel")
            //{
            //    Console.WriteLine("Kaç Derece?");
            //    sbyte derece = sbyte.Parse(Console.ReadLine());
            //    if (derece < 0)
            //    {
            //        Console.WriteLine("Çok soğuk.");
            //    }
            //    else if (derece >= 0 && derece <= 15)
            //    {
            //        Console.WriteLine("Soğuk");
            //    }
            //    else if (derece >= 16 && derece <= 30)
            //    {
            //        Console.WriteLine("Dışarı çık");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Çok sıcak");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sadece Güzel/Kötü giriniz.");
            //}

            //BreakPoint
            //Debugging-Hata Ayıklama İşlemi
            Console.WriteLine("Bir sayı giriniz:");
            byte sayi = byte.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("1 girildi");
                    break;
                case 2:
                    Console.WriteLine("2 girildi");
                    break;
                case 3:
                    Console.WriteLine("3 girildi");
                    break;
                default:
                    Console.WriteLine("1 ya da 2 harici başka bir değer girildi.");
                    break;
            }

            if (sayi==1)
            {
                Console.WriteLine("1 girildi");
            }
            else if (sayi==2)
            {
                Console.WriteLine("2 Girildi");
            }
            else if (sayi==3)
            {
                Console.WriteLine("3 Girildi");
            }
            else
            {
                Console.WriteLine("1 ya da 2 harici başka bir değer girildi.");
            }

            Console.ReadKey();
        }
    }
}
