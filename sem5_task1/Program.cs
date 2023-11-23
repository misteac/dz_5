//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int find_elenent(int i , int j)
{
    int[,] array2 = new int[,] {{1, 2, 3}, 
                                {4, 5, 6},
                                {7, 8, 9}};
 if (i < 4 && j < 4)
return array2[i,j];
 else 
 Console.WriteLine("Такого элемента не существует");
 return 0;
}
Console.WriteLine("Введиое номер строки элемента в двумерном массиве ");
int i = Convert.ToInt32(Console.ReadLine()) -1;
Console.WriteLine("Введиое номер столбца элемента в двумерном массиве ");
int j = Convert.ToInt32(Console.ReadLine()) -1;
int result = find_elenent(i,j);
Console.WriteLine(result);