// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int ResultFunction(int n, int m)
{
int sum = m;
if (m == n)
{
    return m;
}
if (n > m)
{
    return sum + ResultFunction(n, m + 1);
}
else
{
    return sum + ResultFunction(n, m - 1);
}
}

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма натуральных чисел от M до N");
Console.WriteLine(ResultFunction(n, m));