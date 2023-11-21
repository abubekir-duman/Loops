namespace ForLoopDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 dışında pozitif tamasayı:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AsalMi3(sayi));

        }
        static string AsalMi(int sayi)
        {
            bool asalMi = true;
            for(int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    asalMi = false;
              
            }
            return asalMi ? "Asal" : "Asal değil";
           
        }
        static string AsalMi2(int sayi)
        {
            bool asalMi = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    asalMi = false;
                break;

            }
            return asalMi ? "Asal" : "Asal değil";

        }
        static string AsalMi3(int sayi)
        {
            bool asalMi = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0 && asalMi == true)
                {
                    asalMi = false;
                }

            }
            return asalMi ? "Asal" : "Asal değil";

        }
    }
}
