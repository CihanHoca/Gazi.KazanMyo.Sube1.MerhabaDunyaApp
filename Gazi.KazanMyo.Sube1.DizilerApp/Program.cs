using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.Sube1.DizilerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] dizi = new int[3];
            ////dizi:referans
            //dizi[0] = 5;
            //dizi[1] = 8;
            //dizi[2] = 11;

            //int[] dizi = {92,106,8,10,25,45,85};

            //Array.Sort(dizi);
            //Console.WriteLine(dizi[0]);
            //Console.WriteLine(dizi[1]);
            //Console.WriteLine(dizi[2]);

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //Console.WriteLine("Kaç isim girmek istiyorunuz?");
            //byte adet = byte.Parse(Console.ReadLine());
            //string[] isimler = new string[adet];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.Write($"{i + 1}.İsim Giriniz:");
            //    isimler[i] = Console.ReadLine();
            //}
            //Array.Sort(isimler);
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //Console.WriteLine("Başlangıç giriniz:");
            //byte bas = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş giriniz:");
            //byte bit = byte.Parse(Console.ReadLine());

            //int[] dizi = new int[10];

            //Random rnd = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    dizi[i] = rnd.Next(bas, bit);
            //}
            //Array.Sort(dizi);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            //Random rnd = new Random();
            //int[,] dizi = new int[5, 3];

            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        dizi[i, j] = rnd.Next(100);
            //    }
            //}


            //dizi[0, 0] = 18;
            //dizi[0, 1] = 19;
            //dizi[0, 2] = 12;
            //dizi[1, 0] = 10;

            //Console.WriteLine("Satır sayısı giriniz:");
            //int satir = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sütün sayısı giriniz:");
            //int sutun = int.Parse(Console.ReadLine());

            //string[,] dizi = new string[satir, sutun];

            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        dizi[i, j] = (i + j) % 2 == 0 ? "*" : " ";
            //    }
            //}

            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write(dizi[i,j]);
            //    }
            //    Console.WriteLine();
            //}


            //*
            //**
            //***
            //****
            //*****

            Console.WriteLine("Kaç satır?");
            int satir = int.Parse(Console.ReadLine());

            string[,] dizi = new string[satir, satir];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < length; j++)
                {

                }
            }




            Console.ReadKey();
        }
    }
}
