/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
using static System.Console;
Clear();
/* int countRows = 3;
int countColumns = 4; */
int[,] array = CreateMatrix(3, 4);
PrintMatrix(array);
FindArithmeticMean(array);







int[,] CreateMatrix(int rows, int columns)
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

void PrintMatrix(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Write($"{arrayForPrint[i, j]} ");
        }
        WriteLine();
    }
}

void FindArithmeticMean(int[,] matrixForSearch)
{
    string result = "Среднее арифметическое каждого столбца: ";
    for (int j = 0; j < matrixForSearch.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrixForSearch.GetLength(0); i++)
        {
            sum += matrixForSearch[i, j];
        }
        if (j != matrixForSearch.GetLength(1) - 1)
        {

            result += Math.Round((double) sum / matrixForSearch.GetLength(0),1) + "; ";
        }
        else
        {
            result += Math.Round((double) sum / matrixForSearch.GetLength(0),1) + ".";
        }
    }
    WriteLine($"{result}");
}