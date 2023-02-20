// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите X: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int Y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int Z = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X1: ");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1: ");
int Z1 = int.Parse(Console.ReadLine());
int A = (X1-X)*(X1-X);
int B = (Y1-Y)*(Y1-Y);
int C = (Z1-Z)*(Z1-Z);
double ABC = Math.Sqrt(A + B + C);
Console.WriteLine(Math.Round (ABC, 3));