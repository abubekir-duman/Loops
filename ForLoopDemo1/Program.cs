﻿namespace ForLoopDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Başlangıç sayısı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş sayısı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tek sayılar toplamı için (t),çift sayılar toplamı için (ç) girilmelidir.");
            string secim = Console.ReadLine();

            int toplam = 0;

            for(int i = sayi1; i < sayi2; i++)
            {
                if (i % 2 != 0 && secim == "t")
                    toplam += i;
                else if (i % 2 == 0 && secim == "ç")
                    toplam += i;
            }
            string mesaj = secim == "t" ? "tek sayılar toplamı" : secim == "ç" ? "çift sayılat toplamı" : "";
            if (mesaj == "")
                Console.WriteLine("tek sayılar için (t),çift sayılar için (ç) girilmelidir.");
            else
                Console.WriteLine(mesaj + ":" + toplam);
        }
    }
}
