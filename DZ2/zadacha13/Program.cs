//Задача13 Поиск 3 цифры слева в числе
using static System.Console;
Clear();
WriteLine("Введите число: ");
int Number = Convert.ToInt32(ReadLine());
int index = 0;
int Number2 = 0;
int temp = Number;
while ((temp) > 0)
{
    temp = temp / 10;
    index++;
}
if (index < 3)
{
    Write("В числе нет третьей цифры");
}
if (index == 3)
{
    Number2 = Number % 10;
    Write($"Третья цифра числа равна {Number2}");
}
temp = 0;
if (index > 3)
{
    temp = Convert.ToInt32(Number / Math.Pow(10, (index - 3)));
    Number2 = temp % 10;
    Write($"Третья цифра числа равна {Number2}");
}
