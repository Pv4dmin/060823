void ThreeDigit(int num)
{
    if (num > 99 & num < 1000)
        Console.WriteLine($"Третьей цифрой в этом числе является цифра: {num % 10}");
    if (num < 100)
    {
        Console.WriteLine($"Третей цифры в числе {num} нет");
    }
    else if (num > 1000)
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        Console.WriteLine($"Третьей цифрой в этом числе является цифра: {num % 10}");
    }
}

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int number = InputNum("Введи любое число друг, и я покажу тебе волшебство ");
ThreeDigit(number);