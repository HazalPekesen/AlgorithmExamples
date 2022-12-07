using System;

namespace Algorithm_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV-2
            Console.WriteLine("1. kişinin ismini giriniz:");
            string isim1 = Console.ReadLine();
            Console.WriteLine("1. kişinin yaşını giriniz:");
            int yas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("1. kişinin ağırlığınızı giriniz:");
            double agır1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2. kişinin ismini giriniz:");
            string isim2 = Console.ReadLine();
            Console.WriteLine("2. kişinin yaşını giriniz:");
            int yas2 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. kişinin ağırlığınızı giriniz:");
            double agır2 = double.Parse((Console.ReadLine()));

            if (yas1 > yas2)
            {
                Console.WriteLine(isim1 + ", " + isim2 + " den daha büyüktür.");
            }
            else if (yas2 > yas1)
            {
                Console.WriteLine(isim2 + ", " + isim1 + " den daha büyüktür.");
            }
            else
            {
                Console.WriteLine(isim1 + " ve " + isim2 + " aynı yaştadır.");
            }
            Console.WriteLine(isim1 + " ve " + isim2 + " nin yaş ortalamaları:" + ((yas1 + yas2) / 2));
            Console.WriteLine(isim1 + " ve " + isim2 + " nin yaşları toplamı:" + (yas1 + yas2));

            if (agır1 > agır2)
            {
                Console.WriteLine(isim1 + ", " + isim2 + " den daha ağırdır");
            }
            else if (agır2 > agır1)
            {
                Console.WriteLine(isim2 + ", " + isim1 + " den daha ağırdır");
            }
            else
            {
                Console.WriteLine(isim1 + " ve " + isim2 + " aynı ağırlıktadır.");
            }
            Console.WriteLine(isim1 + " ve " + isim2 + " nin ağırlıkları ortalamaları:" + ((agır1 + agır2) / 2));
            Console.WriteLine(isim1 + " ve " + isim2 + " nin ağırlıkları toplamı:" + (agır1 + agır2));
        }
    }
}
