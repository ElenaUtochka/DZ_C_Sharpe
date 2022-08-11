//Задача15 принимаеv на вход цифру, обозначающую день
// недели, и проверяет, является ли этот день выходным.
using static System.Console;
Clear();
WriteLine("Введите число: ");
int Number = Convert.ToInt32(ReadLine());
if (Number < 1 || Number > 7)
{
    Write("Данная цифра не соответствует ни одному дню недели");
}
else
{
    if (Number > 5)
    {
        Write("Да");
    }
    else
    {
        Write("Нет");
    }
}