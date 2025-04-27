using System;
using System.Globalization;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[,] nmrs = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                for(int j = 0;j < N; j++)
                {
                    nmrs[i,j] = double.Parse(numbers[j], CultureInfo.InvariantCulture);
                }
            }
            double soma = 0.0;

            for(int i = 0;i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (nmrs[i,j] > 0)
                    {
                        soma+= nmrs[i,j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Escolha uma linha da matriz: ");

            int escolhaLinha = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");

            for(int i = escolhaLinha;i < escolhaLinha +1 ; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(nmrs[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Escolha uma coluna da matriz: ");

            int escolhaColuna = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");

            for(int i = 0; i < N; i++)
            {
                for(int j = escolhaColuna; j < escolhaColuna +1 ; j++)
                {
                    Console.Write(nmrs[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                
            }
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");
            for(int i = 0;i < N; i++)
            {
                Console.Write(nmrs[i,i].ToString("F1", CultureInfo.InvariantCulture)+" ");
            }
            Console.WriteLine();

            for(int i = 0; i < N ; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (nmrs[i,j] < 0)
                    {
                       nmrs[i,j] = Math.Pow(nmrs[i, j], 2);
                    }
                    Console.Write(nmrs[i,j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine() ;
            }
        }
    }
}