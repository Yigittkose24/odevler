namespace ödevkanguru
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Yiğit Efe Köse 253908025
            Console.WriteLine("Sırayla Kanguruların Hızını Ve Yerini Giriniz:");
            Console.WriteLine("1.Kangurunun Yeri: ");
            int place1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Kangurunun Hızı ");
            int speed1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Kangurunun Yeri: ");
            int place2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Kangurunun Hızı ");
            int speed2 = Convert.ToInt32(Console.ReadLine());

            for (int i=0;i<i*(i+1); i++)
            {
                place1 = place1 + speed1;
                place2 = place2 + speed2;
                if (place1 == place2)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(i + ". zıplayışlarında ve" + place1 + " konumunda karşılaşırlar");
                    break;
                }
                if (place1 != place2)
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
