using System;

namespace Algorithm_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region örnek-1
            ////klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 tl den fazla ise 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulama yapınız.
            //Console.Write("İlk ürünün fiyatını giriniz: ");
            //int birinciUrunFiyatı = int.Parse(Console.ReadLine());
            //Console.Write("İkinci ürünün fiyatını giriniz: ");
            //int ikinciUrunFiyatı = int.Parse(Console.ReadLine());
            //int toplamFiyat = birinciUrunFiyatı + ikinciUrunFiyatı;
            //if (toplamFiyat > 200)
            //{
            //    Console.WriteLine(toplamFiyat * (75 / 100));
            //}
            //else
            //{
            //    Console.Write(toplamFiyat);
            //}
            #endregion

            #region örnek-2

            ////Belirlenen kullanıcı adı ve şifre doğru girildiğinde "giriş başarılı",
            ////yanlış girildiğinde "girdiğiniz kul. adı veya şifre hatalı" mesajı veren console uyg. yapin.
            //Console.WriteLine("Lütfen kullanıcı adınızı yazınız.");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Lütfen şifrenizi giriniz.");
            //string sifre = Console.ReadLine();

            //if (kullaniciAdi == "hzl" && sifre == "12345")
            //    Console.WriteLine("Giriş başarılı...");
            //else
            //    Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı.");

            ////tam tersi şekilde de yazabiliriz. yani tersine mantık.
            ////if (!(kullaniciAdi == "hzl" && sifre == "12345"))
            ////    Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı.");           
            ////else
            ////    Console.WriteLine("Giriş başarılı...");

            ////ternary operatörü de kullanılabilir: (veya swtich case)
            ////Console.WriteLine(kullaniciAdi == "hzl" && sifre == "12345" ? "Giriş Başarılı" : "Girdğiniz kul. adı veya şifre hatalı.");

            #endregion

            #region örnek-3

            ////kullanıcıdan alınan iki sayının ve yapılacak işlem türünün seçilmesiyle sonucu hesaplayan programı yazalım.

            //Console.WriteLine("1.sayıyı giriniz.");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz.");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen yapılacak işlemi belirtiniz (+,-,*,/) ");
            //char islem = char.Parse(Console.ReadLine());

            //if (islem == '+')
            //{
            //    Console.WriteLine(sayi1+sayi2);
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine(sayi1 - sayi2);
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine(sayi1 / sayi2);
            //}
            //else  
            //{
            //    Console.WriteLine(sayi1 * sayi2);
            //}

            //switch ile de yapilir.

            //switch (islem)
            //{
            //    case '+':
            //        Console.WriteLine(sayi1 +sayi2);
            //        break;

            //    case '-':
            //        Console.WriteLine(sayi1 - sayi2);
            //        break;

            //    case '*':
            //        Console.WriteLine(sayi1 * sayi2);
            //        break;

            //    default:
            //        Console.WriteLine(sayi1 / sayi2);
            //        break;
            //}

            //pattern ile de yapilabilir.

            //int sonuc = islem switch
            //{
            //    '+' => sayi1 + sayi2,
            //    '-' => sayi1 - sayi2,
            //    '*' => sayi1 * sayi2,
            //    //'/' => sayi1 / sayi2
            //    '_' => sayi1 / sayi2
            //};
            //Console.WriteLine(sonuc);


            ////ternart operatörü ile de yapılabilir.

            //Console.WriteLine(islem == '+' ? sayi1 + sayi2 : (islem == '-' ? sayi1 - sayi2 : (islem == '*' ? sayi1 * sayi2 :  sayi1 / sayi2 )));

            #endregion

            #region örnek-4

            //girilen sayının değeri 10 değilse ekrana 'sayı yanlış' yazsın.

            //int sayi = int.Parse(Console.ReadLine());

            ////kritik-1
            //if (sayi==10)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış!");
            //}

            //kritik-2
            //if (sayi != 10)
            //{
            //    Console.WriteLine("sayı yanlış!");
            //}

            //kritik-3-ternary operatörü

            //Console.WriteLine(sayi == 10 ? "" : "sayı yanlış!");

            #endregion

            #region örnek-5

            //girilen sayının negatif ya da pozitif olduğunu gösteren uygulamayı yazalım.

            int sayi = int.Parse(Console.ReadLine());
            string sonuc = ""; //akış mekanizması dışına da bu mekanizma içinde alınan sonucu yazdırabilmek için!!
            if (sayi < 0)
                //Console.WriteLine("negatif");
                sonuc = "Negatif";
            else
                //Console.WriteLine("pozitif");
                sonuc = "Pozitif";
            Console.WriteLine(sonuc);

            bool? b = true;
            int? c;

            //ÇOK ÖNEMLİ!!!!!!!!!!!
            // belirli şartlara göre çalışılan kodlarda,
            //içeride üretilen değerin 
            //if , switch, else-if gibi.. akış kontrol mekanizmalarından
            //dışarı çıkarılabilmesi için
            //başta tanımlanan bir değişkene içeride değer atanmalı.

            #endregion

            //todo hazal bunu görmeli.

        }
    }
}
