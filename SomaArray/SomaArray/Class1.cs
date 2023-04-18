using System;
using System.Runtime.InteropServices;

namespace SomaArray
{
    public class Somar
    {
        public int SumArray(int[] source)
        {

            int sum = 0;

            //Função para executar as querys paralelamente, para melhorar a eficiencia em calculos maiores
            if (source.Length >= 600000)
            {
                sum = source.AsParallel().Sum(x => (int)x);

                return sum;
            }
            else
            {

                foreach (var i in source)
                {
                    sum += i;
                }

                return sum;
            }
        }
    }
}