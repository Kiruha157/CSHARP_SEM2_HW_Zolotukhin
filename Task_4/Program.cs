// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.WriteLine("Введите целое двухзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numCut = number;
int i = 10;

if (number < 0)
{
    Console.WriteLine("Вы ввели ненатуральное число");
}
else
{
    if ((number / 10) == 0)
    {
        Console.WriteLine(number);
    }
    else
    {   
        while (numCut > 9)
        {
            i = (i * 10);
            numCut = (number / i);

        }
        // Console.WriteLine(i);
    }
    Console.Write($"{number} =>");
    while(i > 0)
    {
        numCut = (number / i);
        number = (number % i);
        i = (i / 10);

        Console.Write($"{numCut}, ");

    }
    
}