/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2 sum=14
5 9 2 3 sum=19
8 4 2 4 sum=18
5 2 6 7 sum=20
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */


using static System.Console;
using MyMetods;
using System.Linq;
Clear();

WriteLine("Введите размеры массива через пробел: ");
int[] parametrs = ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
int[,] array = MyClass.CreateMatrix(parametrs[0], parametrs[1], 1, 10);
if (parametrs[0] == parametrs[1])
{
    WriteLine("По условию задачи массив должен быть прямоугольным");
    return;
}
MyClass.PrintMatrix(array);
WriteLine();
int[] arraySum = CreateMatrixSum(array);
// вывожу массив с суммами, чтобы легче проверить правильность метода по поиску нужной строки
WriteLine(String.Join(" ", arraySum));
FindMinElementsMatrix(arraySum);







int[] CreateMatrixSum(int[,] matrixForSum)
{
    int[] result = new int[matrixForSum.GetLength(0)];
    for (int i = 0; i < matrixForSum.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrixForSum.GetLength(1); j++)
        {
            sum += matrixForSum[i, j];
        }
        result[i] = sum;
    }
    return result;
}

void FindMinElementsMatrix(int[] matrixForSearcheMinimumElement)
{
    int minElement = matrixForSearcheMinimumElement[0];
    string minElementIndex = "0";
    for (int j = 1; j < matrixForSearcheMinimumElement.Length; j++)
    {
        if (minElement > matrixForSearcheMinimumElement[j])
        {
            minElement = matrixForSearcheMinimumElement[j];
            minElementIndex = $"{j + 1}";
        }
        else
        {
            if (minElement == matrixForSearcheMinimumElement[j])
            {
                minElementIndex += $"; {j + 1}";
            }
        }
    }
    WriteLine($"Номер строки с наименьшей суммой элементов: {minElementIndex}");
}

