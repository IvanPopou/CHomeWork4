//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int NaturalDegree(int number, int degree)
{
    int outcome = number;
    for(int i = 0; i < degree-1; i++)
    {
        outcome = outcome*number;
    }
    return outcome;
}

int numberA = Prompt("Введите число А");
int numberB = Prompt("Введите число B");

int effect = NaturalDegree(numberA, numberB);

System.Console.WriteLine($"Результат вычисления {effect}");