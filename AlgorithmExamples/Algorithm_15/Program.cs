
namespace Algorithm_15
{
    class Program
    {
        static void Main(string[] args)
        {

            //1//Girilen pozitif herhangi bir tam sayıyı ikilik düzene çeviren program:
            //string mod = "";
            //Console.WriteLine("Lütfen ikilik sisteme dönüştürüşmesini istediğiniz sayıyı girin:");
            //float a = Convert.ToSingle(Console.ReadLine());
            //int b = (int)a;
            //if (a <= 0 || a != b)
            //{
            //    mod = "Bir pozitif tamsayı girmediğiniz için sayınız ikilik sisteme dönüştürülemedi";
            //}
            //else
            //{
            //    for (; b > 0; b /= 2)
            //        mod = b % 2 + mod;
            //    Console.WriteLine(mod);
            //}
            //Console.ReadLine();

            /***************************************************************************/

            //2//Konsol ekranına girilen 0 ile 100 (sınırlar dâhil) arasındaki 
            //10 notun en büyüğünü, en küçüğünü ve ortalamasını yazan program:
            //int bs = 0, toplam = 0, ks = 0;
            //for (int a = 0, b; a < 10; a++)
            //{
            //    Console.WriteLine(a+1+".notu giriniz:");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    if (b>100||b<0)
            //    {
            //        Console.WriteLine("Yanlış notu girdiniz.Lütfen tekrar deneyin.");
            //        a--;
            //        continue;
            //    }
            //    if (a==0)
            //    {
            //        bs = b;
            //        ks = b;
            //    }
            //    else
            //    {
            //        if (b > bs)
            //            bs = b;
            //        if (b < bs)
            //            ks = b;
            //    }
            //    toplam += b;
            //}
            //Console.WriteLine("En büyük: {0}\nEn küçük: {1}\nOrtalama:"+toplam/10,bs,ks);
            //Console.ReadLine();

            /***************************************************************************/

            //3//
            //Rastgele sayı üretebilmemiz için öncelikle Random sınıfı türünden bir nesne yaratmalıyız:
            //Random rnd = new Random();
            //Buradaki yarattığımız nesnenin adı rnd.
            //Şimdi bu nesne üzerinden Random sınıfının metotlarına erişebileceğiz.
            //int RastgeleSayi1 = rnd.Next(10, 20);  //10 ile 20 arasında int türden rastgele bir sayı üretilir, 10 dâhil ancak 20 dâhil değildir.
            //int RastgeleSayi2 = rnd.Next(50);  //0 ile 50 arasında int türden rastgele bir sayı üretilir, 0 dâhil ancak 50 dâhil değildir.
            //int RastgeleSayi3 = rnd.Next();    //int türden pozitif herhangi bir sayı üretilir.
            //double RastgeleSayi4 = rnd.NextDouble(); //double türden 0.0 ile 1 arasında rastgele bir sayı üretilir.

            /***************************************************************************/

            //4//Kullanıcı 0 girene kadar girdiği çift sayıların sayısını ekrana yazdıran program:
            //int sayi, sayac = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayıyı Giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        //sayac++; //0 ı saysın ya da saymasın
            //        break;
            //    }
            //    else if (sayi % 2 == 0)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("{0} ADET ÇİFT SAYI GİRDİNİZ.", sayac);
            //Console.ReadKey();

            /***************************************************************************/
            //5//Kullanıcının girdiği 5 sayıdan
            //kaç tane çift kaç tane tek sayı girdiğini yazdıran program:
            //int sayi, sayac1 = 0, sayac2 = 0;
            //for (int a = 1; a <= 5; a++)
            //{
            //    Console.WriteLine("{0}.Sayıyı giriniz:", a);
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if(sayi % 2 == 0)
            //    {
            //        sayac1++;
            //    }
            //    else if(sayi % 2 != 0)
            //    {
            //        sayac2++;
            //    }
            //}
            //Console.WriteLine("{0} ADET ÇİFT SAYI GİRDİNİZ.", sayac1);
            //Console.WriteLine("{0} ADET TEK SAYI GİRDİNİZ.", sayac2);
            //Console.ReadKey();

            /***************************************************************************/

            //6//Kullanıcı 0 girene kadar kullanıcının girdiği sayıyı ekrana yazan program:
            //int sayi = 1;   //Burada int sayi; diyemiyoruz.
            //while (sayi != 0)
            //{
            //    Console.WriteLine("Bir Sayı Girin:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girdiğiniz sayı={0}",sayi);
            //}

            /***************************************************************************/

            //7//Kullanıcı negatif sayı girene kadar girdiği sayıların toplamını ekrana yazdıran program:
            //int sayi = 29, toplam = 0;
            //while (sayi>=0)
            //{
            //    Console.WriteLine("Bir sayı giriniz...");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi>0)
            //    {
            //        toplam += sayi;
            //    }
            //}
            //Console.WriteLine("Girdiğiniz sayıların toplamı= {0}", toplam);
            //Console.ReadKey();

            /*Yukarıdaki örneğin farklı bir versiyonu:*/

            //int sayi, toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz..");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi < 0)
            //    {
            //        break;
            //    }
            //    toplam += sayi;
            //}
            //Console.WriteLine("Girdiğiniz sayıların toplamı:{0}", toplam);
            //Console.ReadKey();

            /*********************************************************************/

            //0 ile 10 arasında rasgele seçilen sayıyı tahmin ettiren program

            int bizimsayi, rasgelesayi;
            Random rasgele = new Random();
            rasgelesayi = rasgele.Next(10);
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz 0-10 arası----->");
                bizimsayi = Convert.ToInt32(Console.ReadLine());
                if (bizimsayi == rasgelesayi)
                {
                    Console.WriteLine("Bildiniz..");
                    break;
                }
            }
            Console.ReadKey();

            /****************************************************************/

        }
    }
}
