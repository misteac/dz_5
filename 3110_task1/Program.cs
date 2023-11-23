// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

Random rand = new Random();
int length = 10;
int[] array = new int[length]; 

for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 100);
    Console.Write($"{array[i]} ");
}


for(int i = 0; i < array.Length; i++)
   { if(array[i] >= 20 && array[i] <= 90)
     Console.WriteLine($"{array[i]} ");
            
   }
