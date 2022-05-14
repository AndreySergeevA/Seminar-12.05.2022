// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
string number_1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string number_2 = Console.ReadLine();
int first = int.Parse(number_1);
int second = int.Parse(number_2);
int num = first % second;

if(num == 0)
{
    Console.WriteLine("Кратно");
}
else{
    Console.WriteLine($"Не кратно, остаток {num}");
}