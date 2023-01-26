Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int number1 = number%100;

Console.Write($"Вторая цифра числа {number} равна {number1/10}");