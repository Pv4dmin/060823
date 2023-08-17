int InputWeekNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int number = InputWeekNum("Введи номер дня недели и я скажу выходной это или нет ");
if (number == 6 || number == 7)
{
    Console.WriteLine("Да, это выходной");
}
else Console.WriteLine("Нет, это не выходной");