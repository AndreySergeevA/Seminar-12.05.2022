/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
string str = number.ToString();
Console.WriteLine($"{number} -> {str[1]}");