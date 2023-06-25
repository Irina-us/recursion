// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
System.Console.WriteLine("Посчитаем сумму натуральных элементов в промежутке от M до N");
System.Console.WriteLine("Введите значение M");
int num1 = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("Введите значение N");
int num2 = Convert.ToInt32 (Console.ReadLine());

int max = 1;
int min = 1;
if (num1 > num2)
{
    max = num1; //Console.WriteLine("max = "+num1);
    min = num2; //Console.WriteLine("min = "+num2);
} 
else
{
    max = num2; //Console.WriteLine("max = "+num2);
    min = num1; //Console.WriteLine("min = "+num1);
} 

if (min<0) 
{
    min = 0;
}
int SummaRec (int max)
{
    if (max==min-1) return 0;
    return max + SummaRec(max-1);
}
System.Console.WriteLine($"M = {num1}, N = {num2} -> {SummaRec(max)}");
