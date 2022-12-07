using System;

namespace Algorithm_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/

            Console.WriteLine("pozitif sayı adedi girin.");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                {
                    Console.WriteLine(sayiDizisi[i]);
                }
            }
        }
    }
}
