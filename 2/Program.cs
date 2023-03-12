//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии
//M = 1; N = 5 -> 2, 4
//M = 4; N = 8 -> 4, 6, 8.
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");        
if (M>N)
for (int i = N; i <= M; i++)
Console.Write($" {i}");
else
for(int i=1;i<=N;i++)
{
if (i % 2 == 0)
System.Console.Write(i + " ");
}
    
    
   
