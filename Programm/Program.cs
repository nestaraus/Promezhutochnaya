Console.Write("Введите количество элементов из которых состоит массив: ");
int n = Convert.ToInt32(Console.ReadLine()); 
string[] arr = new string[n]; 
void InputArray(string[] array)
{

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i + 1}: ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("Вы ввели следующий массив:");
    Console.Write($"[{array[0]}");
    for (int i = 1; i < n; i++)
    {
        Console.Write($",{array[i]}");
    }
    Console.WriteLine("]");
}
InputArray(arr);