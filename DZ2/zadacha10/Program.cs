//Задача10 Поиск 2 цифры в трехзначном числе
using static System.Console;
Clear();
WriteLine("Введите трехзначное число: ");
int Number = Convert.ToInt32(ReadLine());
if (Number < 100 || Number > 999)
{
    Write("Число не является трехзначным");
}
else
{
    int temp = Number / 10;
    Number = temp % 10;
    Write($"Вторая цифра числа {Number}");
}