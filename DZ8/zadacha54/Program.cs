/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */

using static System.Console;
using System.Linq;
using MyMetods;

Clear();

WriteLine("Введите размеры массива через пробел: ");
int[] parametrs = ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
int[,] array = MyClass.CreateMatrix(parametrs[0], parametrs[1], 1, 10);
MyClass.PrintMatrix(array);
WriteLine();
SortMatrix(array);
MyClass.PrintMatrix(array);





void SortMatrix(int[,] matrixForSort)
{
    for (int i = 0; i < matrixForSort.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForSort.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrixForSort.GetLength(1); k++)
            {
                if (matrixForSort[i, j] < matrixForSort[i, k])
                {
                    int temp = matrixForSort[i, j];
                    matrixForSort[i, j] = matrixForSort[i, k];
                    matrixForSort[i, k] = temp;
                }
            }
        }
    }
}