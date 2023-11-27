//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[] array = {'a', 'b', 'c', 'd'};

string ArrayString (char[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result = array[i] + result; // перевернули обратно,иначе: result +c array[i]
    }
    return result;
}
Console.WriteLine(ArrayString(array));