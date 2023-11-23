/*На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.

Указание
Метод строки ToCharArray() не использовать.



Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] */

string text = "Hello!";

char[] ArrayFromString(string array)
{   
    char[] test = new char[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        test[i] = array[i];
    }
    return test;
}
// Console.WriteLine(typeof(ArrayFromString(text)));
 Console.WriteLine(ArrayFromString(text).GetType());
