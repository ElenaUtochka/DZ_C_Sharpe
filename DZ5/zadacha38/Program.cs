/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76 */

using static System.Console;
Clear();
WriteLine("Задайте размер массива вещественных чисел ");
int countArray = int.Parse(ReadLine()!);
int[] Array = GetArray(countArray);
WriteLine($"{String.Join(" ", Array)}");
WriteLine($"Разница между максимальным {GetMax(Array)} и минимальным {GetMin(Array)} элементами массива равна {GetDifference(GetMax(Array),GetMin(Array))}");








int[] GetArray(int count) 
{
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = new Random().Next(-99, 100);
    }
    return result;
}

int GetMin(int[] MinMassive)
{
    int minimum = MinMassive[0];
    for (int i = 1; i < MinMassive.Length; i++)
    {
       minimum=minimum>MinMassive[i]?MinMassive[i]:minimum;
    }
    return minimum;
}

int GetMax(int[] MaxMassive)
{
    int maximum=MaxMassive[0];
for (int i = 1; i < MaxMassive.Length; i++)
{
    maximum=maximum<MaxMassive[i]?MaxMassive[i]:maximum;
}
    return maximum;
}

int GetDifference(int maxArray, int minArray)
{
   int difference=maxArray-minArray;
   return difference;
}