// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int ResultFunction(int n)
{
if (n == 1)
{
    return 1;
}
Console.Write(n + " ");
return ResultFunction(n -1);
}

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(ResultFunction(n));