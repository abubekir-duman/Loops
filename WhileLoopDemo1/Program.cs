namespace WhileLoopDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("taban:");
            long taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üs:");
            long us = long.Parse(Console.ReadLine());
            long sonuc = UsAl(taban, us);
            Console.WriteLine(sonuc);

        }

        static long UsAl(long taban, long us)
        {
            long sonuc = 1;
            int i=1;
            while (i <= us)
            {
                sonuc= taban*sonuc;
                i++;

            }
            return sonuc;
        }
    }
}
