/* Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

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

const int ROWS = 4;
const int COLUMNS = 7;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix);

int minSum = int.MaxValue; // нужно, когда цикл проходит в первый раз, потом кладем в minSum сумму элементов первой строки 
// и далее сравниваем в следующие периоды цикла с суммами элементов других строк по порядку, соответсвенно кладем туда их, 
// если они окажутся меньше. В данном случае для семи столбцов можно было присвоить значение 701
int minIndex = 0;

for (int i = 0; i < resultMatrix.GetLength(0); i++) 
{
    int sum = 0;
    for (int j = 0; j < resultMatrix.GetLength(1); j++) 
    {
        sum += resultMatrix[i, j];
    }
    
    if (sum < minSum) 
    {
        minSum = sum;
        minIndex = i;
    }
}
    
Console.WriteLine("Порядковый номер строки с наименьшей суммой элементов: " + (minIndex + 1)); // Визуальней такой вывод, по мне выглядит приятней, чем просто индекс, потому прибавил 1