/*Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные элементы на положительные, а положительные на отрицательные.

Пример

[1 -5 6]

=> [-1 5 -6]
*/






Random rand = new Random();
int length = 10;
int[] array = new int[length]; 

for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 10);
    Console.Write($"{array[i]} ");
}


for(int i = 0; i < array.Length; i++)
{
array[i] = -1 * array[i];
Console.WriteLine("\n Элемент " + (i+1) + " будет равен " + array[i]);
}


