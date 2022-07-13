// Напишите программу, которая на вход принимает одно число(N), а на выходе показывает
// все целые числа от -N до N. 

Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());
int i = 0;
int temp = 0;
while (i < a * 2 + 1)
{
Console.WriteLine(-a + temp);
i++;
temp++;
}