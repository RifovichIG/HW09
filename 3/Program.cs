//Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
//M = 28; N = 7 -> 7

System.Console.WriteLine("Задайте числа m и n (через , или пробел):");
char[] separators = { ' ', ',', ';' };
int[] mn = Array.ConvertAll(Console.ReadLine()!.Split(separators), int.Parse);

if (mn[0] > mn[1])
    (mn[0], mn[1]) = (mn[1], mn[0]);
System.Console.Write(" ");
Task68(mn[0], mn[1]);
void Task68(int m, int n)
{
    if (m == n)
    {
        System.Console.WriteLine("Наибольший общий делитель равен " + m);
        return;
    }
    if (m > n)
        (m, n) = (n, m);
    Task68(m, n - m);
}