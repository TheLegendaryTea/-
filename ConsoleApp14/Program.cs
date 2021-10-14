using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите k");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите l");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите n");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите m");
                int m = int.Parse(Console.ReadLine());
                //для проверки вводить k=1 l=1 n=4 m=6
                if (k > 0)
                {
                    if (2 * m > l)
                    {
                        if (n > 2 * l)
                        {
                            int S = k + l + m + n; Console.WriteLine("Истина");
                        }
                        else Console.WriteLine("Ложь n<2*l");
                    }
                    else Console.WriteLine("Ложь 2*m<l");
                }
                else Console.WriteLine("Ложь k<0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


        }
    }
}
