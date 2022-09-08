// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от 1 до при помощи рекурсии.
// N = 5 -> "1,2,3,4,5"

void ValueSet(int num)
{
    if (num == 0) return;
    ValueSet(num - 1);
    Console.WriteLine($"{num}, ");
}

ValueSet(5);