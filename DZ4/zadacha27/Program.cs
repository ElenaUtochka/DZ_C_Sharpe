/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */



using static System.Console;
Clear();
WriteLine("Введите число ");
int number = int.Parse(ReadLine()!);
int[] NewArray = GetArray(number);
Write($"Сумма цифр в числе {number} равна {SumArray(NewArray)}");





int[] GetArray(int N)
{
    int Length = 0;
    int temp = N;
    while ((temp / 10) > 0)
    {
        temp = temp / 10;
        Length += 1;
    }
    int[] Array = new int[Length + 1];
    for (int i = (Length); i >= 0; i--)
    {
        Array[i] = N % 10;
        N = N / 10;
    }
    return Array;
}
int SumArray(int[] Mass)
{
    int sum = 0;
    for (int i = 0; i < Mass.Length; i++)
    {
        sum += Mass[i];
    }
    return sum;
}