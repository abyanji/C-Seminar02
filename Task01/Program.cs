Console.Clear();
int randomDigit = new Random().Next(10, 100);
Console.WriteLine($"Слуачйное число {randomDigit}");

int remainder = randomDigit % 10;
Console.WriteLine($"Последняя цифра {remainder}");

int div = randomDigit / 10;
Console.WriteLine($"Первая цифра {div}");

int max = div;

if (max < remainder)
{
    max = remainder;
}
Console.WriteLine($"Максимум {max}");

