Console.Clear();
int randomDigit = new Random().Next(100, 1000);
Console.WriteLine($"Слуачйное число {randomDigit}");

int firstDigit = randomDigit / 100 * 10;

int secondDigit = randomDigit % 10;

int newDigit = firstDigit + secondDigit;
Console.WriteLine($"Новое число {newDigit}");