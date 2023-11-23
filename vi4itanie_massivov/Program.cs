//Вычесть из одного списка другой список

string[] array1 = { 1, 23, 4, 5, 6, };
string[] array2 = { 1, 2, 3, 4, 56 };

string[] difference = array1.Except(array2).ToArray();

Console.WriteLine(string.Join(", ", difference));