//Задача8 Вывод всех четных чисел от 1 до N
using static System.Console;
Clear();
WriteLine("Введите число: ");
int number = Convert.ToInt32 (ReadLine());
int i=1;
while(i<=number)
{
    if(i%2 == 0)
    {
        Write($"{i} ");
    }
    i++;
}