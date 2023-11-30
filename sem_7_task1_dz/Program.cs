// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M: ");
int first_value = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int last_value = Convert.ToInt32(Console.ReadLine());

void natural_value(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m}, ");
    natural_value(m + 1, n);
}
natural_value(first_value, last_value);