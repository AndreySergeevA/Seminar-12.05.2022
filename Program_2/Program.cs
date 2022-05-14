// Напишите программу, которая выводит трехзначное число и вытаскивает из него первое и последнее число

int number = new Random().Next(100,1000);
string str = number.ToString();

Console.WriteLine($"{number} -> {str[0]}{str[2]}");
