
namespace Algorithm_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci dizisi: 1,1,2,3,5,8,13,...

            int a, b = 1;
            int sonuc = 0;

            Console.WriteLine("Fibonacci dizisi kaç elemanlı olacak?");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < k; i++)  // fibonacci dizisinin 25 elemanını ekrana basacağız.
            {
                a = b;  //burada eleman kaydırma yapiyoruz.
                b = sonuc;  //burada eleman kaydırma yapiyoruz.
                sonuc = a + b;
                Console.WriteLine(sonuc);
            }

            #region DENEME

            //int k1 = 1;
            //int k2 = 1;
            //int sonucD = k1 + k2;

            //int k1 = k2;
            //int k2 = sonucD;
            //sonucD = k1 + k2;  // bu kısım döngüye girecek...

            #endregion




        }
    }
}
