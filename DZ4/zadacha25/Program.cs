/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

using static System.Console;
Clear();

WriteLine("Введите числа через пробел ");
int[] array = GetArrayFromString(ReadLine()!);
WriteLine($"{array[0]} в степени {array[1]} равно {GetPower(array)}");











int[] GetArrayFromString(string arrayString)
{
    string[] massString = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[massString.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(massString[i]);
    }
    return result;
}
int GetPower(int[] Massiv)
{
    int power = 1;
    for (int i = 1; i <= Massiv[1]; i++)
    {
        power = power * Massiv[0];
    }
    return power;
}
