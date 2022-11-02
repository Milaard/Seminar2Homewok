//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным
System.Console.WriteLine("Введите день недели от 1 до 7");
int num = int.Parse(Console.ReadLine());
if (num>0 && num < 6)
{
    Console.WriteLine("НЕТ");
}    
else
    if (num > 5 && num < 8)
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("Число введено неверно");
    }