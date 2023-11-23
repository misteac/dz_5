/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому,
 то программа выводит остаток от деления.

Примеры

14, 5 => нет, 4
16, 8 => да
4, 3  => нет, 1
*/

Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int result = a % b ;
if (result == 0)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет - остаток " + result);
}