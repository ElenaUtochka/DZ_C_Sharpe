using System;
using static System.Console;
namespace MyMetods;
public class MyClass
{
///<summary>
///4 parametrs
///</summary>
public static int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
///<summary>
///2 parametrs
///</summary>
public static int[,] CreateMatrix(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next();
        }
    }
    return result;
}


public static void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            Write($"{matrixForPrint[i, j]} ");
        }
        WriteLine();
    }
}
}
