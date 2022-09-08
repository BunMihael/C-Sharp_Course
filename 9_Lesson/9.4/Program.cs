// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.


int Degree(int a, int b)
{
    if(b <= 1) return a;
    return  a * Degree(a, b - 1);
}

Console.WriteLine(Degree(2,5));