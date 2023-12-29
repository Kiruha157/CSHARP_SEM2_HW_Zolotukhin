// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Input X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y");
int y = Convert.ToInt32(Console.ReadLine());
if(x == 0 || y == 0)
{
    Console.WriteLine("Введена нулевая координата");
}
if(x > 0 && y > 0)
{
    Console.WriteLine("I четверть");
}
if(x < 0 && y > 0)
{
    Console.WriteLine("II четверть");
}
if(x < 0 && y < 0)
{
    Console.WriteLine("III четверть");
}
if(x > 0 && y < 0)
{
    Console.WriteLine("IV четверть");
}