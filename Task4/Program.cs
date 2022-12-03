//Напишите программу, которая из массива случайных чисел. 
//Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Сделать одним циклом

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray()
{
    int Length = Prompt("Введите количество элементов массива");
    int min = Prompt("Введите минимальный порог случайных значений");
    int max = Prompt("Введите максимальный порог случайных значений");
    int[] array = new int[Length];
    
    for(int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int SecondmaxFind(int[] array)
{
    int max = array[0];
    int SecondMax = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) 
        {
            SecondMax = max;
            max = array[i];
        }
        else if(array[i] > SecondMax)
        {
            SecondMax = array[i];
        }
    }
    return SecondMax;
}

int[] arr = GenerateArray();
PrintArray(arr);
int smax = SecondmaxFind(arr);
Console.WriteLine($"Второй максимум равен {smax}");
