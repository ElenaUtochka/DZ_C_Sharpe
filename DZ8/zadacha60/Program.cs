/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
using static System.Console;
using System.Linq;
using MyMetods;
Clear();

WriteLine("Введите размеры трехмерного массива через пробел: ");
int[] parametrs = ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
if (parametrs[0] * parametrs[1] * parametrs[2] > 90)
{
    WriteLine("Массив не может быть сформирован без повторения значений элементов");
    return;
}
int[,,] cubeArray = CreateCubeMatrix(parametrs[0], parametrs[1], parametrs[2]);
WriteLine();
PrintCubeMatrix(cubeArray);













int[,,] CreateCubeMatrix(int rows, int columns, int faces)
{
    int[] tempArray = new int[rows * columns * faces];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(10, 100);
        int temp = tempArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 100);
                    j = 0;
                    temp = tempArray[i];
                }
                temp = tempArray[i];
            }
        }
    }
    int count = 0;
    int[,,] result = new int[rows, columns, faces];
    for (int k = 0; k < rows; k++)
    {
        for (int l = 0; l < columns; l++)
        {
            for (int m = 0; m < faces; m++)
            {
                result[k, l, m] = tempArray[count];
                count++;
            }
        }
    }

    return result;
}


void PrintCubeMatrix(int[,,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(2); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            for (int k = 0; k < matrixForPrint.GetLength(0); k++)
            {
                Write($"{matrixForPrint[j, k, i]}({j},{k},{i}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}