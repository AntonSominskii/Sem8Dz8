/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] GetRandomMatrix(int matrixsize, int leftRange, int rightRange) // создаем квадратную мартицу
{
    int[,] matrix = new int[matrixsize, matrixsize];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int MATRIXSIZE = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] resultMatrix1 = GetRandomMatrix(MATRIXSIZE, LEFT_RANGE, RIGHT_RANGE);
int[,] resultMatrix2 = GetRandomMatrix(MATRIXSIZE, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix1);
Console.WriteLine();
PrintMatrix(resultMatrix2);
int[,] multiplyMatrix = new int[MATRIXSIZE, MATRIXSIZE]; // Сюда сохраним результат цикла
Console.WriteLine("\nПроизведение двух матриц:" + "\n");

for (int i = 0; i < MATRIXSIZE; i++)
{
    for (int j = 0; j < MATRIXSIZE; j++)
    {
        multiplyMatrix[i, j] = 0;
        for (int k = 0; k < MATRIXSIZE; k++)
        {
            multiplyMatrix[i, j] += resultMatrix1[i, k] * resultMatrix2[k, j];
        }
    }
}

PrintMatrix(multiplyMatrix);