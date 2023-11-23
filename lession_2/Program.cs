/* Напишите программу, которая принимает на вход  трёхзначное число и удаляет вторую цифру этого числа.

Примеры

a = 256	=> 26 
a = 891	=> 81*/
Console.WriteLine("Введите число");    
int a = Convert.ToInt32(Console.ReadLine());
//int a = 583;
if (a > 99 && a < 1000)
{
int one_a = a / 100;
int last_a = a % 10;
int result = one_a *10 + last_a;
Console.WriteLine(result);
}
else Console.WriteLine("Неверное число");
