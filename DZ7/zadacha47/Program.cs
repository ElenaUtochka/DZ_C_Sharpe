/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите через пробел размеры массива: ");
int[] parametrs = ReadLine()!.
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(x => int.Parse(x)).
                ToArray();
double[,] array = GetArray(parametrs[0], parametrs[1]);
PrintArray(array);












double[,] GetArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(), 1);
        }
    }
    return result;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}

