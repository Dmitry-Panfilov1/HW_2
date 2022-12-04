//  Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

if ((number > 99 && number < 1000) || (number > -999 && number < -100))
{
    int num2 = (number%100)/10;

    if (num2 < 0)
    {
        num2 = num2*(-1);
    }

    Console.WriteLine(num2);
}
else 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}