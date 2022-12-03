// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SummOfDigits(int Number)
{
    int summ = Number%10;
    while(Number >= 10)
    {
    Number = Number/10;   
    summ = summ + Number%10;
    }
    return summ;
}

int number = Prompt("Введите число");
int summary = SummOfDigits(number);

System.Console.WriteLine($"Сумма цифр числа равна {summary}");
