// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write($"Введите челое число M: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write($"Введите челое число N: ");
int n = int.Parse(Console.ReadLine() ?? "");
int result = 0;
Console.Write($"M = {m}; N = {n} -> ");

if (m < n)
    result = PrintSumNuturals(m, n, result);
    else
    result = PrintSumNuturals(n, m, result);

Console.Write($"{result}");

static int PrintSumNuturals(int m, int n, int result)
{
    if (m > n)
    {
        return result;
    }
    result += m;
    return(PrintSumNuturals(m + 1, n, result));
}