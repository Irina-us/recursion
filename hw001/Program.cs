// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();
Console.WriteLine("Ввыведем все натуральные числа в промежутке от N до 1");
Console.Write("Введите целое число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Натуральные числа в промежутке от "+num+" до 1: ");
int count = 1;
Array (num, count);
void Array(int n, int count)
{
    if (count > n) return;
    else Array (n, count + 1);
    Console.Write(count + " ");
}