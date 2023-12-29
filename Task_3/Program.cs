// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

Console.WriteLine("Введите целое двухзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int firstNum = number % 10;
int secondNum = number / 10;

if (number < 10 || number > 99)
{
   Console.WriteLine("Введенное число не двухзначное"); 
}
else
{
    if (firstNum < secondNum)
    {
    Console.WriteLine($"Наибольшая цифра в числе {number} -> {secondNum}"); 
    }
    else
    {
        if (firstNum > secondNum)
        {
            Console.WriteLine($"Наибольшая цифра в числе {number} -> {firstNum}"); 
        }
        else
        {
            Console.WriteLine($"В числе {number} цифры равны и принимают значение {secondNum}"); 
        }
    }
}