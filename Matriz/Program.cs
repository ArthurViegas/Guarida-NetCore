namespace Program
{
    using System;
    public static class MatrixUtils
    {
        public static void Main()
        {
            int[,] matrizA = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matrizB = { { 7, 8 }, { 9, 10 }, { 11, 12 } };

            try
            {
                int[,] result = MultiplyMatrix(matrizA, matrizB);

                Console.WriteLine("Matriz:");
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        Console.Write(result[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        private static int[,] MultiplyMatrix(int[,] matrizA, int[,] matrizB)
        {
            int lineA = matrizA.GetLength(0);
            int colA = matrizA.GetLength(1);
            int lineB = matrizB.GetLength(0);
            int colB = matrizB.GetLength(1);

            if (colA != lineB)
                throw new ArgumentException("As matrizes não podem ser multiplicadas.");

            int[,] result = new int[lineA, colB];

            for (int i = 0; i < lineA; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    for (int k = 0; k < colA; k++)
                    {
                        result[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }

            return result;
        }
    }
}
