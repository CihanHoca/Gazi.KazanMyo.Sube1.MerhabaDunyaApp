using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.DongulerApp
{
    class Program
    {
        static void Main(string[] args)
        {







            //Döngü değişkeni: Dönüş sayısı için kullanılır.

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Gazi");
            //}

            //Console.WriteLine("Taban Giriniz:");
            //byte taban = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Us giriniz:");
            //byte us = byte.Parse(Console.ReadLine());

            //int sonuc = 1;

            //for (int i = 0; i < us; i++)
            //{                
            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine(sonuc);

            //3!=3*2*1

            //Console.WriteLine("Sayı giriniz");
            //byte sayi = byte.Parse(Console.ReadLine());

            //int sonuc = 1;
            //for (int i = sayi; i > 1; i--)
            //{
            //    sonuc = sonuc * i;
            //}
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Birinci sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tek/Çift");
            //string cevap = Console.ReadLine().ToLower();
            //int kalan = cevap == "tek" ? 1 : 0;

            //int sonuc = 0;

            //if (sayi1 > sayi2)
            //{
            //    int temp = sayi2;
            //    sayi2 = sayi1;
            //    sayi1 = temp;
            //}

            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    if (i % 2 == kalan)
            //    {
            //        sonuc += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine($"Sonuc:{sonuc}");

            //Console.WriteLine("Sayı Giriniz:");
            //double sayi = double.Parse(Console.ReadLine());
            //int sayac = 0;
            //for (int i = 2; i < Math.Floor(sayi/2); i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        sayac++;
            //        if (sayac>0)
            //        {
            //            break;
            //        }
            //    }
            //}
            //if (sayac>0)
            //{
            //    Console.WriteLine("asal değildir");
            //}
            //else
            //{
            //    Console.WriteLine("Asaldır");
            //}


            //int toplam = 0;
            //Console.WriteLine("Sayı Giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //while (sayi != 0)
            //{
            //    toplam += sayi;
            //    Console.WriteLine("Sayı Giriniz:");
            //    sayi = int.Parse(Console.ReadLine());
            //}


            //
            //double sayi,toplam=0;
            //sbyte sayac = -1;//
            //do
            //{
            //    Console.WriteLine("Sayı Giriniz:");
            //    sayi = double.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    sayac++;
            //} while (sayi != 0);

            //Console.WriteLine($"Toplam:{toplam}\nOrtalama:{toplam/sayac}");

            //Next()

            //static methodlara class adıyla ulaşılır.

            Random rnd = new Random();//Random classından nesne türettik.
            byte rastgele = (byte)rnd.Next(10, 100);
            //Console.WriteLine(rastgele);
            //int tahmin;

            //do 
            //{
            //    Console.WriteLine("Tahmininizi giriniz:");
            //    tahmin = int.Parse(Console.ReadLine());

            //} while (tahmin!=rastgele);

            //Console.WriteLine("Tebrikler!");


            //1.hak=100 puan
            //2.hak=70 puan
            //3.hak=50 puan
            //Tekrar oynamak istiyormusunuz=e/h?
            //Tüm oyunlarda alınan puanların ortalaması.


            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Tahmininizi yapınız:");
                int tahmin = int.Parse(Console.ReadLine());
                if (tahmin != rastgele)
                {
                    Console.WriteLine(i != 1 ? $"Bilemediniz. {i - 1} hakkınız kaldı.." : "Oyun Bitti.");
                }
                else
                {
                    Console.WriteLine("Tebrikler Bildiniz.");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
