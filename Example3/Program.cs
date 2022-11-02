//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным
System.Console.WriteLine("Введите день недели от 1 до 7");
int num = int.Parse(Console.ReadLine());
if (num>0 && num < 8)
{
    if (num == 1)    {
        Console.WriteLine("Понедельник - нет");
    }
    if (num == 2)    { 
        Console.WriteLine("Вторник - нет");
    }
    if (num == 3)    {
        Console.WriteLine("Среда - нет");
    }
    if (num == 4)    {
        Console.WriteLine("Четверг - нет");
    }
    if (num == 5)    {
        Console.WriteLine("Пятница - нет");
    }
    if (num == 6)    {
        Console.WriteLine("Суббота - да");
    }
    if (num == 7)    {
        Console.WriteLine("Воскресенье - да");
    }
}    
else
    {
        Console.WriteLine("Число введено неверно");
    }