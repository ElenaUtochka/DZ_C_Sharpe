//Задача6 Проверка числа на четность
using static System.Console;
Clear();
WriteLine("Введите число: ");
int number = Convert.ToInt32 (ReadLine());
if(number%2 == 0)
{
    Write("Четное");
}
else
{
    WriteLine("Нечетное");
}