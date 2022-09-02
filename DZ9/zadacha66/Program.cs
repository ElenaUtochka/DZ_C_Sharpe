/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using static System.Console;
Clear();

WriteLine("Введите первое число: ");
int numberM = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int numberN = int.Parse(ReadLine()!);
WriteLine($"{GetSumElements(numberM, numberN)}");




int GetSumElements(int number1, int number2)
{
    if (number1 == number2) return number2;
    else if (number1 > number2) return number2 + GetSumElements(number1, number2 + 1);
    else return number1 + GetSumElements(number1 + 1, number2);
}
