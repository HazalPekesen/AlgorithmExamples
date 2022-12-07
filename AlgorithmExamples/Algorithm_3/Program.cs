using System;

namespace Algorithm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
             * Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
             * Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
             */

            Console.WriteLine("pozitif bir sayı girin. (n)");
            int n = int.Parse(Console.ReadLine());
            string[] kelimeDizisi = new string[n];
            for (int i = 0; i < n; i++)  //oluşturulan dizide n adet kelime var.
            {
                Console.WriteLine("lütfen {0}. kelimeyi giriniz.", i + 1); //kullanıcıdan n adet sayı alıyoruz.
                kelimeDizisi[i] = Convert.ToString(Console.ReadLine());
            }
            foreach (var kelime in kelimeDizisi)
            {
                Console.WriteLine(kelime);
            }
            Console.WriteLine("*****************************");
            Array.Reverse(kelimeDizisi);
            foreach (var kelime in kelimeDizisi)
            {
                Console.WriteLine(kelime);
            }
        }
    }
}
