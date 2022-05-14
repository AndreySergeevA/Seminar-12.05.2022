/* Напишите программу, которая на вход принимает два числа и проверяет, является ли число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 -> нет
*/

Console.WriteLine("Введите первое число: ");
int num1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int result = num1 * num1;
int result2 = num2 * num2;

if((result == num2) || (result2 == num1))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

