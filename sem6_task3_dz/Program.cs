//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


Console.WriteLine("Введите произвольную строку");
string text = Console.ReadLine().ToLower();

string palindrom( string message)
{   
    string check = string.Empty;
    for( int i = 0; i < text.Length; i++)
    {
        check = message[i] + check;
    }
    if ( check == message)
    {
        Console.WriteLine($"{text} строка явялется палиндромом");
    }
    else 
    {
        Console.WriteLine($"{text} строка не явялется палиндромом");
    }
    return check;
}
palindrom(text);