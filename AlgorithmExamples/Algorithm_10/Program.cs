using System;

namespace Algorithm_10
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ORNEK-1: n elemanlı bir dizi. diziye random sayılar ata. bu atanan sayıların ortalamasını bul.

            //Console.WriteLine("dizinin eleman sayısını giriniz.");
            //int n = int.Parse(Console.ReadLine());
            //int[] dizi = new int[n];
            //Random random = new Random();
            //int sayac = 0;
            //double toplam = 0;
            //foreach (var item in dizi)
            //{
            //    int sayi = random.Next(130);
            //    dizi[sayac] = sayi;
            //    Console.WriteLine(dizi[sayac]);
            //    toplam += dizi[sayac];
            //    sayac++;
            //}
            //Console.WriteLine(toplam / n);

            #endregion

            #region ORNEK-2: klavyeden girilen cümlenin kaç kelimeden oluştuğunu bulan program.

            //Console.WriteLine("cümle girin.");
            //string cumle = Console.ReadLine();
            //cumle.Split(" ");
            //string[] metindizi = cumle.Split(" ");
            //int a = 0;
            //foreach (var item in metindizi)
            //{
            //    a++;
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("kullanılan kelime sayısı:" + a);

            #endregion

            #region ORNEK-3:  while döngüsü ile asal sayı kontrolü yap. bir adet asal girerse döngü kapansın.

            //while (true)
            //{
            //    Console.WriteLine("sayı girin.");
            //    int sayi = int.Parse(Console.ReadLine());
            //    int kontrol = 0;
            //    for (int i = 2; i < sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            kontrol++;
            //        }
            //    }
            //    if (kontrol != 0)
            //    {
            //        Console.WriteLine("asal değil.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("asal");
            //        break;
            //    }
            //}

            #endregion

            #region ORNEK-4: KLAVYEDEN GİRİLEN SAYIYA KADAR 3 E VE 5 E BÖLÜNEN SAYILARI YAZ.  // Burada else kullanamadım???

            Console.WriteLine("sayı girin.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            #endregion  
        }
    }
}
