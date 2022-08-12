/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

using static System.Console;
Clear();
WriteLine("Введите координату x точки А: ");
int xa = Convert.ToInt32(ReadLine());
WriteLine("Введите координату у точки А: ");
int ya = Convert.ToInt32(ReadLine());
WriteLine("Введите координату z точки А: ");
int za = Convert.ToInt32(ReadLine());
WriteLine("Введите координату x точки B: ");
int xb = Convert.ToInt32(ReadLine());
WriteLine("Введите координату у точки B: ");
int yb = Convert.ToInt32(ReadLine());
WriteLine("Введите координату z точки B: ");
int zb = Convert.ToInt32(ReadLine());

double gypotenuza= Math.Round(Math.Pow(((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb)),0.5),2);
WriteLine(gypotenuza);

