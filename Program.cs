// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());
// int [] array = { x };
// int n = array.Length;
// //int index = 0;

// if (x >= 10000 && x <= 99999)
// {
//     //int[] array = { x };
//     if     (array[0] == array[4] && array[1] == array[3])
//     {
//         Console.WriteLine("Это число пaлиндром ");
//     }
// }
// else
//     Console.WriteLine("Это число не пaлиндром");


Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int y1 = 0;
int y2 = 0;
int y4 = 0;
int y5 = 0;

if (x >= 10000 && x <= 99999)
{
    y1 = x % 10;
    y5 = x % 100000 / 10000;
    y2 = x % 100 /10;
    y4 = x % 10000 / 1000;
//Console.WriteLine($"цифры {y1} {y2} {y4} {y5}");
    if (y1 == y5 && y2 == y4)
    {
        Console.WriteLine("Это число пaлиндром ");
    }
    else
    Console.WriteLine("Это число не пaлиндром");
}
