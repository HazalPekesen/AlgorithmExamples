using System;

namespace Algorithm_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ÖDEV-7:
            //Console.WriteLine("0-7 e kadar değerler giriniz.");  //dizideki 0.indexe ulaşmak için 0-7 aralığı dedik.
            //int deger = Convert.ToInt32(Console.ReadLine());
            //string gezegenAdi = GunesSistemi(deger);
            //Console.WriteLine(gezegenAdi);
            #endregion

            //object, class, array, string (fakat string değer tipli gibi davranıyor...) -> referans tipli değişken : heap de yer kaplar. 

            //static int[] Dizi() = static Array Dizi()  -> aynı şeyi ifade eder.

            //int a = 5;
            //Console.WriteLine("birinci deneme:" + a);
            //int b = a;
            //b = 10;
            //Console.WriteLine("ikinci deneme:" + a);   // a ve b için ayrı alan tahsisleri yapıldı, çünkü değer tipli değişkenler.


            ////ref tipli değişkenlerde, atama yapıldığında farklı bir alan tahsisi yapılmaz. ortak bir alanı, referans alarak kullanırlar : ref ile bu özelliği değer tiplilerde de kullanıırz.

            //int[] sayilar = { 1, 2, 3, 4 };
            //Console.WriteLine("sayılar[0] : " + sayilar[0]);
            //int[] numbers;
            //numbers = sayilar;
            //Console.WriteLine("numbers[0] : " + numbers[0]);
            //numbers[0] = 8;
            //Console.WriteLine("sayılar[0] : " + sayilar[0]);


            //string[] sehirler = { "ist", "izmir", "ankara" };
            //Degistir(sehirler);
            //Console.WriteLine(sehirler[1]);


            //int sayi1 = 1;  //göstereceği ref değerinin verilmesi lazım.
            //refDegistir(ref sayi1);
            //Console.WriteLine(sayi1);


            //int sayi2;  //out da göstereceği out değerinin verilmesi gerekmez.
            //refDegistir2(out sayi2);
            //Console.WriteLine(sayi2);


            //string diziiii;
            //string dizi = "Merkür";
            //Gezegen(ref dizi);
            //GezegenOut(out diziiii);
            //Console.WriteLine("ref keywordü " + dizi);
            //Console.WriteLine("out keywordü " + diziiii);

            //TryParse?  Params?

            //enBuyuk(3,5);
            //enBuyuk(3,5,6);


            Console.WriteLine(Toplam(3, 4, 5, 6));
        }

        #region ÖDEV-7:
        //public static string GunesSistemi(int gezegenID)  //params?
        //{
        //    string[] gezegenler = { "merkür", "venüs", "dünya", "mars", "jupiter", "neptün", "uranüs", "satürn" };  // uzunluğu:7 
        //    return gezegenler[gezegenID];
        //}
        #endregion


        #region

        static void Degistir(string[] dizi)
        {
            dizi[1] = "antalya";
            //return "";
        }

        static void refDegistir(ref int a)
        {
            a = 5;
        }

        static void refDegistir2(out int a)
        {
            a = 5;
        }

        static void Gezegen(ref string dizi2)
        {
            dizi2 = "Venüs";
        }
        static void GezegenOut(out string dizi3)
        {
            dizi3 = "Dünya";
        }

        #endregion

        // methodun imzası: method ismi+ parametreleri!!! static, void,int , dönüş tipi vs.. değildir!!!
        // (?int a, int b) -> ? ile int a dan değer gelmeyebilir anlamına gelir!!!


        static int enBuyuk(int a, int b)
        {
            if (a > b) return a;
            return b;
        }

        static void enBuyuk(int a, int b, int c)
        {
            Console.WriteLine(4);
        }

        static int Toplam(params int[] sayilar)
        {
            int degisken = 0;
            foreach (var item in sayilar)
            {
                degisken = degisken + item;
            }
            return degisken;
        }

    }
}