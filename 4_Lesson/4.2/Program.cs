// //Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

void Search(int a)
{
    int i = 1;
    int AllSum = 1;
    Console.Write($"{a} -> ");
    while (i <= a )
    {
        Console.Write($"{AllSum = AllSum * i}, ");
        i++;
    }
}
Search(5);

//int Method(int num)
//{
//int AllSum = 1;
//for (int i = 1; i <=num; i++)
//AllSum = AllSum * i;
//return AllSum;
//}
//Console.WriteLine(Method(4));
