﻿Console.Write("Введите количество элементов из которых состоит массив: ");
int a = Convert.ToInt32(Console.ReadLine()); 
string[] arr = new string[a]; 
void InputArray(string[] array)
{

    for (int i = 0; i < a; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i + 1}: ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("Вы ввели следующий массив:");
    Console.Write($"[{array[0]}");
    for (int i = 1; i < a; i++)
    {
        Console.Write($",{array[i]}");
    }
    Console.WriteLine("]");
}
InputArray(arr);
string[] Release(string[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            n++;
    }
    string[] array2 = new string[n];
    int m = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[m] = array[i];
            m++;
        }
    }
    return array2;
}
void PrintArray(string[] array)
{
    Console.WriteLine($"Полученный массив из элементов с тремя символами:");
    Console.Write($"[ {array[0]} ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
Release(arr);
PrintArray(Release(arr));