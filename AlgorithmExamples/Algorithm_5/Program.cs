using System;

namespace Algorithm_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen 3 basamaklı sayının basamaklarına ayıran örnek.(birler, onlar,yüzler basamağındaki sayılar)
            Console.WriteLine("3 basamaklı sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());

            int yuzler = sayi / 100;
            sayi = sayi - (yuzler * 100);
            int onlar = sayi / 10;
            sayi = sayi - (onlar * 10);
            int birler = sayi;
            Console.WriteLine("yüzler basamağı: {0}", yuzler);
            Console.WriteLine("onlar basamağı: {0}", onlar);
            Console.WriteLine("birler basamağı: {0}", birler);


            //Girilen 2 basamaklı sayının basamaklarına ayıran örnek.(birler, onlar,yüzler basamağındaki sayılar)
            Console.WriteLine("2 basamaklı sayı giriniz.");
            int sayi1 = int.Parse(Console.ReadLine());

            int onlar1 = sayi1 / 10;
            sayi1 = sayi1 - (onlar1 * 10);
            int birler1 = sayi1;
            Console.WriteLine("onlar basamağı: {0}", onlar1);
            Console.WriteLine("birler basamağı: {0}", birler1);
        }
    }
}
