// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int number =
// Convert.ToInt32(Console.ReadLine());
// int reversedNumber = 0;
// int temp = number;
// while (temp > 0)
// {
//     reversedNumber = (reversedNumber * 10 + temp % 10);
// }
// if (number == reversedNumber)
// {
//     Console.WriteLine("Число палиндромное");
// }
// else
// {
//     Console.WriteLine("Число не палиндромное");
// }

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)

    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - Не палиндром");
    }