// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

    if ( num < 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else 
    {
        while (num > 1000)
        {
           num = num /10;
        }
        int result = num % 10;
        Console.WriteLine($"Третья цифра числа  ->  {result}");
    }