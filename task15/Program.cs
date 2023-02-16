//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 5)
{
    Console.WriteLine ("Выходной день");
}
else 
{
    Console.WriteLine ("Рабочий день");
}
    