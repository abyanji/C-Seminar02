Console.Clear();
Console.WriteLine("Введите два числа");
int firstDigit = int.Parse(Console.ReadLine());
int secondDigit = int.Parse(Console.ReadLine());

if (firstDigit / secondDigit == secondDigit || secondDigit / firstDigit == firstDigit)
{
    Console.WriteLine($"{firstDigit}, {secondDigit} -> да");
}
else
{
    Console.WriteLine($"{firstDigit}, {secondDigit} -> нет");
}
