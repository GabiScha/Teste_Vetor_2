using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2_pg72
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Escreva o vetor correspondente a " + i);
                vetor[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            for (int i = 0; i < 20; i++)
            {
                if (int.Parse(vetor.GetValue(i)) > 50)
                {
                   Console.WriteLine("O vetor " + i + " coresponde a " + vetor.GetValue(i));
                }

            }

            Console.ReadKey();





        }
    }
}
