// Напишите программу, которая будет принимать на вход два числа
// и выводить, являтеся второе число кратным певрому. Если число не 
// кратное первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Write a number A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number B: ");
int b = int.Parse(Console.ReadLine());

if(a/b == b)
{
    Console.WriteLine($"Число {b} кратное {a}");
}
else 
{
    Console.WriteLine($"число {b} не кратно {a}");
}

// Второй вариант решения 

// void Method1 (int a, int b)
// {
// if (a%b == 0)
// Console.WriteLine ("кратно");
// else
// {
// Console.WriteLine ($"не кратно {a%b}");
// }
// }
//Method1 (16,4);