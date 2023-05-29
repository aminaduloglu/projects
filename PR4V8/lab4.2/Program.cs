using System;

namespace amina4
{
    //Выполнить возведение заданной матрицы в заданную степень при условии, что все операции
    //умножения заменяются операциями сложения, а все операции сложения – операциями поиска
    //минимального элемента между парой значений.
    internal class Program
    {
        // Метод для умножения двух матриц
        private static int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
        {
            int n = matrix1.GetLength(0);
            int[,] result = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        //Метод возведения матрицы в степень
        private static int[,] MatrixPower(int[,] matrix, int power)
        {
            int n = matrix.GetLength(0);
            int[,] result = new int[n, n];

            // Инициализируем единичную матрицу
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        result[i, j] = 1;
                    }
                    else
                    {
                        result[i, j] = 0;
                    }
                }
            }

            // Выполняем возведение матрицы в степень
            while (power > 0)
            {
                if (power % 2 == 1)
                {
                    result = MatrixMultiply(result, matrix);
                }
                matrix = MatrixMultiply(matrix, matrix);
                power /= 2;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размерность матрицы: ");
            
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            Console.Write("Введите степень возведения матрицы: ");
            int power = int.Parse(Console.ReadLine());

            // Заменяем операции умножения на операции сложения
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        matrix[i, j] = -matrix[i, j];
                    }
                }
            }

            // Выполняем возведение матрицы в степень
            int[,] result = MatrixPower(matrix, power);

            // Заменяем операции сложения на операции поиска минимального элемента
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (result[i, j] != 0)
                    {
                        result[i, j] = -result[i, j];
                    }
                }
            }

            // Выводим результат
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", result[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
