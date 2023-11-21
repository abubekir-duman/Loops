namespace WhileLoopDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const decimal KDV = 0.18m;
            decimal ucret;
            decimal toplam;
            Console.Write("Ücret:");
            string giris = Console.ReadLine();

            while (giris!="ç"&&giris!="Ç")
            {
                Console.Write("Ücret:");
                ucret = Convert.ToDecimal(giris);
                toplam = ucret + ucret * KDV;
                Console.WriteLine($"ücret:{ucret}");
                Console.WriteLine($"KDV:{KDV}");
                Console.WriteLine($"toplam:{toplam}");
                Console.Write("Ücret:");
                giris = Console.ReadLine();
            }


        }
    }
}
