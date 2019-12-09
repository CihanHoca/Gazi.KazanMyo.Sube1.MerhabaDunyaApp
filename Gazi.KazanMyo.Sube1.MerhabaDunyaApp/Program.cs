using System;

namespace Gazi.KazanMyo.Sube1.MerhabaDunyaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Renk
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            #endregion


            //string ad = "Ahmet";
            //string soyad = "Mehmet";

            //Console.WriteLine("Hoşgeldin "+ad+" "+soyad);
            //Console.WriteLine("Hoşgeldin {0} {1}", ad, soyad);
            //Console.WriteLine($"Hoşgeldin {ad} {soyad}");
            //String format
            //Placeholder-Yer tutucu


            //Type Safe-Tip Güvenliği
            //string isim = "Ali";
            //byte sayi = isim;

            //byte sayi = 5;
            //int _sayi = sayi;//Implicit Type Casting

            //checked
            //{
            //    int number = -1;
            //    byte _number = (byte)number;//Explicit Type Casting
            //    Console.WriteLine(_number); 
            //}
            //Parantez ile yapılan tür dönüşümler değer tipinden değer tipine yapılır.

            //Class'lar referans tipidir. Örn:string,object

            //int sayi = 10;
            //object objsayi = sayi;
            //Value Type->Object Type : Boxing

            //int number = (int)objsayi;
            //Object Type->Value Type : Unboxing
            //Unboxing yapılabilmesi için,daha önceden boxing yapılmış olması gerekir.

            //Console.WriteLine(number);

            //string sayi = "5";
            //byte _sayi = byte.Parse(sayi);

            //byte number = Convert.ToByte(sayi);


            //Debug-Hata Ayıklama
            //Exception
            try
            {
                Console.Write("Adınızı Giriniz:");
                string ad = Console.ReadLine();
                Console.Write("Soyadınızı Giriniz:");
                string soyad = Console.ReadLine();
                Console.Write("Yaşınızı giriniz:");

                byte yas = byte.Parse(Console.ReadLine());

                Console.WriteLine($"Hoşgeldin {ad} {soyad}\n{yas} yaşındasın.");
            }            
            catch (OverflowException)
            {              
                Console.WriteLine("0-255 arası Sayı gir!");
            }
            catch (Exception ex)
            {                
                Console.WriteLine($"Bir hata oluştu!\nTarih:{DateTime.Now}\n{ex.StackTrace}\n{ex.Message}");
            }
            Console.ReadKey();
        }


    }
}
