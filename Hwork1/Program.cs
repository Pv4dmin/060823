//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void ThreeDigit(int num)
{
    if (num > 99 && num < 1000)
    {
        Console.WriteLine($"Вторая цифра этого числа это {num / 10 % 10}");
    }
    else
        Console.WriteLine("Сказано же трёхзначное, а ты что ввёл? Эх грамотей.)");
}
Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine()!);
ThreeDigit(number);
