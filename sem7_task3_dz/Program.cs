// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

int[] random_array()
{
Console.WriteLine("Введите размер массива");
int length_array = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length_array];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
    {
    array[i] = rand.Next(0, 99);
    Console.Write($"{array[i]} ");
    }
    return array;
}
int[]result_array = random_array();

void reverse_array(int[] my_array, int i = 0)
    
{
   if(i < my_array.Length)
   {
   reverse_array(my_array, i+1);
   Console.Write(my_array[i] + "|");
   }

}
Console.WriteLine();
reverse_array(result_array);
