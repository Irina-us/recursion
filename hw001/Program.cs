// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
System.Console.WriteLine("Выведм все натуральные числа в промежутке от N до 1");
System.Console.WriteLine("Введите целое число N");
int num = Convert.ToInt32 (Console.ReadLine());

Console.Write("Натуральные числа в промежутке от "+num+" до 1: ");

string Rec (int num)
{
    if (num == 0) return 0;
    
for (int count = 1; count <= num; count++)
        Console.Write(count+", ");

}
// string SummaRec (int num, int num2)
// {
//     if (num <= num2) return num+", ";
// else return SummaRec (num - 1, num2) + $"{num}, ";
// }
// System.Console.WriteLine(SummaRec (num, num2));
