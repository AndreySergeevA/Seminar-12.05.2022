/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели числом: ");
int dayNumber = int.Parse(Console.ReadLine());
string[] Day = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $". Да, это выходной!";
else txtResult = $", нет, рабочий день.";
Console.WriteLine($"{dayNumber} -> {Day[dayNumber - 1]}{txtResult}");