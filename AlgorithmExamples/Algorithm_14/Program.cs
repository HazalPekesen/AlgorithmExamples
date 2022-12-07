namespace Algorithm_14
{
    class Program
    {
        public static bool asalmi(int sayi)
        {
            bool durum = false;
            int kontrol = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }
        static void Main(string[] args)
        {
            int sayac = 0;

        }
    }
}
