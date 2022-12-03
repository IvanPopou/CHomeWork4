//Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
//Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, 
//“Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

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

int[] Array = GenerateArray();
PrintArray(Array);