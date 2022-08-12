/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

using static System.Console;
Clear();
WriteLine("Введите число: ");
int Number = Convert.ToInt32(ReadLine());
bool flag = false;
bool comparison(int a, int b) //решила попробовать решить через функцию
{
    if (a == b)
    {
        flag= true;
        return flag;
    } 
    else
    {
        flag=false;
        return flag;
    }
}
comparison((Number/10000),(Number%10));
if (flag==true)
{
    comparison(((Number/1000)%10),((Number/10)%10));
    if (flag == true)
    {
        Write("Число является палиндроном");
    }
}
else
{
    Write("Число не является палиндроном");
}