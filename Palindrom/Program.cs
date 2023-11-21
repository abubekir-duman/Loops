using System.Formats.Tar;
using System;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Palindrom:
            //    Eğer bir kelimenin düz okunuşu ile ters okunuşu birbirinin aynı ise palindromdur,
            //    değilse palindrom değildir.

            //    Örneğin 'ana' kelimesi bir palindrom iken 'baba' kelimesi bir palindrom değildir.

            //    Basit bir palindrom kontrol konsol uygulaması yazınız:

            //    1) Kullanıcı 'q' harfine basana kadar tekrar tekrar giriş yapabilir, 'q' harfine
            //    bastığında uygulamadan çıkılır.

            //    2) Kullanıcının yaptığı giriş en az iki karakter olmalıdır.
            //    3) Kullanıcı sadece harf girecek diye bir zorunluluk yoktur.
            //    4) Eğer kullanıcının girdiği kelime palindrom ise ekrana 'Girdiğiniz kelime
            //    palindromdur.', değilse 'Girdiğiniz kelime palindrom değildir.' yazılır.



            string girilenKelime;
            string kelimeninTersi;
            

            Console.Write("Lütfen bir kelime giriniz:");
            girilenKelime = Console.ReadLine();

            


            while (girilenKelime != "q" && girilenKelime != "Q")
            {
                if(girilenKelime.Length >= 2)
                {
                    kelimeninTersi = "";
                    for (int i = girilenKelime.Length - 1; i >= 0; i--)
                    {
                        kelimeninTersi += girilenKelime[i];
                    }
                    if (girilenKelime == kelimeninTersi)
                    {
                        Console.WriteLine("Girilen kelime palindromdur.");
                    }
                    else
                    {
                        Console.WriteLine("Girilen kelime palindrom değildir.");
                    }
                }
                else
                {
                    Console.WriteLine("girilen kelime en az 2 karakter olmalıdır");
                }

               
                Console.Write("Lütfen bir kelime giriniz:");
                girilenKelime = Console.ReadLine();
                

            }

           
            










        }
    }
}
