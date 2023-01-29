/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] GenerateSpiralArray(int matrixsize) // можно сгенерировать квадратную спиральную матрицу любого размера
{
    int[,] matrix = new int[matrixsize, matrixsize];

    int value = 1;
    int minRow = 0;
    int maxRow = matrixsize;
    int minCol = 0;
    int maxCol = matrixsize;

    while (value <= (matrixsize * matrixsize))
    {
        for (int i = minRow; i < maxRow; i++)
        {
            matrix[minCol, i] = value;
            value++;
        }

        for (int i = minCol + 1; i < maxCol; i++)
        {
            matrix[i, maxRow - 1] = value;
            value++;
        }

        for (int i = maxRow - 2; i >= minRow; i--)
        {
            matrix[maxCol - 1, i] = value;
            value++;
        }

        for (int i = maxCol - 2; i > minCol; i--)
        {
            matrix[i, minRow] = value;
            value++;
        }

        minRow++;
        minCol++;
        maxRow--;
        maxCol--;
    }

    return matrix;
}

/* Изначально сделал так
void GenerateSpiralArray()
{
    int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 12, 13, 14, 05 }, { 11, 16, 15, 06 }, { 10, 09, 08, 07 } };

    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}*/

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int MATRIXSIZE = 4;
int[,] resultMatrix = GenerateSpiralArray(MATRIXSIZE);
PrintMatrix(resultMatrix);