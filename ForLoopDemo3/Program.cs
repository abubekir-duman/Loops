namespace ForLoopDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 65; i <=90; i++)
            //{
            //    Console.WriteLine((char)i + " ");
            //}

            //for(char c = 'A'; c <= 'Z'; c++)
            //{
            //    Console.WriteLine(c + " ");
            //}

            for(char c = 'A';c <= 'z'; c++)
            {
                if (c <= 'z')
                {
                    Console.WriteLine(c +" ");
                }
                else if(c >= 'a')
                {
                    Console.WriteLine(c +" ");
                }
            }
        }
    }
}
