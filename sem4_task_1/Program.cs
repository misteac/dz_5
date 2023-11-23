/* Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

Примеры

[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13]  => 3 */

Console.WriteLine("Введите размер массива ");
int lenght = Convert.ToInt32(Console.ReadLine()) ;
int[] array = new int[lenght] ;
Random rand = new Random();
int count_prost = lenght ;
//Делим на все числа на свете кроме 1 и самого себя 
for (int i = 0; i < lenght; i++)
{
array[i] = rand.Next(0,100);

        for (int count = 2 ; count < array[i]; count++)
        {
         if (array[i] % count == 0)
            {
                count_prost--;
                break;
            }
        

        }
}
Console.WriteLine("в массиве " + string.Join(", ", array) + " чило просто элементов " + count_prost );