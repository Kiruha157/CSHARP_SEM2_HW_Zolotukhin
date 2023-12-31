// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int numCut = number;
int range = (Convert.ToInt32(number.ToString().Length) - 1);
int i = Convert.ToInt32(Math.Pow(10,range));
int firstNum = number / i;
string text1 = number.ToString(number + "==> " + firstNum.ToString());
string text2 = text1;

i = i / 10;
while(i > 1)
{
    numCut = number % (i);
    text2 = text2 + ", " + numCut.ToString();
    i = i / 10;
}

// string text = number;

Console.WriteLine(text2);
//Console.WriteLine(i);

// while (i > 0)
// {

// }

// if (number < 0)
// {
//     Console.WriteLine("Вы ввели ненатуральное число");
// }
// else
// {
//     if ((number / 10) == 0)
//     {
//         Console.WriteLine(number);
//     }
//     else
//     {   
//         while (numCut > 9)
//         {
//             i = (i * 10);
//             numCut = (number / i);

//         }
//         // Console.WriteLine(i);
//     }
//     Console.Write($"{number} =>");
//     while(i > 0)
//     {
//         numCut = (number / i);
//         number = (number % i);
//         i = (i / 10);

//         Console.Write($"{numCut}, ");

//     }
    
// }