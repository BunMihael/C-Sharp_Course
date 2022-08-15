// Напишите программу, которая выводит массив из 8ми 
// эллементов, заполненными нулями и единицами в случайном порядке.

void Mas(int num)
{
    int i = 0;
    int el = 0;
    while (i <= num)
    {
        el = new Random().Next(0, 2);
        Console.Write($"{el}, ");
        i++;
    }

} 
Mas(8);