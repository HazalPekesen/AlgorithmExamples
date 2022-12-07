using System;

namespace Algorithm_1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region 1.örenk : sifre 123 ise çıksın, değilse döngü ile şifre istesin.
            //string sifre = "123";
            //string sifre2;
            //do
            //{
            //    Console.WriteLine("şifre girin");
            //    sifre2 = Console.ReadLine();
            //} 
            //while (sifre != sifre2);
            #endregion

            #region 2.örnek : a dan z ye harf yazdırma

            //char harf = 'a';
            //do
            //{
            //    Console.WriteLine(harf);
            //    harf++;
            //}
            //while (harf <= 'z');

            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(harf);
            //    harf++;
            //}

            #endregion

            #region 3.örnek : 4 sayı al. 1 tane sayıyı sen belirle. tutturursa programı sonlandırsın.

            //int sayi = 10;
            //int sayac = 1;
            //do
            //{
            //    Console.WriteLine("Bir sayıyı giriniz.");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    if (sayi == sayi1)
            //    {
            //        Console.WriteLine("doğru tahmin!");
            //        break;
            //    }
            //    sayac++;
            //}
            //while (sayac < 5);

            //if (sayac >= 5)
            //{
            //    Console.WriteLine("tahmin tükendi...");
            //}

            #endregion

            #region DİZİLER

            //int[] dizi1 = new int[50]; // 50 elemanlı dizi. bellekte 50 birimlik alan ayrılır, ekstra eleman ekleyemezsin.
            //int[] dizi2 = { 4, 2, 3 };  //bunlar tek boyutlu dizidir. atama yapılmadıysa tüm elemanlar int için 0 olur.
            //int[,] dizi3 = new int[50, 20];  //iki boyutlu bir dizi.
            //dizi1[0] = 1;
            //Console.WriteLine(dizi1[0]);

            //boyutu belirsiz ise liste kullan.

            //Array.Sort(dizi2);  // cw ile diziyi yazdıramayabiliriz.!!!!
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(dizi2[i]);
            //}

            //Array.Copy(dizi2, dizi1, 2);

            //Array.Reverse(dizi2);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(dizi2[i]);
            //}

            #endregion

            #region ÖDEV : klavyeden 7 tane sayı gireceğiz. Sayıları sort kullanmadan kendi algoritmamız ile küçükten büyüğe sıralayacağız.
            #endregion

            #region 50 boyutlu bir dizinin her indexine 1 den 10 a kadar olan random sayıları atayacağız. 1-10 arasında hangi sayılardan kaç tane kullandığını ekrana yazsın.

            //int[] dizi = new int[50];
            //Random random = new Random();
            //int sayi;
            //string yildiz = "*";

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = random.Next(10);
            //}

            //for (int i = 1; i < 11; i++)
            //{
            //    sayi = 0;
            //    yildiz = "";
            //    for (int k = 0; k < 50; k++)
            //    {
            //        if (i == dizi[k])
            //        {
            //            sayi++;
            //            yildiz = yildiz + "*";
            //        }
            //    }
            //    Console.WriteLine("{0} adet, {1,10} \t sayisindan bulunmaktadır. -> {2,3}", sayi, i, yildiz);
            //}

            #endregion

            #region  break, continue, return 

            //int sayi = 1;
            //while (true)
            //{
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 20)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("içerik sonlandırıldı.");



            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("ilk adım");
            //    continue;
            //    Console.WriteLine("ikinci adım");
            //}


            //for (int i = 0; i < 50; i++)   // 21 dışında 50'ye kadar tüm sayıları yaz.
            //{
            //    if (i == 21)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i < 50; i++)   // 21 den sonra program kendini kapatır.
            //{
            //    if (i == 21)
            //    {
            //        return;   //metotun değerini geri döndürür normalde fakat burada programı sonlandırır.
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion

            #region ÖDEV : 

            //sayı girelim, bu sayıları diziye atayalım. Bu elemanları ekrana yazdır.
            //Tekrar aynı girdiğimiz sayıları bize göstermesin. for, continue .100 yazarsak, 100 ve 100 den sonra yazdığımız hiçbir şeyi
            //ekrana yazdırmayalım


            int[] dizi = new int[5];
            int sayi;

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz.", i);
                sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("girdiğiniz sayı: " + sayi.ToString());
                dizi[i] = sayi;
            }

            foreach (var item in dizi)
            {
                Array.Sort(dizi);
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.WriteLine(dizi[0]);
                    if (dizi[i] == dizi[0])
                    {
                        Console.WriteLine("aynı sayılar eklenmiş");
                    }
                }

                //ilk elemannı her zaman yazdır.
                //5=5 ise break; 1. fordan çık
            }

            #endregion


        }
    }
}
