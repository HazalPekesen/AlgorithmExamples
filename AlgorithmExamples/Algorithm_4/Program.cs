using System;

namespace Algorithm_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
             * Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */

            Console.WriteLine("bir cümle giriniz.");
            string cumle = Convert.ToString(Console.ReadLine());
            string[] kelimeler = cumle.Split(" ");

            int harfSayisi = 0;

            Console.WriteLine("Verilen cümlede {0} kelime vardır.", kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] harfDizi = kelimeler[i].ToCharArray();
                harfSayisi += harfDizi.Length;
            }
            Console.WriteLine("Verilen cümlede {0} harf vardır.", harfSayisi);
        }
    }
}
