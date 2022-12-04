// Напишите программу, которая выводит третью цифрузаданного числа или сообщает, что третьей цифры нет. Отрицательные числа должны нормально работать.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int num = number;

if (num < 100 && num > -100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

 while (num > 1000 || num < -1000)
    {
        num = num/10;
    }

int num3 = num%10;

if (num3 < 0)
{
    num3 = num3*(-1);
}
Console.WriteLine(num3);