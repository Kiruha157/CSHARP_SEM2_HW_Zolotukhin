// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int ost1 = number % 7;
int ost2 = number % 23;

if(ost1 == 0 && ost2 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {number} не кратно одновременно 7 и 23");
}