namespace ödevmatris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev Yiğit Efe Köse 253908025    Gece saat 02:14 githuba yükleyemediğim için sabah atacağım  
            #endregion
            int[,] dizi = new int[5,3];

            Random rnd = new Random();
            Console.WriteLine("Üretilen Matris;");
            for (int i = 0; i < 5; i++)
            {

                Console.Write("[");
                for (int j = 0; j < 3; j++)
                {
                    dizi[i, j] = rnd.Next(1, 10);
                    Console.Write(dizi[i, j] + " ");
                    if (j < 2)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine("]");
            }    
            
            int number1 =0 , number2 = 0 , number3 = 0 ;
            for ( int i = 0;i<5;i++)
            {
              
                
                number1 += dizi[i, 0];
                number2 += dizi[i, 1];
                number3 += dizi[i, 2];
            }
            Console.WriteLine();
            Console.WriteLine("Üretilen Sütunların Toplamı:");
            Console.WriteLine("1.Sütunun Toplamı: "+ number1);
            Console.WriteLine("2.Sütunun Toplamı: " + number2);
            Console.WriteLine("3.Sütunun Toplamı: " + number3);



        }
    }
}