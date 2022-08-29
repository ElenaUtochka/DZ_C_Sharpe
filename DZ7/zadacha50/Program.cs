/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите размеры массива через пробел: ");
int[] parametrs = ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
WriteLine();
int[,] array = GetArray(parametrs[0], parametrs[1]);
PrintArray(array);
WriteLine();
WriteLine("Введите позиции элемента в двумерном массиве через пробел: ");
int[] coordinates = ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
FindElementsMatrix(coordinates, array);












int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}


void PrintArray(int[,] matrix)
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

void FindElementsMatrix(int[] coordinatesElementMatrix, int[,] matrixForSearch)
{
    if (coordinatesElementMatrix[0] < (matrixForSearch.GetLength(0) + 1) && coordinatesElementMatrix[1] < (matrixForSearch.GetLength(1)))
    {
        WriteLine($"Искомый элемент: {matrixForSearch[coordinatesElementMatrix[0], coordinatesElementMatrix[1]]}");
    }
    else
    {
        WriteLine("Элемента с такой позицией в массиве нет");
    }
}