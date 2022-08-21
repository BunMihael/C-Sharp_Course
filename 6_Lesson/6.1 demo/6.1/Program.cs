// Напишите программу, котороая принимает на вход три числа
// и проверяет, может ли существовать треугольник такой длинны.

void SheckTriangle(int x, int y, int z)
{
    if (x + y > z && y + z > x && x + z > y)
    {
        Console.WriteLine("Make sense");
    }
    else
    {
        Console.WriteLine("Fail to exist");
    }
}

SheckTriangle(2,4,3);