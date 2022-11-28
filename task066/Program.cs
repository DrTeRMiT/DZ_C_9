// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int number1, int number2)
{
    if (number1 == number2)
    {
        return number1;
    }
    if (number1 > number2)
    {
        return number1 + SumNumbers(number1 - 1, number2);
    }
    else
    {
        return number1 + SumNumbers(number1 + 1, number2);
    }
}

Console.Write("Введите число: m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: n= ");
int n = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(m, n);

Console.WriteLine(sumNumbers);