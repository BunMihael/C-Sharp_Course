// Напишите программу, которая будет переводить десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2-> 10

/* Console.WriteLine("Write a number: ");
int x = int.Parse(Console.ReadLine());
string a = Convert.ToString(x,2);
Console.WriteLine(a); */

string ChangeNum(int num)
{
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

Console.WriteLine(ChangeNum(5));
