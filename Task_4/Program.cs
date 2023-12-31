// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int numCut = number;
int numCutTemp = number;
int range = (Convert.ToInt32(number.ToString().Length) - 1);
int i = Convert.ToInt32(Math.Pow(10,range));
int firstNum = number / i;
string text1 = number.ToString(number + "==> " + firstNum.ToString());
string text2 = text1;
//Console.WriteLine(i);

//i = i / 10;
//Console.WriteLine(i);
//Console.WriteLine(number);
numCut = number % i;
//Console.WriteLine(numCut);
numCutTemp = numCut;
//Console.WriteLine(numCutTemp);
//i = i / 10;


while(i > 1)
{
    numCutTemp = numCutTemp % i;
    
    numCut = numCutTemp/ (i / 10);
       
    //Console.WriteLine(numCut);
    
    i = i / 10;
    text2 = text2 + ", " + numCut.ToString();
 
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