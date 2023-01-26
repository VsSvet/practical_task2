using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
string str = Convert.ToString(number);
int len = str.Length;
int count = 0;

if(len < 3)
{
    WriteLine("Третьей цифры нет");
}

while(count < len-3)
{
    number = number/10;
    count += 1;
}

WriteLine(number%10);