//Задайте массив символов (тип char []). Создайте строку из символов этого массива. 

//Указание
//Конструктор строки вида string(char []) не использовать.



//Пример
//[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


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