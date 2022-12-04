// Напишитепрограмму, которая принимает на вход принимает цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if (number < 1 || number > 7)
{
    Console.WriteLine("Нет такого дня недели");
    return;
}
if (number > 5)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
