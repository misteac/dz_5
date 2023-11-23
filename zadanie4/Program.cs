/* 
Администратор
Напишите программу, которая выводит третью с конца цифру заданного числа или сообщает, что третьей цифры нет.


456  =>  6
7812  =>  1
91  =>  Третьей цифры нет


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