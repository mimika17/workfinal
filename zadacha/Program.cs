// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// Решение через два массива
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите строки массива");
string[] FillArray(int n)
{
    string[] collection = new string[n];
    int index = 0;
    while (index < n)
    {

        collection[index] = Convert.ToString(Console.ReadLine());
        index++;
    }
    return collection;
}
string[] Chair3Array(string[] arr)
{
    string[] collection = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            collection[j] = arr[i];
            j++;
        }
    }
    Array.Resize(ref collection, j);
    return collection;
}
string[] array = FillArray(n);
string[] array1 = Chair3Array(array);
Console.WriteLine($"[{string.Join(" ,", array1)}]");

// Решение через один массив
// Console.Write("Введите размер массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Вводите строки массива");
// string[] FillArray(int n)
// {
//     string[] arrayStrings = new string[size];
//     int pos = 0;
//     for (int i = 0; i < n; i++)
//     {
//         string element = Convert.ToString(Console.ReadLine());
//         if (element.Length <= 3)
//         {
//             arrayStrings[pos] = element;
//             pos++;
//         }
//     }
//     Array.Resize(ref arrayStrings, pos);
//     return arrayStrings;
// }
// Console.WriteLine($"[{string.Join(" ,", FillArray(size))}]");
