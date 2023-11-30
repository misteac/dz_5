// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

akkerman_function(m,n);


void akkerman_function(int m, int n)
{
    Console.Write(akkerman(m, n)); 
}


int akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return akkerman(m - 1, 1);
    }
    else
    {
        return (akkerman(m - 1, akkerman(m, n - 1)));
    }
}