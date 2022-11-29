string[] array1 = new string[5] {"12333", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];

Console.WriteLine($"Заданный вами массив: {array1[0]} ");
Console.WriteLine($"Заданный вами массив: {array1[1]} ");
Console.WriteLine($"Заданный вами массив: {array1[2]} ");
Console.WriteLine($"Заданный вами массив: {array1[3]} ");
Console.WriteLine($"Заданный вами массив: {array1[4]} ");

SecondArrayWithIF(array1, array2);

Console.WriteLine($"Результат соответсвющий требованиям: ");

PrintArray(array2);

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

