// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B:
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b<1)
Console.Write("Введите натуральное число!");
else
{
while (b!=0)
{
c = c * a;
b = b - 1;
}
Console.Write("Число A в натуральной степени B равно {0}", c);
}