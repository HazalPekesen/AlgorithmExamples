using System;

namespace Algorithm_8
{
    class Program
    {
        static void Main(string[] args)
        {

            //kullanıcıya kaç tane sayıyı toplayacağını sorup,
            //kullanıcının toplayacağı kadar sayıyı kullanıcıya tek tek soran
            //ve kullanıcının yazdığı bu sayıların toplamını ekrana yazdıran program.

            int sayi, adet, toplam = 0;
            Console.WriteLine("Kaç sayı toplayacaksın?");
            adet = int.Parse(Console.ReadLine());
            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine(i + ".sayıyı giriniz.");
                sayi = int.Parse(Console.ReadLine());
                toplam = toplam + sayi;
            }
            Console.WriteLine("girdiğiniz sayıların toplamı:" + toplam);
        }
    }
}
