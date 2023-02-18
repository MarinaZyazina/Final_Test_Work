// Задача. Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.  
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] arrayFirst = new string[3] {"Russia", "Denmark", "Kazan"};
string[] arraySecond = new string[arrayFirst.Length];
GetShortArray(arrayFirst, arraySecond);
PrintArray(arrayFirst);
PrintArray(arraySecond);

void GetShortArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    { 
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count ++;
        }
    }
    if (count == 0) array2[0] = "Элементов массива длиной <= 3 нет";   
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
