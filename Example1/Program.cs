//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int SecondNumber = (num / 10) % 10;
    Console.WriteLine($" Вторая цифра в числе {num} -> {SecondNumber}");
}
else
{
    Console.WriteLine($"Число {num} не является трехзначным");
}
