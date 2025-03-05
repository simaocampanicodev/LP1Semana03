using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            if (args.Length != 6)
            {
                Console.WriteLine("Erro: Devem ser fornecidos exatamente 6 argumentos.");
                return;
            }

            float arg1 = float.Parse(args[0]);
            float arg2 = float.Parse(args[1]);
            float arg3 = float.Parse(args[2]);
            float arg4 = float.Parse(args[3]);
            float arg5 = float.Parse(args[4]);
            float arg6 = float.Parse(args[5]);

            float[,] A = { { arg1, arg2 }, { arg3, arg4 } };

            float[] b = { arg5, arg6 };

            float[] result = new float[2];

            for (int i = 0; i < 2; i++)
            {
                result[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * b[j];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {result[i],7:F2} |");
            }
        }
    }
}