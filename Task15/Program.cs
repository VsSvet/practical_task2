using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());

if(number > 0 & number < 6)
{
    WriteLine($"{number} -> нет");
}

if(number > 5 & number < 8)
{
    WriteLine($"{number} -> да");
}

if(number< 1 || number > 7)
{
    WriteLine($"Неправильный номер дня недели");
}