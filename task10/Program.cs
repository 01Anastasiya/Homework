// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100 || a > 999)
{
    Console.WriteLine("Число не трехзначное ");
}
else 
{
    int secondDigit = a / 10 % 10;
    Console.WriteLine("Вторая цифра введеного числа " + secondDigit);
}
