using System;

namespace Algorithm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
             * Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.            
             */

            Console.WriteLine("Bir pozitif sayı girin. (n)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir pozitif sayı girin. (m)");
            int m = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[n]; //n uzunluklu bir dizi oluşturuldu.

            for (int i = 0; i < n; i++)  //n adet sayı girildi.
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] % m == 0)
                {
                    Console.WriteLine(sayiDizisi[i] + ", m sayısına tam bölünmektedir.");
                }
                else if (sayiDizisi[i] == m)
                {
                    Console.WriteLine(sayiDizisi[i] + ", m sayısına eşittir.");
                }
            }
        }
    }
}