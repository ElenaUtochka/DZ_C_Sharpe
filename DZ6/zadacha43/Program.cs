/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

using static System.Console;
Clear();
WriteLine("Введите значение b1");
int b1 = int.Parse(ReadLine()!);
WriteLine("Введите значение k1");
int k1 = int.Parse(ReadLine()!);
WriteLine("Введите значение b2");
int b2 = int.Parse(ReadLine()!);
WriteLine("Введите значение k2");
int k2 = int.Parse(ReadLine()!);
WriteLine($"Прямые, заданные уравнениями у={k1}*x+{b1} и y={k2}*x+{b2}, пересекаются в точке с координатами [{String.Join(";", GetDote(b1, k1, b2, k2))}]");









int[] GetDote(int a1, int f1, int a2, int f2)
{
    int[] result = new int[2];
    if (f1 != f2)
    {
        result[0] = (a2 - a1) / (f1 - f2);
        result[1] = f1 * result[0] + a1;
    }
    else
    {
        WriteLine("Прямые не пересекаются");
    }
    return result;
}

