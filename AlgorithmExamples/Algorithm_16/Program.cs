namespace Algorithm_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100 ; i++)  //1 den 100 (dahil) e kadar olan sayıları yazdırdık. // for(başlangıç;şart;artış)
            //{

            //    Console.WriteLine(i);
            //}

            //****************************************************************************

            //for (int i = 0; i <= 100 ; i+= 2) // 0 dan 100 e kadar olan çift sayıları yazdırdık. // i+2 ile i=i+2 aynı şey!!!
            //{
            //    Console.WriteLine(i);
            //}

            //*******************************************************************************

            //for (int i = 1; i <= 100; i+= 2)  // 0 dan 100 e kadar olan tek sayıları yazdırdık.
            //{
            //    Console.WriteLine(i); 
            //}

            //********************************************************************************

            //forLoop();

            //WhileLoop();

            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
            Console.ReadLine();

        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;  // sayıyı bir azalttık              
            }

            Console.WriteLine("Now number is {0}", number);
            Console.ReadLine();
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i -= 2)    // 100 den geriye çift sayıları yazdırdık.
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");
        }
    }
}
