using System;

namespace Algorithm_6
{
    class Program
    {
        //Girilen bir sayının asal olduğunu bulan ve
        //bu sayıdan sonraki 5 asal sayıyı ekrana yazan program:

        public static bool asalMi(int sayi)
        {
            bool durum = false;

            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }

            if (kontrol == 1)
            {
                durum = false;
            }

            else
            {
                durum = true;
            }

            return durum;
        }

        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("sayi girin:");
            int s = int.Parse(Console.ReadLine());

            if (asalMi(s))
            {
                Console.WriteLine("{0} sayısı ASAL.", s);
            }

            else
            {
                Console.WriteLine("{0} sayısı ASAL DEĞİL.", s);
            }

            Console.WriteLine("***sonraki 5 asal sayı****");

            while (true)
            {
                s++;
                if (asalMi(s) == true)
                {
                    Console.WriteLine("{0} sayısı ASAL.", s);
                    sayac++;
                    if (sayac == 5)
                    {
                        break;
                    }
                }
            }

        }
    }
}
