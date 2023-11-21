namespace Faktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lütfen sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Faktoriyel(sayi));
        }

         static int Faktoriyel(int sayi)
        {
            int toplam = 1;
            for (int i = 0; i < sayi; i++)
            {
                toplam += toplam * i;
            }
            return toplam;
        }
    }
}
