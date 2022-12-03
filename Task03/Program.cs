// Console.Clear();
// Console.WriteLine("Введите два числа");
// int firstDigit = int.Parse(Console.ReadLine());
// int secondDigit = int.Parse(Console.ReadLine());

// int result = secondDigit % firstDigit;
// if (result == 0)
// {
//     Console.WriteLine($"{secondDigit}, {firstDigit} -> кратно");
// }
// else
// {
//     Console.WriteLine($"{secondDigit}, {firstDigit} -> не кратно, остаток {result}");
// }

Console.Clear();
Console.WriteLine("Введите число");
int digit = int.Parse(Console.ReadLine());

if (digit % 7 == 0 && digit % 23 == 0)
{
    Console.WriteLine($"{digit} -> да");
}
else
{
    Console.WriteLine($"{digit} -> нет");
}