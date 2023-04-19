// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
//на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

Console.WriteLine("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] arrayLine = new string[m];
string[] arrayLineResult = new string[m];

FillArray(arrayLine);
Console.WriteLine();
Console.WriteLine($"Получили исходный массив: ");
PrintArray(arrayLine);

Elementscuter(arrayLine, arrayLineResult);

Console.WriteLine();
Console.WriteLine($"Получили новый массив с элементами, длина которых меньше, либо равна 3 символам: ");
PrintArray(arrayLineResult);

void FillArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] inArray)
{
    Console.Write("[ ");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {

        Console.Write($"{inArray[i]} ");
    }
    Console.WriteLine("]");
}

void Elementscuter(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
