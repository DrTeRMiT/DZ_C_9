// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    if (number1 != 0 && number2 == 0)
    {
        return AkkermanFunction(number1 - 1, 1);
    }
    if (number1 > 0 && number2 > 0)
    {
        return AkkermanFunction(number1 - 1, AkkermanFunction(number1, number2 - 1));
    }

    return AkkermanFunction(number1, number2);
}

Console.Write("Введите число: m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: n= ");
int n = Convert.ToInt32(Console.ReadLine());

int akkermanFunction = AkkermanFunction(m, n);

Console.WriteLine(akkermanFunction);