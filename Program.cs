using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заполнить двумерный целочисленный массив, размером N, числами. Зеркально отобразить его содержимое по горизонтали. Вывести массив на экран до и после модификации.
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 11;
            int[,] massive = new int[N, N];
            for (int i = 0; i < N; i++)       
                for (int j = 0; j < N; j++)
                {
                    if (i <= (N / 2))
                        if (j <= (N / 2))
                        {
                            if (i == j)
                            {
                                massive[i, j] = 1;
                                continue;
                            }
                            if (i <= j)
                                if (j > 0)
                                    massive[i, j] = massive[i, j - 1] + 1;
                            if (i > j)
                                if (i > 0)
                                    massive[i, j] = massive[i - 1, j] + 1;
                        }
                    if (j > (N / 2))
                        massive[i, j] = massive[i, (N - 1) - j];
                    if (i > (N / 2))
                        massive[i, j] = massive[(N - 1) - i, j];
                }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(" " + massive[i, j]);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
        
