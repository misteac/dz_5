/*Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.

Пример

“hello” => 2
“world” => 1 */

Console.WriteLine("Введите текст");
string text = Console.ReadLine();

int VowelsMethod(string line)  
{   
    int result = 0;
    char[] vowels = {'a', 'o', 'e', 'u', 'i','y'};
    for(int i = 0; i < line.Length; i++)
    {
        for(int j = 0; j < vowels.Length; j++)
        {
            if(vowels[j]==line[i])
            {
                result++;
            }
        }
    }
    return result;
}

Console.WriteLine(VowelsMethod(text));




//Получить массив чисел из строки формата 5455.2345,1234 234234

/*string input = Console.ReadLine();
string[] numbersAsStrings = input.Split(',', ' ', '.');


int[] numbers = new int[numbersAsStrings.Length];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(numbersAsStrings[i]);
}

Console.ReadLine();*/