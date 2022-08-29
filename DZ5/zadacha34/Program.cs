/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */
using static System.Console;
Clear();

WriteLine("Задайте размер массива ");
int ArrayCount=int.Parse(ReadLine()!);
int[] Array = GetArray(ArrayCount);
WriteLine($"{String.Join(" ", Array)}");
WriteLine($"Количество четных чисел в массиве {GetPositiveCount(Array)}");







int[] GetArray(int count)
{
    int[] result=new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i]=new Random().Next(100, 1000);
    }
    return result;
}

int GetPositiveCount(int[] massive)
{
    int PositiveCount =0;
for (int i = 0; i < massive.Length; i++)
{
    
    PositiveCount+=massive[i]%2==0?1:0;
}
    return PositiveCount;
}