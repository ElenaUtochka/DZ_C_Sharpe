/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N по убыванию.
M = 1; N = 5. -> ""5,4,3,2,1""
M = 4; N = 8. -> ""8,7,6,5,4"" */

using static System.Console;
Clear();
WriteLine("Введите число M");
int numM = int.Parse(ReadLine()!);
WriteLine("Введите число N");
int numN = int.Parse(ReadLine()!);
WriteLine(Stringofnumbers(numM, numN));



string Stringofnumbers(int number1, int number2)
{
    if (number1 == number2) return $"{number1}";
    else if (number1 > number2) return $"{number1} {Stringofnumbers(number2, number1 - 1)}";
    else return $"{number2} {Stringofnumbers(number1, number2 - 1)}";

}