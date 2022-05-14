/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
string str = number.ToString();
if(number / 100 > 0)
{
    Console.WriteLine($"{number} -> {str[2]}");
}
else
{
    Console.WriteLine($"{number} -> нет третьей цифры");
}
